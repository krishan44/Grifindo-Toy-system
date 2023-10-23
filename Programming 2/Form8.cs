using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Programming_2
{
    public partial class AllEemp : Form
    {
        public AllEemp()
        {
            InitializeComponent();
        }
        SqlDataAdapter ad = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6OLMUBHF;Initial Catalog=Grifindo;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                ad = new SqlDataAdapter("Select empID,GrossPay,Basic,Nopay from Salary where BeginDate<='" + Dayone.Value + "' AND EndDate='" + Daytwo.Value + "'", conn);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                grd.Visible = true;
                grd.DataSource = dt;
                conn.Close();
            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error while Searching" + Environment.NewLine + SearchErr);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report nxt= new Report();
            nxt.Show();
            this.Hide();
        }
    }
}
