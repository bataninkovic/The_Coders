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
    public partial class frmchangepass : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=BATA\SQLEXPRESS;Initial Catalog=TickSys;Integrated Security=True");

        public frmchangepass()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnchangepass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(newpass1.Text))
            {
                MessageBox.Show("Vul een geldig wachtwoord in in de lege vakken.");
            }
            else if (newpass1 == newpasscheck)
            {
                string changepass = "UPDATE dbo.Users(passwd)values('" + this.newpass1.Text + "') WHERE username = '; ";
                SqlCommand sqlCom = new SqlCommand(changepass, conn);
                conn.Open();
                sqlCom.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
    

