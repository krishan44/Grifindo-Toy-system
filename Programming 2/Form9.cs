using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Programming_2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setting nxt = new setting();    
            nxt.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Salary nxt = new Salary();
            nxt.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Report nxt = new Report();  
            nxt.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            User user = new User(); 
            user.Show();    
            this.Hide();    
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult resXX = MessageBox.Show("Are you sure you want to logout...!!", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resXX == DialogResult.Yes)
            {
                Login nxt= new Login();
                nxt.Show();
                this.Hide();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
