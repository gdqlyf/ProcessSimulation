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
    public partial class DeadLockItem : Form
    {
        public DeadLockItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DPMain dp = new DPMain();
            this.Hide();
            dp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBMainForm db = new DBMainForm();
            this.Hide();
            db.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DJMainForm dj = new DJMainForm();
            this.Hide();
            dj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main_FORM main_form = new Main_FORM();
            this.Hide();
            main_form.Show();
        }
    }
}
