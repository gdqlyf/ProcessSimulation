﻿using System;
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
    public partial class DP2 : Form
    {
        public DP2()
        {
            InitializeComponent();
        }

        private void button1_1_Click(object sender, EventArgs e)
        {
            if (button1_1.Text == "申请")
            {
                if (qiu5.Visible == true)
                {
                    qiu5.Visible = false;
                    poi1_1.Visible = true;
                    button1_1.Text = "释放";
                }
                else if (poi1_2.Visible == true)
                {
                    poi1_2.Visible = false;
                    qiu1.Visible = true;
                    button1_2.Text = "申请";
                }
            }
            else
            {
                button1_1.Text = "申请";
                poi1_1.Visible = false;
                qiu5.Visible = true;
            }
        }

        private void button1_2_Click(object sender, EventArgs e)
        {
            if (button1_2.Text == "申请")
            {
                if (qiu1.Visible == true)
                {
                    qiu1.Visible = false;
                    poi1_2.Visible = true;
                    button1_2.Text = "释放";
                }
                else if (poi1_1.Visible == true)
                {
                    poi1_1.Visible = false;
                    qiu5.Visible = true;
                    button1_1.Text = "申请";
                }
            }
            else
            {
                button1_2.Text = "申请";
                poi1_2.Visible = false;
                qiu1.Visible = true;
            }
        }

        private void button2_1_Click(object sender, EventArgs e)
        {
            if (button2_1.Text == "申请")
            {
                if (qiu1.Visible == true)
                {
                    qiu1.Visible = false;
                    poi2_1.Visible = true;
                    button2_1.Text = "释放";
                }
                else if (poi2_2.Visible == true)
                {
                    poi2_2.Visible = false;
                    qiu2.Visible = true;
                    button2_2.Text = "申请";
                } 
            }
            else
            {
                button2_1.Text = "申请";
                poi2_1.Visible = false;
                qiu1.Visible = true;
            }
        }

        private void button2_2_Click(object sender, EventArgs e)
        {
            if (button2_2.Text == "申请")
            {
                if (qiu2.Visible == true)
                {
                    qiu2.Visible = false;
                    poi2_2.Visible = true;
                    button2_2.Text = "释放";
                }
                else if (poi2_1.Visible == true)
                {
                    poi2_1.Visible = false;
                    qiu1.Visible = true;
                    button2_1.Text = "申请";
                } 
            }
            else
            {
                button2_2.Text = "申请";
                poi2_2.Visible = false;
                qiu2.Visible = true;
            }
        }

        private void button3_1_Click(object sender, EventArgs e)
        {
            if (button3_1.Text == "申请")
            {
                if (qiu3.Visible == true)
                {
                    qiu3.Visible = false;
                    poi3_1.Visible = true;
                    button3_1.Text = "释放";
                }
                else if (poi3_2.Visible == true)
                {
                    poi3_2.Visible = false;
                    qiu2.Visible = true;
                    button3_2.Text = "申请";
                } 
            }
            else
            {
                button3_1.Text = "申请";
                poi3_1.Visible = false;
                qiu3.Visible = true;
            }
        }

        private void button3_2_Click(object sender, EventArgs e)
        {
            if (button3_2.Text == "申请")
            {
                if (qiu2.Visible == true)
                {
                    qiu2.Visible = false;
                    poi3_2.Visible = true;
                    button3_2.Text = "释放";
                }
                else if (poi3_1.Visible == true)
                {
                    poi3_1.Visible = false;
                    qiu3.Visible = true;
                    button3_1.Text = "申请";
                } 
            }
            else
            {
                button3_2.Text = "申请";
                poi3_2.Visible = false;
                qiu2.Visible = true;
            }
        }

        private void button4_1_Click(object sender, EventArgs e)
        {
            if (button4_1.Text == "申请")
            {
                if (qiu4.Visible == true)
                {
                    qiu4.Visible = false;
                    poi4_1.Visible = true;
                    button4_1.Text = "释放";
                }
                else if (poi4_2.Visible == true)
                {
                    poi4_2.Visible = false;
                    qiu3.Visible = true;
                    button4_2.Text = "申请";
                } 
            }
            else
            {
                button4_1.Text = "申请";
                poi4_1.Visible = false;
                qiu4.Visible = true;
            }
        }

        private void button4_2_Click(object sender, EventArgs e)
        {
            if (button4_2.Text == "申请")
            {
                if (qiu3.Visible == true)
                {
                    qiu3.Visible = false;
                    poi4_2.Visible = true;
                    button4_2.Text = "释放";
                }
                else if (poi4_1.Visible == true)
                {
                    poi4_1.Visible = false;
                    qiu4.Visible = true;
                    button4_1.Text = "申请";
                } 
            }
            else
            {
                button4_2.Text = "申请";
                poi4_2.Visible = false;
                qiu3.Visible = true;
            }
        }

        private void button5_1_Click(object sender, EventArgs e)
        {
            if (button5_1.Text == "申请")
            {
                if (qiu5.Visible == true)
                {
                    qiu5.Visible = false;
                    poi5_1.Visible = true;
                    button5_1.Text = "释放";
                }
                else if (poi5_2.Visible == true)
                {
                    poi5_2.Visible = false;
                    qiu4.Visible = true;
                    button5_2.Text = "申请";
                } 
            }
            else
            {
                button5_1.Text = "申请";
                poi5_1.Visible = false;
                qiu5.Visible = true;
            }
        }

        private void button5_2_Click(object sender, EventArgs e)
        {
            if (button5_2.Text == "申请")
            {
                if (qiu4.Visible == true)
                {
                    qiu4.Visible = false;
                    poi5_2.Visible = true;
                    button5_2.Text = "释放";
                }
                else if (poi5_1.Visible == true)
                {
                    poi5_1.Visible = false;
                    qiu5.Visible = true;
                    button5_1.Text = "申请";
                } 
            }
            else
            {
                button5_2.Text = "申请";
                poi5_2.Visible = false;
                qiu4.Visible = true;
            }
        }
    }
}
