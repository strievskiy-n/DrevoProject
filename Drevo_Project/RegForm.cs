using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drevo_Project
{
    public partial class RegForm : Form
    {
        public String Namen { get; set; }
        public String Surname { get; set; }
        public String Otch { get; set; }
        public String DataBorn { get; set; }

        public String Mail { get; set; }

        public String Password { get; set; }
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            
        }



        private void btOK_Click(object sender, EventArgs e)
        {
            Surname = textBoxSurname.Text;
            Namen = textBoxName.Text;
            Otch = textBoxLastname.Text;
            DataBorn = textBoxDataBorn.Text;
            Mail = textBoxMail.Text;
            Password = textBoxPassword.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
