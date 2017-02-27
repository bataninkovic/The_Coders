using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace WindowsFormsApplication1
{
    public partial class TicketSysteem : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=BATA\SQLEXPRESS;Initial Catalog=TickSys;Integrated Security=True");

        int count = 0;
        public TicketSysteem()
        {
            InitializeComponent();

            try
            {
              con.Open();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        public string lblcount = "0";
        private void Dashboard_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BATA\SQLEXPRESS;Initial Catalog=TickSys;Integrated Security=True");
            conn.Open();

            var items = new Dictionary<string, int>();

            SqlCommand comm = new SqlCommand("SELECT COUNT(*) as cnt,ticket_state FROM dbo.Tickets group by ticket_state", conn);
            SqlDataReader r = comm.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    int count = r.GetInt32(0);
                    string ticket = r.GetString(1);

                }
            }

            var serie = new Series();
            serie.ChartType = SeriesChartType.Bar;
            serie.Points.Add();
            chart1.Series.Add(serie);


            conn.Close();
        }
        private void GetSelectedUser()
        {
            string seluser = ("' + userlist.FocusedItem.SubItems[0].Text + '");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendNewTicket_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(NewTicketState.Text))
            //{
            //    MessageBox.Show("Selecteer een Ticketstatus.");
            //}
            //else
            //{
            //    if (string.IsNullOrEmpty(NewSubjectBox.Text))
            //    {
            //        MessageBox.Show("Het ticketonderwerp ontbreekt vul deze in a.u.b.");
            //    }
            //    else
            //    {
            //        if (string.IsNullOrEmpty(NewIssueBox.Text))
            //        {
            //            MessageBox.Show("Het issueveld is leeg vul dit in a.u.b.");
            //        }
            //        else
            //        {

            doTicket obj = new doTicket();
            obj.Issue = NewIssueBox.Text;
            obj.Subject = NewSubjectBox.Text;

            if (obj.IsValid())
            {
                //Ticketinformatie naar de database sturen
                string insertCmdText = obj.InsertStatement();// "INSERT INTO dbo.Tickets(ticket_subject, ticket_issue, ticket_state)values('" + this.NewSubjectBox.Text + "','" + this.NewIssueBox.Text + "','" + this.NewTicketState.Text + "');";
                SqlCommand sqlCom = new SqlCommand(insertCmdText, con);
                sqlCom.ExecuteNonQuery();

                MessageBox.Show("De Ticket is aangemaakt, u ontvangt zo spoedig mogelijk terugkoppeling.");
            }
            //        }
            //    }
            //}
        }
        private void DashboardTab_Click(object sender, EventArgs e)
        {

        }

        private void MainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (MainTab.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;

                case 3:
                    break;
                default:
                    MainTab.SelectedIndex = 0;
                    break;
            }
        }

        private void userlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void UserTab_Enter(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=BATA\SQLEXPRESS;Initial Catalog=TickSys;Integrated Security=True"))

                try
                {

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }
            userlist.Items.Clear();


            SqlCommand sc = new SqlCommand("SELECT * FROM dbo.Users WHERE ID != 1 ORDER BY username ASC", con);
            try
            {
                SqlDataReader sdr = sc.ExecuteReader();

                while (sdr.Read())
                {
                    //Het vullen van de list met gegevens uit de Reader
                    ListViewItem item = new ListViewItem(sdr["username"].ToString());
                    item.SubItems.Add(sdr["naam"].ToString());
                    item.SubItems.Add(sdr["afdeling"].ToString());
                    item.SubItems.Add(sdr["email"].ToString());



                    userlist.Items.Add(item);

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new newuserform().ShowDialog();
        }

        private void UserTab_Click(object sender, EventArgs e)
        {

        }

        private void btndeleteuser_Click(object sender, EventArgs e)
        {


            string selecteduser = string.Empty;

            if (userlist.SelectedItems != null)
            {

                var confirmation = MessageBox.Show(
                    "Weet u zeker dat u deze gebruiker wilt verwijderen ?",
                    "Test", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );

                if (confirmation == DialogResult.Yes)
                {
                    for (int i = 0; i < userlist.Items.Count; i++)
                    {
                        if (userlist.Items[i].Selected)
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=BATA\SQLEXPRESS;Initial Catalog=TickSys;Integrated Security=True");

                            con.Open();

                            string deluser = "DELETE FROM dbo.Users WHERE username = '" + userlist.FocusedItem.SubItems[0].Text + "';";
                            SqlCommand delrow = new SqlCommand(deluser, con);
                            delrow.ExecuteNonQuery();
                            userlist.Items[i].Remove();
                            i--;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("test", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Testbutton_Click(object sender, EventArgs e)
        {
            //Test om te bepalen hoe listview selects werkt.

            if (userlist.SelectedItems.Count > 0)
            {
                string userselect = userlist.FocusedItem.SubItems[0].Text;
            }
        }

        private void btnchangepass_Click(object sender, EventArgs e)
        {
            new frmchangepass().ShowDialog();

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            var logoutbtn = MessageBox.Show("Weet u zeker dat u wilt uitloggen ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (logoutbtn == DialogResult.Yes)
            {
                this.Hide();
                new Loginform().Show();
            }
            if (logoutbtn == DialogResult.No) ;
            {

            }

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<String> columnData = new List<String>();

            using (SqlConnection connection = new SqlConnection(@"Data Source=BATA\SQLEXPRESS;Initial Catalog=TickSys;Integrated Security=True"))
            {
                connection.Open();
                string query = "SELECT * FROM Tickets";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columnData.Add(reader.GetString(0));
                        }
                    }
                }
                connection.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> columnData = new List<String>();

            SqlConnection connection = con;
            {
                //connection.Open();
                string query = "SELECT * FROM Tickets";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        
                        while (reader.Read())
                        {
                            doTicket obj = new doTicket(reader);
                            obj.FillListViewItem(listView1.Items.Add(""));

                            String test = obj.InsertStatement();
                                
                        }
                    }
                }
               // connection.Close();
            }
        }
    }
}