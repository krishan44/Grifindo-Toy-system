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
using System.Drawing.Imaging;

namespace Programming_2
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        SqlDataAdapter ad = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6OLMUBHF;Initial Catalog=Grifindo;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private void Employee_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            cmbEmpID.Visible = false;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string quesave = "insert into Employee(empID,Name,DOB,ConNo,MonthlySal,OTrate,Allowance,tax) values('" + textEmpID.Text + "','" + textName.Text + "','" + dtDOB.Value.ToString() + "','" + textConNo.Text + "','" + textMonthlySal.Text + "','" + textOT.Text + "','" + textAllw.Text + "','" +textTax.Text+ "')";
                conn.Open();
                cmd = new SqlCommand(quesave, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Employee ID " + "" + textEmpID.Text + " " + "" + "Successfuly saved to the Database", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch (Exception Save_Error)
            {
                MessageBox.Show("Error While Saving" + Environment.NewLine + Save_Error);
            }
        } private void Clear()
        {
            textAllw.Clear();
            textConNo.Clear();
            textMonthlySal.Clear();
            textName.Clear();
            textOT.Clear();
            textTax.Clear();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            cmbEmpID.Visible = true;
            textEmpID.Visible = false;
            
            try
            {
                string que = "select empID from Employee";
                conn.Open();
                ad= new SqlDataAdapter(que, conn);
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
            catch (Exception SearchError)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchError);

            }
        }

        private void cmbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmpID.SelectedIndex > 0)
                {
                    string ged = cmbEmpID.SelectedItem.ToString();
                    string quedata = "SELECT * from Employee where empID='" + ged + "'";
                    conn.Open();
                    cmd = new SqlCommand(quedata, conn);
                    SqlDataReader Rd = cmd.ExecuteReader();
                    while (Rd.Read())
                    {
                        textName.Text = Rd.GetValue(1).ToString();      
                        dtDOB.Value = DateTime.Parse(Rd.GetValue(2).ToString());
                        textConNo.Text = Rd.GetValue(3).ToString();
                        textMonthlySal.Text = Rd.GetValue(4).ToString();
                        textOT.Text = Rd.GetValue(5).ToString();
                        textAllw.Text = Rd.GetValue(6).ToString();
                        textTax.Text=Rd.GetValue(7).ToString();
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resDel = MessageBox.Show("Are you Sure you to Delete Employee: " + cmbEmpID.SelectedItem.ToString() + " Record From Database????", "Confirm to Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resDel == DialogResult.Yes)
                {
                    string queDel = "Delete from Employee where empID='" + cmbEmpID.SelectedItem.ToString() + "'";
                    conn.Open();
                    cmd = new SqlCommand(queDel, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show(" Employee " + cmbEmpID.SelectedItem.ToString() + " " + "" + "Successfully Deleted From the Database!", "Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    cmbEmpID.SelectedIndex = 0;
                    textName.Focus();
                }

            }
            catch (Exception DelErr)

            {
                MessageBox.Show("Error While Deleting" + Environment.NewLine + DelErr);

            }
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
            catch (Exception SearchError)
            {
                MessageBox.Show("Error While Searching" + Environment.NewLine + SearchError);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string queUp = "Update Employee set Name='" + textName.Text + "',DOB='" + dtDOB.Value.ToString() + "',ConNo='" + textConNo.Text + "',MonthlySal='" + textMonthlySal.Text + "',OTRate='" + textOT.Text+ "',Allowance='" + textAllw.Text + "',Tax='" + textTax.Text+ "' Where empID='" + cmbEmpID.SelectedItem.ToString() + "'";
                conn.Open();
                cmd = new SqlCommand(queUp, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Employee ID" + "" + cmbEmpID.SelectedItem.ToString() + "" + "successfully Upadated to the Database....!", "Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear ();
               
                cmbEmpID.SelectedIndex = 0;
                textName.Focus();
            }
            catch (Exception UpdateError)
            {
                MessageBox.Show("Error While Updating Data" + Environment.NewLine + UpdateError);

            }
        }

        private void BtnPrv_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
