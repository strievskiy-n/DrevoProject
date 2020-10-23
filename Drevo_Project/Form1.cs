using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace Drevo_Project
{
    public partial class Form1 : Form
    {



        private String dbName;
        private SQLiteConnection connect;
        private SQLiteCommand command;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect = new SQLiteConnection();
            command = new SQLiteCommand();

            dbName = "sample.sqlite";
            lbConnectMsg.Text = "Не соединено с БД";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (File.Exists(dbName))
            {
                MessageBox.Show("Уже существует, нажмите Подключиться к БД");
            }

            if (!File.Exists(dbName))
            {
                SQLiteConnection.CreateFile(dbName);
            }

            try
            {
                connect = new SQLiteConnection("Data Source=" + dbName + ";Version=3;");
                connect.Open();
                command.Connection = connect;

                command.CommandText = "CREATE TABLE IF NOT EXISTS Catalog (id INTEGER PRIMARY KEY AUTOINCREMENT, surname TEXT, name TEXT, otch TEXT, dataBorn TEXT, mail TEXT, password TEXT)";
                command.ExecuteNonQuery();

                lbConnectMsg.Text = "Cоединено с БД";
            }
            catch(SQLiteException ex)
            {
                lbConnectMsg.Text = "Не соединено с БД";
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!File.Exists(dbName))
            {
                MessageBox.Show("Пожалуйста нажмите сначала Создать БД! Создаться таблица и уже можно будет к ней подключиться!");
            }

            try
            {
                connect = new SQLiteConnection("Data Source=" + dbName + ";Version=3;");
                connect.Open();
                command.Connection = connect;

                lbConnectMsg.Text = "Cоединено с БД";

            }
            catch (SQLiteException ex)
            {
                lbConnectMsg.Text = "Не соединено с БД";
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnReadDB_Click(object sender, EventArgs e)
        {

            DataTable dTable = new DataTable();
            String sqlQuery;


            if (connect.State != ConnectionState.Open)
            {
                MessageBox.Show("Сначала подключитесь к БД!");
                return;
            }

            try
            {
                sqlQuery = "SELECT * FROM Catalog";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, connect);
                adapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    dgvViewer.Rows.Clear();

                    for (int i = 0; i < dTable.Rows.Count; i++)
                        dgvViewer.Rows.Add(dTable.Rows[i].ItemArray);
                }
                else
                    MessageBox.Show("БД пуста");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnToReg_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                MessageBox.Show("Сначала подключитесь к БД!");
                return;
            }

            RegForm addData = new RegForm();
            if (addData.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    command.CommandText = "INSERT INTO Catalog ('surname', 'name', 'otch', 'dataBorn', 'mail', 'password') values ('" +
                        addData.Surname + "' , '" +
                        addData.Namen + "' , '" +
                        addData.Otch + "' , '" +
                        addData.DataBorn + "' , '" +
                        addData.Mail + "' , '" +
                        addData.Password + "')";

                    command.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnToLogin_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                MessageBox.Show("Сначала подключитесь к БД!");
                return;
            }

            Login checkUser = new Login();

            if(checkUser.ShowDialog() == DialogResult.OK)
            {
                
            }
            

        }
    }

}