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
    public partial class Main_FORM : Form
    {
        public Main_FORM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Processcontrol Processcontrol = new Processcontrol();
            this.Hide();
            Processcontrol.Show();
        }

        private void zhu6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zhu7_Click(object sender, EventArgs e)
        {
            bangzhu bangzhu = new bangzhu();
            this.Hide();
            bangzhu.Show();
        }

        private void zhu8_Click(object sender, EventArgs e)
        {
            shuoming shuoming = new shuoming();
            this.Hide();
            shuoming.Show();
        }

        private void zhu2_Click(object sender, EventArgs e)
        {
            jiance _form1 = new jiance();
            this.Hide();
            _form1.Show();
        }

        private void zhu5_Click(object sender, EventArgs e)
        {
            DeadLockItem MainForm = new DeadLockItem();
            this.Hide();
            MainForm.Show();
        }

        private void zhu4_Click(object sender, EventArgs e)
        {
            jinchengtongxinxuanze jinchengtongxinxuanze = new jinchengtongxinxuanze ();
            this.Hide();
            jinchengtongxinxuanze.Show();
        }

        private void zhu3_Click(object sender, EventArgs e)
        {
            ProcessTongbu tongbu = new ProcessTongbu();
            this.Hide();
            tongbu.Show();
        }




    }
}
