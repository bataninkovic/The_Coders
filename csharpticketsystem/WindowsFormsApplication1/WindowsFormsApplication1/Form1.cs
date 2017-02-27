using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }
        
        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=BATA\SQLEXPRESS;Initial Catalog=TickSys;Integrated Security=True");
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.Users WHERE username='" + Loginuser.Text + "' AND passwd='" + Loginpass.Text + "'", con);

            DataSet ds = new DataSet();
            DataTable dt = new DataTable("dbo.Users");
            sda.Fill(dt);   
                    
            if (dt.Rows.Count > 0 && dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("U bent succesvol ingelogd. Welkom !");
                this.Hide();
                new TicketSysteem().Show();
            }
            else
                MessageBox.Show("Uw gebruikersnaam of wachtwoord is incorrect.");
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }
    }
}