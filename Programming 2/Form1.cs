using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace Programming_2
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        SqlDataAdapter ad = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6OLMUBHF;Initial Catalog=Grifindo;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        private void Salary_Load(object sender, EventArgs e)
        {
            grpSal.Visible = false;
            GrpDetails.Visible = false;
            grpButtons.Visible = false;
            textAbsents.Text="0";
            textAllownces.Text = "0";
            textBasic.Text = "0";
            textFxLeaves.Text = "0";
            textGross.Text = "0";
            textFxLeaves.Text = "0";
            textHolidays.Text = "0";
            textLeaves.Text = "0"   ;
            textMnthly.Text = "0";
            textOTpay.Text = "0";
            textOTRate.Text = "0"       ;
            textSalID.Clear();

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
        DateTime Cyclebdate, CycleEdate, Bdate, Edate, Cdt;
        double TaxRate, OTrate;

        private void textAbsents_MouseClick(object sender, MouseEventArgs e)
        {
            textAbsents.Clear();
        }

        private void textHolidays_MouseClick(object sender, MouseEventArgs e)
        {
            textHolidays.Clear();
        }

        private void textOtHrs_MouseClick(object sender, MouseEventArgs e)
        {
            textOtHrs.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string quesave = "insert into salary (SalaryID,BeginDate,EndDate,Leaves,OTpay,Holidays,Absents,Month,Basic,NoPay,GrossPay,empID) values('" + textSalID.Text + "','" + dtBegin.Value.ToString() + "','" + dtEnd.Value.ToString() + "','" +textLeaves.Text + "','" + textOTpay.Text + "','" + textHolidays.Text + "','" + textAbsents.Text + "','" + cmbMonth.SelectedItem.ToString() + "','" + textBasic.Text + "','" + textNopay.Text + "','" + textGross.Text + "','" + cmbEmpID.SelectedItem.ToString() + "')";
                conn.Open();
                cmd = new SqlCommand(quesave, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Salary ID " + " " + textSalID.Text + " " + "Successfuly saved to the Database", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                dtEnd.Value = DateTime.Now;
                dtBegin.Value = DateTime.Now;
                cmbEmpID.SelectedIndex = 0;
                cmbMonth.SelectedIndex = 0;
                textOtHrs.Text = "0";

            }
            catch (Exception Save_Error)
            {

                MessageBox.Show("Error While Saving" + Environment.NewLine + Save_Error);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Gross, LeavesTook, Absent, Holidays, LeavesFixed, NopayDays, basePay,dy;
            LeavesTook = double.Parse(textLeaves.Text);
            Absent = double.Parse(textAbsents.Text);
            Holidays = double.Parse(textHolidays.Text);
            LeavesFixed = double.Parse(textFxLeaves.Text);

            dy = Absent - (LeavesTook + Holidays); 
            if (dy == 0)
            {
                NopayDays = 0;
            }
            else NopayDays = dy;

            double OT,Nopays;


            OT = double.Parse(textOtHrs.Text) * OTrate;
            textOTpay.Text = OT.ToString();
            Nopays = (double.Parse(textMnthly.Text) / dateRange) * NopayDays;
            basePay = double.Parse(textMnthly.Text) + double.Parse(textAllownces.Text) + double.Parse(textOTpay.Text);
            Gross = basePay - Nopays - (basePay * TaxRate / 100);
            textNopay.Text = Nopays.ToString("##########.##");
            textGross.Text = Gross.ToString("##########.##");
            textBasic.Text = basePay.ToString("#######.##");
            
            MessageBox.Show("Salary Calculated with the available Details.......!!!", "Salary", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main nxt=new Main();
            nxt.Show();
            this.Hide();
        }

        private void textLeaves_MouseClick(object sender, MouseEventArgs e)
        {
            textLeaves.Clear();
        }

        private void cmbEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            textAllownces.Enabled = false;
            textMnthly.Enabled = false;
            textFxLeaves.Enabled = false;
            try
            {//taking data for calculatios
                if (cmbEmpID.SelectedIndex > 0)
                {
                    string ged = cmbEmpID.SelectedItem.ToString();
                    string quedata = "SELECT * from Employee where empID='" + ged + "'";
                    conn.Open();
                    cmd = new SqlCommand(quedata, conn);
                    SqlDataReader Rd = cmd.ExecuteReader();
                    while (Rd.Read())
                    {
                       
                        textMnthly.Text = Rd.GetValue(4).ToString();
                        OTrate = double.Parse(Rd.GetValue(5).ToString());
                        TaxRate = double.Parse(Rd.GetValue(7).ToString());
                        textAllownces.Text = Rd.GetValue(6).ToString();
                        textOTRate.Text=(Rd.GetValue(5).ToString());
                        textOTRate.Enabled = false;
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
                MessageBox.Show("Error While Searching " + Environment.NewLine + SearchErr);
            }

            try
            {
                if (cmbEmpID.SelectedIndex > 0)
                {
                    string ged = cmbEmpID.SelectedItem.ToString();
                    string quedata = "SELECT * from setting where empID='" + ged + "'";
                    conn.Open();
                    cmd = new SqlCommand(quedata, conn);
                    SqlDataReader Rd = cmd.ExecuteReader();
                    while (Rd.Read())
                    {
                        textFxLeaves.Text = Rd.GetValue(4).ToString();
                        

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
                MessageBox.Show("Error While Searching Allowance and Monthly Salary" + Environment.NewLine + SearchErr);
            }
            
        }
        private void Clear()
        {
            textAbsents.Clear();
            textAllownces.Clear();
            textBasic.Clear();
            textFxLeaves.Clear();
            textGross.Clear ();
            textFxLeaves.Clear();
            textHolidays.Clear();
            textLeaves.Clear();
            textMnthly.Clear();
            textOTpay.Clear();  
            textOTRate.Clear();
            textSalID.Clear();
        }
        double dateRange;
        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            { 
                if (cmbEmpID.SelectedIndex > 0)
                {
                    string ged = cmbEmpID.SelectedItem.ToString();
                    string quedata = "SELECT * from setting where empID='" + ged + "'";
                    conn.Open();
                    cmd = new SqlCommand(quedata, conn);
                    SqlDataReader Rd = cmd.ExecuteReader();
                    while (Rd.Read())
                    {
                        Cyclebdate = DateTime.Parse(Rd.GetValue(1).ToString());
                        CycleEdate = DateTime.Parse(Rd.GetValue(2).ToString());
                        dateRange = double.Parse(Rd.GetValue(3).ToString());
                    }
                    conn.Close();
                }
                Bdate = DateTime.Parse(dtBegin.Value.ToString());
                Edate = DateTime.Parse(dtEnd.Value.ToString());
                if (Cyclebdate < Bdate && CycleEdate > Edate)
                {
                    cmbMonth.SelectedIndex = 0;
                    textBasic.Text = "0";
                    textGross.Text = "0";
                    textAbsents.Text = "0";
                    textHolidays.Text = "0";
                    textLeaves.Text = "0";
                    textOTpay.Text = "0";
                    textOtHrs.Text = "0";
                    textNopay.Text = "0";
                    textBasic.Enabled = false;
                    textGross.Enabled = false;
                    textNopay.Enabled = false;
                    textOTpay.Enabled = false;
                    grpButtons.Visible = true;
                    grpSal.Visible = true;
                    GrpDetails.Visible = true;
                    MessageBox.Show("Date is in the Range......!!!", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    grpButtons.Visible = false;
                    grpSal.Visible = false;
                    GrpDetails.Visible = false;
                    MessageBox.Show(" Date is not in the Range...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception LoadErr)
            {
                MessageBox.Show("Errpr While Date Trasfering" + Environment.NewLine + LoadErr);
            }
        }
    }
}
