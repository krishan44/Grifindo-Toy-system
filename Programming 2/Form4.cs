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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace Programming_2
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        SqlDataAdapter ad = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6OLMUBHF;Initial Catalog=Grifindo;Integrated Security=True;Connect Timeout=30;Encrypt=False;");


        private void User_Load(object sender, EventArgs e)
        {
            BtnDelete.Visible = false;
            BtnUpdate.Visible = false;
            cmbUID.Visible = false;
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
            BtnDelete.Visible=true;
            BtnUpdate.Visible=true;
            cmbUID.Visible  =true;
            textUID.Visible=false;
            BtnSave.Visible=false;
            try
            {
                string que = "select UID from UserAccess";
                conn.Open();
                ad = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                conn.Close();

                cmbUID.Items.Clear();
                cmbUID.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbUID.Items.Add(dr["UID"]);
                }
                cmbUID.SelectedIndex = 0;

            }
            catch (Exception SearchError)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchError);

            }
        }

        private void cmbUID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbUID.SelectedIndex > 0)
                {
                    string ged = cmbUID.SelectedItem.ToString();
                    string quedata = "SELECT * from UserAccess where UID='" + ged + "'";
                    conn.Open();
                    cmd = new SqlCommand(quedata, conn);
                    SqlDataReader Rd = cmd.ExecuteReader();
                    while (Rd.Read())
                    {
                       textUname.Text=Rd.GetValue(1).ToString();
                       textPass.Text=Rd.GetValue(2).ToString();
                       cmbEmpID.SelectedItem=Rd.GetValue(3).ToString();
                    }

                    conn.Close();
                }
                else
                {
                    Clear();
                }
            }
            catch (Exception SearchErr)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchErr);
            }
        } private void Clear()
        {
            textUID.Clear();
            textPass.Clear();
            textUname.Clear();
            cmbEmpID.SelectedItem = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string quesave = "insert into UserAccess(UID,Uname,Password,empID) values('" + textUID.Text + "','" + textUname.Text + "','" + textPass.Text + "','" + cmbEmpID.SelectedItem.ToString() + "')";
                conn.Open();
                cmd = new SqlCommand(quesave, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("User ID " + "" + textUID.Text + " " + "" + "Successfuly saved to the Database", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch (Exception Save_Error)
            {
                MessageBox.Show("Error While Saving" + Environment.NewLine + Save_Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string queUp = "Update UserAccess set Uname='" + textUname.Text + "',Password='" + textPass.Text + "',empID='" + cmbEmpID.SelectedItem.ToString() + "' Where UID='" + cmbUID.SelectedItem.ToString() + "'";
                conn.Open();
                cmd = new SqlCommand(queUp, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Employee ID" + "" + cmbEmpID.SelectedItem.ToString() + "" + "successfully Upadated to the Database....!", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                cmbUID.SelectedIndex = 0;
                cmbEmpID.SelectedIndex = 0;
                textUname.Focus();
            }
            catch (Exception UpdateError)
            {
                MessageBox.Show("Error While Updating Data" + Environment.NewLine + UpdateError);

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resDel = MessageBox.Show("Are you Sure you to Delete User: " + cmbUID.SelectedItem.ToString() + " Record From Database????", "Confirm to Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {
                    string queDel = "Delete from UserAccess where UID='" + cmbUID.SelectedItem.ToString() + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show(" User " + cmbUID.SelectedItem.ToString() + " " + "" + "Successfully Deleted From the Database!", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    cmbEmpID.SelectedIndex = 0;
                    textUname.Focus();
                }

            }
            catch (Exception DelErr)

            {
                MessageBox.Show("Error While Deleting" + Environment.NewLine + DelErr);

            }
            try
            {
                string que = "select UID from UserAccess";
                conn.Open();
                ad = new SqlDataAdapter(que, conn);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                conn.Close();

                cmbUID.Items.Clear();
                cmbUID.Items.Add("---SELECT---");
                foreach (DataRow dr in dt.Rows)
                {
                    cmbUID.Items.Add(dr["UID"]);
                }
                cmbUID.SelectedIndex = 0;

            }
            catch (Exception SearchError)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchError);

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
