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
    public partial class jinchengtongxinxuanze : Form
    {
        public jinchengtongxinxuanze()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guandaotongxin guandaotongxin = new guandaotongxin();
            this.Hide();
            guandaotongxin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xiaoxiduilie xiaoxiduilie = new xiaoxiduilie();
            this.Hide();
            xiaoxiduilie.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main_FORM zhucaidan = new Main_FORM();
            this.Hide();
            zhucaidan.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            neicungongxiang neicungongxiang = new neicungongxiang ();
            this.Hide();
            neicungongxiang.Show();
        }

        private void jinchengtongxinxuanze_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
