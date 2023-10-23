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
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace Programming_2
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }
        SqlDataAdapter ad = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6OLMUBHF;Initial Catalog=Grifindo;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private void setting_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            cmbSettingID.Visible = false;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            textSettingID.Visible=false;
            cmbSettingID.Visible = true;
            btnDelete.Visible = true;
            btnUpdate.Visible =true;
            btnSave.Visible = false;
            try
            {
                string que = "select setID from setting";
                conn.Open();
                ad = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                conn.Close();

                cmbSettingID.Items.Clear();
                cmbSettingID.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbSettingID.Items.Add(dr["setID"]);
                }
                cmbSettingID.SelectedIndex = 0;

            }
            catch (Exception SearchErrorrr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErrorrr);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            { 
                string quesave = "insert into setting (setID,SalaryBDate,SalaryEdate,DateRange,Leaves,empID) values('" + textSettingID.Text + "','" + dtCBegin.Value.ToString() + "','" + dtCend.Value.ToString() + "','" + textDrange.Text + "','" +textLeaves.Text + "','" + cmbEmpID.SelectedItem.ToString() + "')";
                conn.Open();
                cmd = new SqlCommand(quesave, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Setting ID " + " " + textSettingID.Text + " " + "Successfuly saved to the Database", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                cmbEmpID.SelectedIndex = 0;

            }
            catch (Exception Save_Error)
            {

                MessageBox.Show("Error While Saving" + Environment.NewLine + Save_Error);
            }
        }private void Clear()
        {
            textLeaves.Clear();
            textDrange.Clear();
            textSettingID.Clear();
            cmbEmpID.SelectedIndex = 0;
            dtCBegin.Value=DateTime.Now;
            dtCend.Value=DateTime.Now;
        }

        private void cmbSettingID_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cmbSettingID.SelectedIndex > 0)
                {
                    string ged = cmbSettingID.SelectedItem.ToString();
                    string quedata = "SELECT * from setting where setID='" + ged + "'";
                    conn.Open();
                    cmd = new SqlCommand(quedata, conn);
                    SqlDataReader Rd = cmd.ExecuteReader();
                    while (Rd.Read())
                    {
                        dtCBegin.Value = DateTime.Parse(Rd.GetValue(1).ToString());
                        dtCend.Value = DateTime.Parse(Rd.GetValue(2).ToString());
                        textDrange.Text = Rd.GetValue(3).ToString();
                        textLeaves.Text = Rd.GetValue(4).ToString();
                        cmbEmpID.SelectedItem = Rd.GetValue(5).ToString();
                    }
                    conn.Close();
                }
                else
                {
                    Clear();
                }

            }
            catch (Exception SearchError)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchError);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            { 
                string queUp = "Update setting set SalaryBDate='" + dtCBegin.Value.ToString() + "',SalaryEdate='" + dtCend.Value.ToString() + "',DateRange='"+textDrange.Text+"',Leaves='" + textLeaves.Text + "',empID='" + cmbEmpID.SelectedItem.ToString() + "' Where setID='" + cmbSettingID.SelectedItem.ToString() + "'";
                conn.Open();
                cmd = new SqlCommand(queUp, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Setting ID" + " " + cmbSettingID.SelectedItem.ToString() + "  " + "successfully Upadated to the Database....!", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

                cmbEmpID.SelectedIndex = 0;
                cmbSettingID.SelectedIndex = 0;
            }
            catch (Exception UpdateErr)
            {
                MessageBox.Show("Error Updating Data" + Environment.NewLine + UpdateErr);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            { 
                DialogResult resDel = MessageBox.Show("Are you Sure to Delete setting ID : " + cmbSettingID.SelectedItem.ToString() + " Record From Database????", "Confirm to Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {
                    string queDel = "Delete from setting where setID='" + cmbSettingID.SelectedItem.ToString() + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show(" Setting ID " + cmbSettingID.SelectedItem.ToString() + " " + "Successfully Deleted From the Database!", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    cmbEmpID.SelectedIndex = 0;
                    cmbSettingID.Focus();
                }
            }
            catch (Exception DelError)
            {
                MessageBox.Show("Error While Deleting" + Environment.NewLine + DelError);

            }
            try
            {
                string que = "select setID from setting";
                conn.Open();
                ad = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                conn.Close();

                cmbSettingID.Items.Clear();
                cmbSettingID.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbSettingID.Items.Add(dr["setID"]);
                }
                cmbSettingID.SelectedIndex = 0;

            }
            catch (Exception SearchErrorrr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErrorrr);

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
