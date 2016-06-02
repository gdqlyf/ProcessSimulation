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
    public partial class bangzhu : Form
    {
        public bangzhu()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bang1_Click(object sender, EventArgs e)
        {
            Main_FORM zhucaidan = new Main_FORM();
            this.Hide();
            zhucaidan.Show();
        }

        private void bangzhu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
