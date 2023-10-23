using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Programming_2
{
    public partial class Overall : Form
    {
        public Overall()
        {
            InitializeComponent();
        }
        SqlDataAdapter ad = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6OLMUBHF;Initial Catalog=Grifindo;Integrated Security=True;Connect Timeout=30;Encrypt=False;");


        private void Overall_Load(object sender, EventArgs e)
        {
            grd.Visible = false;
            try
            {
                string que = "select empID from Employee";
                conn.Open();
                ad = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                conn.Close();
                cmbEmpID.Items.Clear();
                cmbEmpID.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbEmpID.Items.Add(dr["empID"]);
                }
                cmbEmpID.SelectedIndex = 0;
            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErr);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                ad = new SqlDataAdapter("Select * from Salary where BeginDate<='" + dtBeg.Value + "' AND EndDate='" + dtEnd.Value + "'AND empID='" + cmbEmpID.SelectedItem.ToString() + "'", conn);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                grd.Visible = true;
                cmbEmpID.Visible = false;
                dtBeg.Visible = false;
                dtEnd.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                btnCheck.Visible = false;
                grd.DataSource = dt;
                conn.Close();
            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error while Searching" + Environment.NewLine + SearchErr);

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Report nxt= new Report();
            nxt.Show();
            this.Hide();
        }
    }
}
