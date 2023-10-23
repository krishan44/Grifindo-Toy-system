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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btnOver_Click(object sender, EventArgs e)
        {
            Overall nxt = new Overall();
            nxt.Show();
            this.Hide();
        }

        private void btnRange_Click(object sender, EventArgs e)
        {
            Monthly nxt = new Monthly();    
            nxt.Show();
            this.Hide();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            AllEemp nxt= new AllEemp();
            nxt.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
