using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Programming_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlDataAdapter ad = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-6OLMUBHF;Initial Catalog=Grifindo;Integrated Security=True;Connect Timeout=30;Encrypt=False;");


        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resX = MessageBox.Show("Are you sure you want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resX == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
        string UserName,Password,UserID;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserName = textUname.Text;
                Password = textPass.Text;
                string quelog = "SELECT UID from UserAccess where Uname='" + UserName + "' AND Password='" + Password + "'";
                conn.Open();
                ad = new SqlDataAdapter(quelog, conn);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    cmd = new SqlCommand(quelog, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        UserID = reader.GetValue(0).ToString();

                    }
                    Main fm = new Main();
                    fm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("User name or Password not valid", "login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    textPass.Clear();
                    textUname.Clear();
                }
                conn.Close();
            }
            catch (Exception loginERr)
            { MessageBox.Show("Error while login" + Environment.NewLine + loginERr); }

        }
    }
}
