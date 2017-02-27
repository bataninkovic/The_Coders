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
    public partial class newuserform : Form
    { 
        public newuserform()
        {
            InitializeComponent();
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnewname.Text))
            {
                MessageBox.Show("De naam ontbreekt, Vul een naam in a.u.b.");
            } 
            else
                if (string.IsNullOrEmpty(txtnewemail.Text))
            {
                MessageBox.Show("Het e-mail adres ontbreekt, Vul deze in a.u.b. ");
            }
            else
                if (string.IsNullOrEmpty(txtnewusername.Text))
            {
                MessageBox.Show("De gebruikersnaam ontbreekt, Vul deze in a.u.b.");
            }
            else
                if (string.IsNullOrEmpty(txtnewpassword.Text))
            {
                MessageBox.Show("Het wachtwoord ontbreekt, Vul deze in a.u.b.");
            }
            else
                if (txtpasscheck.Text != txtnewpassword.Text)
            {
                MessageBox.Show("De wachtwoorden komen niet overeen controlleer deze a.u.b.");
            }
            else
            {

                SqlConnection con = new SqlConnection(@"Data Source=BATA\SQLEXPRESS;Initial Catalog=TickSys;Integrated Security=True");
                {
                    con.Open();

                    //Sending all the userdata to the database
                    string newuser = "INSERT INTO dbo.Users(naam, afdeling, email, username, passwd)values('" + this.txtnewname.Text + "','" + this.txtnewteam.Text + "','" + this.txtnewemail.Text + "','" + this.txtnewusername.Text + "','" + this.txtnewpassword.Text + "');";
                    SqlCommand SqlCom = new SqlCommand(newuser, con);
                    SqlCom.ExecuteNonQuery();

                    MessageBox.Show("Gebruiker is succesvol aangemaakt.");

                    this.Hide();
                    con.Close();
                } 
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void newuserform_Load(object sender, EventArgs e)
        {

        }
    }
}
