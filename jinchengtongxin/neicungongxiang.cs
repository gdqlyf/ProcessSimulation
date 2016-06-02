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
    public partial class neicungongxiang : Form
    {
        public neicungongxiang()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gongxiang2_Click(object sender, EventArgs e)
        {

        }

        private void anniu1_Click(object sender, EventArgs e)
        {
            if (this.fasongduan.Text == "")
            {
                MessageBox.Show("请输入传送信息！");
                return;
            }
            //获得服务时间和到达时间
            string gongxiangxinxi = fasongduan.Text;
            gongxiangneicun.Text = gongxiangxinxi;
            
        }

        private void anniu3_Click(object sender, EventArgs e)
        {
            this.fasongduan.Text = "";
            this.gongxiangneicun.Text = "";
            this.jieshouduan.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jinchengtongxinxuanze jinchengtongxinxuanze = new jinchengtongxinxuanze();
            this.Hide();
            jinchengtongxinxuanze.Show();
        }

        private void anniu2_Click(object sender, EventArgs e)
        {
            string jieshouxinxi = gongxiangneicun.Text;
            jieshouduan.Text = jieshouxinxi;
        }
    }
}
