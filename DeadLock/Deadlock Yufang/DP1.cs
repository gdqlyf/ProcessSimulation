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
    public partial class DP1 : Form
    {
        public DP1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "申请")
            {
                if (qiu5.Visible == true && qiu1.Visible == true)
                {
                    qiu5.Visible = false;
                    qiu1.Visible = false;
                    poi1_2.Visible = true;
                    poi1_1.Visible = true;
                    button1.Text = "释放";
                }
                
                
            }
            else
            {
                button1.Text = "申请";
                qiu5.Visible = true;
                qiu1.Visible = true;
                poi1_2.Visible = false;
                poi1_1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "申请")
            {
                if (qiu2.Visible == true && qiu1.Visible == true)
                {
                    qiu2.Visible = false;
                    qiu1.Visible = false;
                    poi2_2.Visible = true;
                    poi2_1.Visible = true;
                    button2.Text = "释放";
                }
                

            }
            else
            {
                button2.Text = "申请";
                qiu2.Visible = true;
                qiu1.Visible = true;
                poi2_2.Visible = false;
                poi2_1.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "申请")
            {
                if (qiu2.Visible == true && qiu3.Visible == true)
                {
                    qiu2.Visible = false;
                    qiu3.Visible = false;
                    poi3_2.Visible = true;
                    poi3_1.Visible = true;
                    button3.Text = "释放";
                }


            }
            else
            {
                button3.Text = "申请";
                qiu2.Visible = true;
                qiu3.Visible = true;
                poi3_2.Visible = false;
                poi3_1.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "申请")
            {
                if (qiu4.Visible == true && qiu3.Visible == true)
                {
                    qiu4.Visible = false;
                    qiu3.Visible = false;
                    poi4_2.Visible = true;
                    poi4_1.Visible = true;
                    button4.Text = "释放";
                }


            }
            else
            {
                button4.Text = "申请";
                qiu4.Visible = true;
                qiu3.Visible = true;
                poi4_2.Visible = false;
                poi4_1.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "申请")
            {
                if (qiu4.Visible == true && qiu5.Visible == true)
                {
                    qiu4.Visible = false;
                    qiu5.Visible = false;
                    poi5_2.Visible = true;
                    poi5_1.Visible = true;
                    button5.Text = "释放";
                }


            }
            else
            {
                button5.Text = "申请";
                qiu4.Visible = true;
                qiu5.Visible = true;
                poi5_2.Visible = false;
                poi5_1.Visible = false;
            }
        }

        
    }
}
