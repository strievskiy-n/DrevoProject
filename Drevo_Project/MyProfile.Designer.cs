namespace Drevo_Project
{
    partial class MyProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelChk = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbFIO = new System.Windows.Forms.Label();
            this.lbDataBorn = new System.Windows.Forms.Label();
            this.panelMyProfile = new System.Windows.Forms.Panel();
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.panelDrevo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonMyProfile = new System.Windows.Forms.Button();
            this.buttonDrevo = new System.Windows.Forms.Button();
            this.buttonPhotoAlbum = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.panelMyProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            this.panelDrevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(24, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(453, 592);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(445, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Биография";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(445, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Фотографии";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(445, 559);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Контакты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelChk
            // 
            this.labelChk.AutoSize = true;
            this.labelChk.Location = new System.Drawing.Point(12, 7);
            this.labelChk.Name = "labelChk";
            this.labelChk.Size = new System.Drawing.Size(67, 13);
            this.labelChk.TabIndex = 2;
            this.labelChk.Text = "соединение";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbFIO
            // 
            this.lbFIO.AutoSize = true;
            this.lbFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFIO.Location = new System.Drawing.Point(497, 26);
            this.lbFIO.Name = "lbFIO";
            this.lbFIO.Size = new System.Drawing.Size(42, 20);
            this.lbFIO.TabIndex = 5;
            this.lbFIO.Text = "Фио";
            // 
            // lbDataBorn
            // 
            this.lbDataBorn.AutoSize = true;
            this.lbDataBorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDataBorn.Location = new System.Drawing.Point(497, 60);
            this.lbDataBorn.Name = "lbDataBorn";
            this.lbDataBorn.Size = new System.Drawing.Size(100, 20);
            this.lbDataBorn.TabIndex = 6;
            this.lbDataBorn.Text = "Даты жизни";
            this.lbDataBorn.Click += new System.EventHandler(this.lbDataBorn_Click);
            // 
            // panelMyProfile
            // 
            this.panelMyProfile.Controls.Add(this.pictureProfile);
            this.panelMyProfile.Controls.Add(this.tabControl1);
            this.panelMyProfile.Controls.Add(this.lbFIO);
            this.panelMyProfile.Controls.Add(this.lbDataBorn);
            this.panelMyProfile.Controls.Add(this.button1);
            this.panelMyProfile.Location = new System.Drawing.Point(34, 110);
            this.panelMyProfile.Name = "panelMyProfile";
            this.panelMyProfile.Size = new System.Drawing.Size(799, 650);
            this.panelMyProfile.TabIndex = 7;
            this.panelMyProfile.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMyProfile_Paint);
            // 
            // pictureProfile
            // 
            this.pictureProfile.Location = new System.Drawing.Point(501, 93);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(262, 478);
            this.pictureProfile.TabIndex = 7;
            this.pictureProfile.TabStop = false;
            // 
            // panelDrevo
            // 
            this.panelDrevo.Controls.Add(this.label2);
            this.panelDrevo.Location = new System.Drawing.Point(34, 109);
            this.panelDrevo.Name = "panelDrevo";
            this.panelDrevo.Size = new System.Drawing.Size(799, 650);
            this.panelDrevo.TabIndex = 8;
            this.panelDrevo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "тут будет открываться форма с древом только для просмотра куда вставить добавить?" +
    "";
            // 
            // buttonMyProfile
            // 
            this.buttonMyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMyProfile.Location = new System.Drawing.Point(34, 23);
            this.buttonMyProfile.Name = "buttonMyProfile";
            this.buttonMyProfile.Size = new System.Drawing.Size(155, 37);
            this.buttonMyProfile.TabIndex = 8;
            this.buttonMyProfile.Text = "Мой профиль";
            this.buttonMyProfile.UseVisualStyleBackColor = true;
            this.buttonMyProfile.Click += new System.EventHandler(this.buttonMyProfile_Click);
            // 
            // buttonDrevo
            // 
            this.buttonDrevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDrevo.Location = new System.Drawing.Point(195, 23);
            this.buttonDrevo.Name = "buttonDrevo";
            this.buttonDrevo.Size = new System.Drawing.Size(155, 37);
            this.buttonDrevo.TabIndex = 9;
            this.buttonDrevo.Text = "Древо семьи";
            this.buttonDrevo.UseVisualStyleBackColor = true;
            this.buttonDrevo.Click += new System.EventHandler(this.buttonDrevo_Click);
            // 
            // buttonPhotoAlbum
            // 
            this.buttonPhotoAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPhotoAlbum.Location = new System.Drawing.Point(356, 23);
            this.buttonPhotoAlbum.Name = "buttonPhotoAlbum";
            this.buttonPhotoAlbum.Size = new System.Drawing.Size(155, 37);
            this.buttonPhotoAlbum.TabIndex = 10;
            this.buttonPhotoAlbum.Text = "Фотоальбом";
            this.buttonPhotoAlbum.UseVisualStyleBackColor = true;
            this.buttonPhotoAlbum.Click += new System.EventHandler(this.buttonPhotoAlbum_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(517, 23);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(155, 37);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.Location = new System.Drawing.Point(678, 23);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(155, 37);
            this.buttonSettings.TabIndex = 12;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // MyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 797);
            this.Controls.Add(this.panelMyProfile);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonPhotoAlbum);
            this.Controls.Add(this.buttonDrevo);
            this.Controls.Add(this.buttonMyProfile);
            this.Controls.Add(this.labelChk);
            this.Controls.Add(this.panelDrevo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MyProfile";
            this.Text = "MyProfile";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.panelMyProfile.ResumeLayout(false);
            this.panelMyProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            this.panelDrevo.ResumeLayout(false);
            this.panelDrevo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelChk;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbFIO;
        private System.Windows.Forms.Label lbDataBorn;
        private System.Windows.Forms.Panel panelMyProfile;
        private System.Windows.Forms.Button buttonMyProfile;
        private System.Windows.Forms.Button buttonDrevo;
        private System.Windows.Forms.Button buttonPhotoAlbum;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panelDrevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureProfile;
    }
}