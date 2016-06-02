using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessSimulation
{
    public partial class xiaoxiduilie : Form
    {
        public xiaoxiduilie()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fasongxinxi2 = richTextBox2.Text;
            richTextBox1.Text = fasongxinxi2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            this.richTextBox2.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            jinchengtongxinxuanze jinchengtongxinxuanze = new jinchengtongxinxuanze();
            this.Hide();
            jinchengtongxinxuanze.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fasongxinxi1 = richTextBox1.Text;
            richTextBox2.Text = fasongxinxi1;

        }

        
    }
}
