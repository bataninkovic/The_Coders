namespace WindowsFormsApplication1
{
    partial class newuserform
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
            this.btnadduser = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnewname = new System.Windows.Forms.TextBox();
            this.txtnewusername = new System.Windows.Forms.TextBox();
            this.txtnewteam = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpasscheck = new System.Windows.Forms.TextBox();
            this.txtnewemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadduser
            // 
            this.btnadduser.Location = new System.Drawing.Point(121, 506);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(75, 23);
            this.btnadduser.TabIndex = 7;
            this.btnadduser.Text = "Toevoegen";
            this.btnadduser.UseVisualStyleBackColor = true;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(260, 506);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Afbreken";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naam:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gebruikersnaam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Afdeling:";
            // 
            // txtnewname
            // 
            this.txtnewname.Location = new System.Drawing.Point(171, 156);
            this.txtnewname.Name = "txtnewname";
            this.txtnewname.Size = new System.Drawing.Size(205, 20);
            this.txtnewname.TabIndex = 1;
            // 
            // txtnewusername
            // 
            this.txtnewusername.Location = new System.Drawing.Point(171, 303);
            this.txtnewusername.Name = "txtnewusername";
            this.txtnewusername.Size = new System.Drawing.Size(205, 20);
            this.txtnewusername.TabIndex = 4;
            // 
            // txtnewteam
            // 
            this.txtnewteam.Location = new System.Drawing.Point(171, 194);
            this.txtnewteam.Name = "txtnewteam";
            this.txtnewteam.Size = new System.Drawing.Size(205, 20);
            this.txtnewteam.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.handleiding_05_gebruikersbeheer;
            this.pictureBox1.Location = new System.Drawing.Point(74, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wachtwoord:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(171, 340);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(205, 20);
            this.txtnewpassword.TabIndex = 5;
            this.txtnewpassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Wachtwoord nogmaals:";
            // 
            // txtpasscheck
            // 
            this.txtpasscheck.Location = new System.Drawing.Point(171, 380);
            this.txtpasscheck.Name = "txtpasscheck";
            this.txtpasscheck.Size = new System.Drawing.Size(205, 20);
            this.txtpasscheck.TabIndex = 6;
            this.txtpasscheck.UseSystemPasswordChar = true;
            // 
            // txtnewemail
            // 
            this.txtnewemail.Location = new System.Drawing.Point(171, 231);
            this.txtnewemail.Name = "txtnewemail";
            this.txtnewemail.Size = new System.Drawing.Size(205, 20);
            this.txtnewemail.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email-adres:";
            // 
            // newuserform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(472, 560);
            this.Controls.Add(this.txtnewemail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpasscheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnewpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtnewteam);
            this.Controls.Add(this.txtnewusername);
            this.Controls.Add(this.txtnewname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btnadduser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(920, 210);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newuserform";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Nieuwe gebruiker aanmaken";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.newuserform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnewname;
        private System.Windows.Forms.TextBox txtnewusername;
        private System.Windows.Forms.TextBox txtnewteam;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpasscheck;
        private System.Windows.Forms.TextBox txtnewemail;
        private System.Windows.Forms.Label label6;
    }
}