using Second.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Checkproductkey();
        }

        private void Checkproductkey()
        {
            productlicence obj = Getproductkey();

            if (obj.ProductKey == string.Empty)
            {
                int totaldaysleft = 0;
                if(obj.TED == new DateTime(1900,1,1))
                {

                    updateTrial();//3sra method
                    totaldaysleft = findtotaltrialdaysleft(DateTime.Now.Date.AddMonths(1), DateTime.Now.Date);

                }
                else
                {
                    totaldaysleft = findtotaltrialdaysleft(obj.TED, DateTime.Now.Date);

                }
                showlicenceform(totaldaysleft);//5 method
            }
        }

        private void showlicenceform(int totaldaysleft)
        {
            Form1 lf = new Form1();
            lf.Totaldaysleft = totaldaysleft;
            lf.ShowDialog();
        }

        private int findtotaltrialdaysleft(DateTime dateTime, DateTime currentdate)
        {
            return Convert.ToInt16((dateTime- currentdate).TotalDays);
        }

        private void updateTrial()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("update ProductKey set [TED]=@TED", conn))
                {
                    cmd.Parameters.AddWithValue("@TED", DateTime.Now.Date.AddMonths(1)); 
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }



        private productlicence Getproductkey()
        {
            productlicence p = new productlicence();
            string connectionstring = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("select * from ProductKey", conn)) 
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    reader.Read();

                    p.Name = reader["Name"].ToString();
                    p.ProductKey = reader["ProductKey"].ToString();
                    p.TED =Convert.ToDateTime( reader["TED"] );

                }

            }

                return p;
        }
    }
}
