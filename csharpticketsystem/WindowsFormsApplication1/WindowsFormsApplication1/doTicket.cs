using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class doTicket
    {
        private int d_ID = -1;
        private String d_subject = "";
        private String d_issue = "";
        private String d_solution = "";
        private DateTime d_creationDate = DateTime.Now;
        private String d_user = "";
        private String d_state = "";

        public int ID
        {
            get { return d_ID; }
            set { d_ID = value; }
        }

        public string Subject
        {
            get { return d_subject; }
            set { d_subject = value; }
        }

        public string Issue
        {
            get
            {
                return d_issue;
            }

            set
            {
                d_issue = value;
            }
        }

        public string Solution
        {
            get
            {
                return d_solution;
            }

            set
            {
                d_solution = value;
            }
        }

        public DateTime CreationDate
        {
            get
            {
                return d_creationDate;
            }

            set
            {
                d_creationDate = value;
            }
        }

        public string User
        {
            get
            {
                return d_user;
            }

            set
            {
                d_user = value;
            }
        }

        public string State
        {
            get
            {
                return d_state;
            }

            set
            {
                d_state = value;
            }
        }

        public doTicket()
        {
            //
        }

        public doTicket(SqlDataReader reader)
        {
            d_ID = reader.GetInt32(0);
            d_subject = reader.GetString(1);
            d_issue = reader.GetString(2);
            if (!reader.IsDBNull(3))
                d_solution = reader.GetString(3);

            if (!reader.IsDBNull(4))
                d_creationDate = reader.GetDateTime(4);

            if (!reader.IsDBNull(5))
                d_user = reader.GetString(5);
            d_state = reader.GetString(6);
        }

        public bool IsValid()
        {

            return (!(string.IsNullOrEmpty(d_state)
                || string.IsNullOrEmpty(d_subject) ||
                string.IsNullOrEmpty(d_issue)));
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
            return true;
        }

        public void FillListViewItem(ListViewItem item)
        {
            item.Text = Convert.ToString(d_ID);
            item.SubItems.Add(d_subject);
            item.SubItems.Add(d_issue);
            item.SubItems.Add(d_solution);
            item.SubItems.Add(Convert.ToString(d_creationDate));
        }

        public String InsertStatement()
        {
            return "INSERT INTO TICKETS(ticket_subject, ticket_issue, ticket_state) VALUES('" + d_subject + "','" + d_issue + "','" + d_solution + "','" + d_creationDate.ToString("yyyy-MM-dd hh:mm:ss") + "' ,'" + d_user + "','" + d_state + "')";
        }
    }
}