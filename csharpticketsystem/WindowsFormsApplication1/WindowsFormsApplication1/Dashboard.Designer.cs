namespace WindowsFormsApplication1
{
    partial class TicketSysteem
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel7 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel8 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btn_logout = new System.Windows.Forms.Button();
            this.MainTab = new System.Windows.Forms.TabControl();
            this.DashboardTab = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TicketTab = new System.Windows.Forms.TabPage();
            this.NewTickTab = new System.Windows.Forms.TabPage();
            this.NewTicketStateLabel = new System.Windows.Forms.Label();
            this.NewIssueLabel = new System.Windows.Forms.Label();
            this.NewSubjectLabel = new System.Windows.Forms.Label();
            this.NewTicketState = new System.Windows.Forms.ComboBox();
            this.NewSubjectBox = new System.Windows.Forms.TextBox();
            this.NewIssueBox = new System.Windows.Forms.TextBox();
            this.SendNewTicket = new System.Windows.Forms.Button();
            this.UserTab = new System.Windows.Forms.TabPage();
            this.btnchangepass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Testbutton = new System.Windows.Forms.Button();
            this.btndeleteuser = new System.Windows.Forms.Button();
            this.btnnewuser = new System.Windows.Forms.Button();
            this.userlist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainTab.SuspendLayout();
            this.DashboardTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.NewTickTab.SuspendLayout();
            this.UserTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(1072, 5);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.Text = "Uitloggen";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.DashboardTab);
            this.MainTab.Controls.Add(this.TicketTab);
            this.MainTab.Controls.Add(this.NewTickTab);
            this.MainTab.Controls.Add(this.UserTab);
            this.MainTab.Location = new System.Drawing.Point(6, 12);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1140, 812);
            this.MainTab.TabIndex = 2;
            this.MainTab.SelectedIndexChanged += new System.EventHandler(this.MainTab_SelectedIndexChanged);
            // 
            // DashboardTab
            // 
            this.DashboardTab.Controls.Add(this.button1);
            this.DashboardTab.Controls.Add(this.listView1);
            this.DashboardTab.Controls.Add(this.chart2);
            this.DashboardTab.Controls.Add(this.chart1);
            this.DashboardTab.Location = new System.Drawing.Point(4, 22);
            this.DashboardTab.Name = "DashboardTab";
            this.DashboardTab.Padding = new System.Windows.Forms.Padding(3);
            this.DashboardTab.Size = new System.Drawing.Size(1132, 786);
            this.DashboardTab.TabIndex = 0;
            this.DashboardTab.Text = "Dashboard";
            this.DashboardTab.UseVisualStyleBackColor = true;
            this.DashboardTab.Click += new System.EventHandler(this.DashboardTab_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(29, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(378, 166);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // chart2
            // 
            chartArea7.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart2.Legends.Add(legend7);
            this.chart2.Location = new System.Drawing.Point(595, 34);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(436, 367);
            this.chart2.TabIndex = 1;
            this.chart2.Text = " ";
            // 
            // chart1
            // 
            customLabel7.Text = "Januari";
            chartArea8.AxisX.CustomLabels.Add(customLabel7);
            chartArea8.AxisX.IsLabelAutoFit = false;
            chartArea8.AxisX.LabelStyle.Angle = 90;
            chartArea8.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea8.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea8.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea8.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea8.AxisY.Title = "Aantal Tickets";
            customLabel8.FromPosition = 1D;
            customLabel8.RowIndex = 1;
            customLabel8.Text = "Januari";
            chartArea8.AxisY2.CustomLabels.Add(customLabel8);
            chartArea8.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            chartArea8.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            legend8.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(435, 445);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(633, 294);
            this.chart1.TabIndex = 0;
            title4.Name = "Title1";
            title4.Text = "Overzicht Actuele Tickets";
            this.chart1.Titles.Add(title4);
            // 
            // TicketTab
            // 
            this.TicketTab.Location = new System.Drawing.Point(4, 22);
            this.TicketTab.Name = "TicketTab";
            this.TicketTab.Padding = new System.Windows.Forms.Padding(3);
            this.TicketTab.Size = new System.Drawing.Size(1132, 786);
            this.TicketTab.TabIndex = 1;
            this.TicketTab.Text = "Ticket Overzicht";
            this.TicketTab.UseVisualStyleBackColor = true;
            // 
            // NewTickTab
            // 
            this.NewTickTab.Controls.Add(this.NewTicketStateLabel);
            this.NewTickTab.Controls.Add(this.NewIssueLabel);
            this.NewTickTab.Controls.Add(this.NewSubjectLabel);
            this.NewTickTab.Controls.Add(this.NewTicketState);
            this.NewTickTab.Controls.Add(this.NewSubjectBox);
            this.NewTickTab.Controls.Add(this.NewIssueBox);
            this.NewTickTab.Controls.Add(this.SendNewTicket);
            this.NewTickTab.Location = new System.Drawing.Point(4, 22);
            this.NewTickTab.Name = "NewTickTab";
            this.NewTickTab.Padding = new System.Windows.Forms.Padding(3);
            this.NewTickTab.Size = new System.Drawing.Size(1132, 786);
            this.NewTickTab.TabIndex = 2;
            this.NewTickTab.Text = "Nieuwe Ticket Aanmaken";
            this.NewTickTab.UseVisualStyleBackColor = true;
            // 
            // NewTicketStateLabel
            // 
            this.NewTicketStateLabel.AutoSize = true;
            this.NewTicketStateLabel.Location = new System.Drawing.Point(51, 324);
            this.NewTicketStateLabel.Name = "NewTicketStateLabel";
            this.NewTicketStateLabel.Size = new System.Drawing.Size(73, 13);
            this.NewTicketStateLabel.TabIndex = 6;
            this.NewTicketStateLabel.Text = "Ticket Status:";
            // 
            // NewIssueLabel
            // 
            this.NewIssueLabel.AutoSize = true;
            this.NewIssueLabel.Location = new System.Drawing.Point(394, 292);
            this.NewIssueLabel.Name = "NewIssueLabel";
            this.NewIssueLabel.Size = new System.Drawing.Size(35, 13);
            this.NewIssueLabel.TabIndex = 5;
            this.NewIssueLabel.Text = "Issue:";
            // 
            // NewSubjectLabel
            // 
            this.NewSubjectLabel.AutoSize = true;
            this.NewSubjectLabel.Location = new System.Drawing.Point(368, 257);
            this.NewSubjectLabel.Name = "NewSubjectLabel";
            this.NewSubjectLabel.Size = new System.Drawing.Size(62, 13);
            this.NewSubjectLabel.TabIndex = 4;
            this.NewSubjectLabel.Text = "Onderwerp:";
            this.NewSubjectLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewTicketState
            // 
            this.NewTicketState.FormattingEnabled = true;
            this.NewTicketState.Items.AddRange(new object[] {
            "Open / Onbehandeld",
            "Gesloten / Beantwoord",
            "In Afwachting"});
            this.NewTicketState.Location = new System.Drawing.Point(124, 322);
            this.NewTicketState.Name = "NewTicketState";
            this.NewTicketState.Size = new System.Drawing.Size(173, 21);
            this.NewTicketState.TabIndex = 3;
            // 
            // NewSubjectBox
            // 
            this.NewSubjectBox.Location = new System.Drawing.Point(433, 254);
            this.NewSubjectBox.Name = "NewSubjectBox";
            this.NewSubjectBox.Size = new System.Drawing.Size(612, 20);
            this.NewSubjectBox.TabIndex = 1;
            this.NewSubjectBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // NewIssueBox
            // 
            this.NewIssueBox.Location = new System.Drawing.Point(434, 291);
            this.NewIssueBox.Multiline = true;
            this.NewIssueBox.Name = "NewIssueBox";
            this.NewIssueBox.Size = new System.Drawing.Size(610, 244);
            this.NewIssueBox.TabIndex = 2;
            // 
            // SendNewTicket
            // 
            this.SendNewTicket.Location = new System.Drawing.Point(968, 559);
            this.SendNewTicket.Name = "SendNewTicket";
            this.SendNewTicket.Size = new System.Drawing.Size(75, 23);
            this.SendNewTicket.TabIndex = 4;
            this.SendNewTicket.Text = "Indienen";
            this.SendNewTicket.UseVisualStyleBackColor = true;
            this.SendNewTicket.Click += new System.EventHandler(this.SendNewTicket_Click);
            // 
            // UserTab
            // 
            this.UserTab.Controls.Add(this.btnchangepass);
            this.UserTab.Controls.Add(this.label1);
            this.UserTab.Controls.Add(this.Testbutton);
            this.UserTab.Controls.Add(this.btndeleteuser);
            this.UserTab.Controls.Add(this.btnnewuser);
            this.UserTab.Controls.Add(this.userlist);
            this.UserTab.Location = new System.Drawing.Point(4, 22);
            this.UserTab.Name = "UserTab";
            this.UserTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserTab.Size = new System.Drawing.Size(1132, 786);
            this.UserTab.TabIndex = 3;
            this.UserTab.Text = "Gebruikersbeheer";
            this.UserTab.UseVisualStyleBackColor = true;
            this.UserTab.Click += new System.EventHandler(this.UserTab_Click);
            this.UserTab.Enter += new System.EventHandler(this.UserTab_Enter);
            // 
            // btnchangepass
            // 
            this.btnchangepass.Location = new System.Drawing.Point(567, 135);
            this.btnchangepass.Margin = new System.Windows.Forms.Padding(2);
            this.btnchangepass.Name = "btnchangepass";
            this.btnchangepass.Size = new System.Drawing.Size(113, 36);
            this.btnchangepass.TabIndex = 7;
            this.btnchangepass.Text = "Wachtwoord aanpassen";
            this.btnchangepass.UseVisualStyleBackColor = true;
            this.btnchangepass.Click += new System.EventHandler(this.btnchangepass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Geselecteerde gebruiker:";
            // 
            // Testbutton
            // 
            this.Testbutton.Location = new System.Drawing.Point(418, 391);
            this.Testbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Testbutton.Name = "Testbutton";
            this.Testbutton.Size = new System.Drawing.Size(113, 36);
            this.Testbutton.TabIndex = 5;
            this.Testbutton.Text = "Geen";
            this.Testbutton.UseVisualStyleBackColor = true;
            this.Testbutton.Click += new System.EventHandler(this.Testbutton_Click);
            // 
            // btndeleteuser
            // 
            this.btndeleteuser.Location = new System.Drawing.Point(567, 76);
            this.btndeleteuser.Margin = new System.Windows.Forms.Padding(2);
            this.btndeleteuser.Name = "btndeleteuser";
            this.btndeleteuser.Size = new System.Drawing.Size(113, 36);
            this.btndeleteuser.TabIndex = 4;
            this.btndeleteuser.Text = "Verwijderen";
            this.btndeleteuser.UseVisualStyleBackColor = true;
            this.btndeleteuser.Click += new System.EventHandler(this.btndeleteuser_Click);
            // 
            // btnnewuser
            // 
            this.btnnewuser.Location = new System.Drawing.Point(567, 18);
            this.btnnewuser.Margin = new System.Windows.Forms.Padding(2);
            this.btnnewuser.Name = "btnnewuser";
            this.btnnewuser.Size = new System.Drawing.Size(113, 36);
            this.btnnewuser.TabIndex = 3;
            this.btnnewuser.Text = "Nieuwe Gebruiker";
            this.btnnewuser.UseVisualStyleBackColor = true;
            this.btnnewuser.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // userlist
            // 
            this.userlist.AutoArrange = false;
            this.userlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.userlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.userlist.GridLines = true;
            this.userlist.Location = new System.Drawing.Point(16, 14);
            this.userlist.MultiSelect = false;
            this.userlist.Name = "userlist";
            this.userlist.Scrollable = false;
            this.userlist.Size = new System.Drawing.Size(515, 363);
            this.userlist.TabIndex = 2;
            this.userlist.UseCompatibleStateImageBehavior = false;
            this.userlist.View = System.Windows.Forms.View.Details;
            this.userlist.SelectedIndexChanged += new System.EventHandler(this.userlist_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gebruikersnaam";
            this.columnHeader1.Width = 112;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Naam";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Afdeling";
            this.columnHeader3.Width = 111;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E-mail adres";
            this.columnHeader4.Width = 195;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TicketSysteem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 857);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.MainTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicketSysteem";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TickSys";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.MainTab.ResumeLayout(false);
            this.DashboardTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.NewTickTab.ResumeLayout(false);
            this.NewTickTab.PerformLayout();
            this.UserTab.ResumeLayout(false);
            this.UserTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage DashboardTab;
        private System.Windows.Forms.TabPage TicketTab;
        private System.Windows.Forms.TabPage NewTickTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TabPage UserTab;
        private System.Windows.Forms.Button SendNewTicket;
        private System.Windows.Forms.TextBox NewSubjectBox;
        private System.Windows.Forms.TextBox NewIssueBox;
        private System.Windows.Forms.Label NewSubjectLabel;
        private System.Windows.Forms.Label NewIssueLabel;
        private System.Windows.Forms.Label NewTicketStateLabel;
        private System.Windows.Forms.ComboBox NewTicketState;
        private System.Windows.Forms.ListView userlist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnnewuser;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btndeleteuser;
        private System.Windows.Forms.Button Testbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnchangepass;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}