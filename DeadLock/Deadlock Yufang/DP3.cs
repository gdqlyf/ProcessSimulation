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
    public partial class DP3 : Form
    {
        public DP3()
        {
            InitializeComponent();
        }

        private void button1_1_Click(object sender, EventArgs e)
        {
            if (button1_1.Text == "申请" && qiu1.Visible == true)
            {
                qiu1.Visible = false;
                poi1_1.Visible = true;
                button1_1.Text = "释放";
            }
            else if (button1_1.Text == "释放")
            {
                qiu1.Visible = true;
                poi1_1.Visible = false;
                button1_1.Text = "申请";
            }
        }

        private void button1_2_Click(object sender, EventArgs e)
        {
            if (button1_2.Text == "申请" && poi1_1.Visible == true && qiu2.Visible == true)
            {
                qiu2.Visible = false;
                poi1_2.Visible = true;
                button1_2.Text = "释放";
            }
            else if (button1_2.Text == "释放")
            {
                qiu2.Visible = true;
                poi1_2.Visible = false;
                button1_2.Text = "申请";
            }
            else if (button1_2.Text == "申请" && qiu1.Visible == true)
            {
                qiu1.Visible = false;
                poi1_1.Visible = true;
                button1_1.Text = "释放";
            }
        }

        private void button2_1_Click(object sender, EventArgs e)
        {
            if (button2_1.Text == "申请" && qiu1.Visible == true)
            {
                qiu1.Visible = false;
                poi2_1.Visible = true;
                button2_1.Text = "释放";
            }
            else if (button2_1.Text == "释放")
            {
                qiu1.Visible = true;
                poi2_1.Visible = false;
                button2_1.Text = "申请";
            }
        }

        private void button2_2_Click(object sender, EventArgs e)
        {
            if (button2_2.Text == "申请" && poi2_1.Visible == true && qiu2.Visible == true)
            {
                qiu2.Visible = false;
                poi2_2.Visible = true;
                button2_2.Text = "释放";
            }
            else if (button2_2.Text == "释放")
            {
                qiu2.Visible = true;
                poi2_2.Visible = false;
                button2_2.Text = "申请";
            }
            else if(button2_2.Text == "申请" && qiu1.Visible == true)
            {
                qiu1.Visible = false;
                poi2_1.Visible = true;
                button2_1.Text = "释放";
            }
        }
    }
}
