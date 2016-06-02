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
    public partial class guandaotongxin : Form
    {
        private int location;
        public int a;
        public guandaotongxin()
        {
            InitializeComponent();
        }

        private void guandaotongxin_Load(object sender, EventArgs e)
        {
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.fasongduan.Text == "")
            {
                MessageBox.Show("请输入传送信息！");
                return;
            }
            //获得服务时间和到达时间
            string chuansongxinxi = fasongduan.Text;
            jieshouduan.Text = chuansongxinxi;
            location = this.pictureBox2.Left;
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.pictureBox2.Left <= this.Width)
            {
            
                if (a == 114) 
                {
                    this.timer1.Stop();
                
                }
                a = a + 1;
                this.pictureBox2.Left = this.pictureBox2.Left + 4;
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            jinchengtongxinxuanze jinchengtongxinxuanze = new jinchengtongxinxuanze();
            this.Hide();
            jinchengtongxinxuanze.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.fasongduan.Text = "";
            this.jieshouduan.Text = "";
        }

        private void guandaotongxin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
