using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProcessSimulation
{
    public partial class ProcessTongbu : Form
    {
        public ProcessTongbu()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            hScrollBar1.Enabled = false;
            label4.Enabled = false;
            textBox1.Text = Convert.ToString((100 - hScrollBar1.Value + 1) / 10);
        }

        int picture1_times = 0;//记录增长情况
        int picture1_Gra = 1;
        int Cpro = 1;

        private void button3_Click(object sender, EventArgs e)
        {
                timer1.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                hScrollBar1.Enabled = true;
                listBox1.Items.Add("生产者和消费者同时执行开始!!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text=="生产者阻塞")
            {
                button1.Text = "生产者执行";
                picture1_Gra = 2;
                Cpro = 2;
                timer1.Enabled = true;
                listBox1.Items.Add("生产进程被阻塞!");
            }
            else if (button1.Text == "生产者执行")
            {
                button1.Text = "生产者阻塞";
                picture1_Gra = 1;
                Cpro = 1;
                timer1.Enabled = true;
                //timer1_Tick(sender, e);
                listBox1.Items.Add("生产进程被执行!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                button2.Text = "生产者执行";
                picture1_Gra = 1;
                Cpro = 1;
                timer1_Tick(sender, e);
                listBox1.Items.Add("消费进程被阻塞!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            button1.Text = "生产者阻塞";
            button2.Text = "消费者阻塞";
            textBox1.Text = "";
            Graphics g1 = pictureBox1.CreateGraphics();
            g1.Clear(Color.Gray);
            //g1.DrawImage(this.pictureBox1.Image, 0, 0, pictureBox1.Width, pictureBox1.Height);


            listBox1.Items.Clear();
            picture1_times = 0;
            picture1_Gra = 1;
            Cpro = 1;
            hScrollBar1.Value = 50;
            button1.Enabled = false;
            button2.Enabled = false;
            hScrollBar1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = hScrollBar1.Value;
            textBox1.Text = Convert.ToString((100 - hScrollBar1.Value + 1) / 10);
        }

        private void randomCpro(object sender, EventArgs e)
        {

            if (Cpro == 1)
            { picture1_times++; picture1_times++; }
            else if (Cpro == 2) picture1_times--;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Cpro == 0)
                textBox2.Text = "空";
            else
                textBox2.Text = Cpro.ToString();
            switch (Cpro)
            {                
                case 1:
                    if (picture1_Gra == 1)
                    {
                        pictureBox1Move(sender, e);

                        listBox1.Items.Add("生产进程被执行!");
                    }
                    randomCpro(sender, e);
                    if (Cpro == 0) listBox1.Items.Add("当前无进程执行!");
                    break;
                case 2:
                    if (picture1_Gra == 2)
                    {
                        pictureBox1Move(sender, e);
                        listBox1.Items.Add("消费进程被执行!");
                    }
                    randomCpro(sender, e);
                    if (Cpro == 0) listBox1.Items.Add("当前无进程执行!");
                    break;

            }
        }

        private void pictureBox1Move(object sender, EventArgs e)
        {
            if (picture1_Gra == 1)//生产者执行图片变长
            {
                int iWidth1 = this.pictureBox1.Width;
                int iHeight1 = this.pictureBox1.Height;
                Graphics g1 = this.pictureBox1.CreateGraphics();
                if (picture1_times == 0) g1.Clear(Color.Gray);
                if (picture1_times == iHeight1)
                {
                    timer1.Enabled = false;
                    MessageBox.Show( "缓冲池用完无法继续消费,请等待消费或结束模拟","提示");
                }
                
                else
                    g1.DrawImage(this.pictureBox1.Image, 0, 0, iWidth1, picture1_times);
            }
            else if (picture1_Gra == 2)//消费者执行图片变短
            {
                int iWidth1 = this.pictureBox1.Width;
                int iHeight1 = this.pictureBox1.Height;
                Graphics g1 = this.pictureBox1.CreateGraphics();
                //if (picture1_times == iHeight1) picture1_times = 0;
                if (picture1_times == 0)
                {
                    timer1.Enabled = false;
                    g1.Clear(Color.Gray);
                    MessageBox.Show("产品用完无法继续消费,请重新生产","提示");
                }
                else
                    g1.DrawImage(this.pictureBox1.Image, 0, 0, iWidth1, picture1_times);                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Main_FORM main_form = new Main_FORM();
            this.Hide();
            main_form.Show();
        }

        private void ProcessTongbu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}