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
    public partial class Processcontrol : Form
    {
        public Processcontrol()
        {
            InitializeComponent();

        }
        static int totalCPU = 0;     //CPU量
        static int totalMem = 0;     //内存量
        static int totalPrinter = 0; //I/O数量     
        Process pro;       //新建进程
        Process process = new Process(null, 0, 0, 0, 0, 0);
        int timeSlice = 0; //时间片
        bool flag = true;
        int count = 0;
        int index = 0;

        public void newPro(ListView p)     //新建进程进入活动就绪  
        {
            ListViewItem List = new ListViewItem(pro.name);
            List.SubItems.Add(pro.need_CPU.ToString());
            List.SubItems.Add(pro.need_time.ToString());
            List.SubItems.Add(pro.need_memery.ToString());
            List.SubItems.Add(pro.need_printer.ToString());
            List.SubItems.Add(pro.more_time.ToString());
            p.Items.Add(List);
            new_pro_name.Text = "";
            req_CPU.Text = "";
            need_t.Text = "";
            req_mem.Text = "";
            req_printer.Text = "";
        }
        public void Transfer(Process p)    //时间片到了但没有执行完进入活动就绪  
        {
            ListViewItem item = new ListViewItem(p.name);
            item.SubItems.Add(p.need_CPU.ToString());
            item.SubItems.Add(p.need_time.ToString());
            item.SubItems.Add(p.need_memery.ToString());
            item.SubItems.Add(p.need_printer.ToString());
            item.SubItems.Add(p.more_time.ToString());
            listView1.Items.Add(item);
        }
        public void wakePro(Process p)     //活动阻塞释放、静止就绪激活进入活动就绪  
        {
            ListViewItem item = new ListViewItem(p.name);
            item.SubItems.Add(p.need_CPU.ToString());
            item.SubItems.Add(p.need_time.ToString());
            item.SubItems.Add(p.need_memery.ToString());
            item.SubItems.Add(p.need_printer.ToString());
            item.SubItems.Add(p.more_time.ToString());
            listView1.Items.Add(item);
        }
        public void hangup(Process p)      //执行进程挂起、活动就绪挂起、静止阻塞释放进入静止就绪状态
        {
            ListViewItem item = new ListViewItem(p.name);
            item.SubItems.Add(p.need_CPU.ToString());
            item.SubItems.Add(p.need_time.ToString());
            item.SubItems.Add(p.need_memery.ToString());
            item.SubItems.Add(p.need_printer.ToString());
            item.SubItems.Add(p.more_time.ToString());
            listView5.Items.Add(item);
        }
        public void blockPro(Process p)    //执行状态阻塞、静止阻塞激活进入活动阻塞   
        {
            ListViewItem item = new ListViewItem(p.name);
            item.SubItems.Add(p.need_CPU.ToString());
            item.SubItems.Add(p.need_time.ToString());
            item.SubItems.Add(p.need_memery.ToString());
            item.SubItems.Add(p.need_printer.ToString());
            item.SubItems.Add(p.more_time.ToString());
            listView2.Items.Add(item);
        }
        public void blockPro1(Process p)   //活动阻塞挂起进入静止阻塞   
        {
            ListViewItem item = new ListViewItem(p.name);
            item.SubItems.Add(p.need_CPU.ToString());
            item.SubItems.Add(p.need_time.ToString());
            item.SubItems.Add(p.need_memery.ToString());
            item.SubItems.Add(p.need_printer.ToString());
            item.SubItems.Add(p.more_time.ToString());
            listView6.Items.Add(item);
        }
        public void occupyCPU()            //进程进入执行队列  
        {
            if (listView7.Items.Count != 0)
                listView7.Items.Remove(listView7.Items[0]);
            ListViewItem item = new ListViewItem(process.name);
            item.SubItems.Add(process.need_CPU.ToString());
            item.SubItems.Add(process.need_time.ToString());
            item.SubItems.Add(process.need_memery.ToString());
            item.SubItems.Add(process.need_printer.ToString());
            item.SubItems.Add(process.more_time.ToString());
            listView7.Items.Add(item);
        }
        public void finishPro(Process p)   //进程执行完后进入完成队列  
        {
            ListViewItem item = new ListViewItem(p.name);
            item.SubItems.Add(p.need_CPU.ToString());
            item.SubItems.Add(p.need_time.ToString());
            item.SubItems.Add(p.need_memery.ToString());
            item.SubItems.Add(p.need_printer.ToString());
            item.SubItems.Add(p.more_time.ToString());
            listView3.Items.Add(item);
            totalCPU = totalCPU + p.need_CPU;
            totalMem = totalMem + p.need_memery;
            totalPrinter = totalPrinter + p.need_printer;
        }

        public void runPro()      //多级反馈轮转调度算法  
        {
            int ready = 0;
            if (listView1.Items.Count != 0)
            {
                ready = 1;
                process.rank = 1;
                process.state = 1;
                process.name = listView1.Items[0].SubItems[0].Text;
                process.need_CPU = int.Parse(listView1.Items[0].SubItems[1].Text);
                process.need_time = int.Parse(listView1.Items[0].SubItems[2].Text);
                process.need_memery = int.Parse(listView1.Items[0].SubItems[3].Text);
                process.need_printer = int.Parse(listView1.Items[0].SubItems[4].Text);
                process.more_time = int.Parse(listView1.Items[0].SubItems[5].Text);
                listView1.Items.Remove(listView1.Items[0]);
            }
            if (ready == 0)
            {
                process.name = "";
                process.need_CPU = 0;
                process.need_time = 0;
                process.need_memery = 0;
                process.need_printer = 0;
                process.more_time = 0;
            }
            else
                process.state = 0;
            if (listView7.Items.Count != 0)
                listView7.Items.Remove(listView7.Items[0]);
            ListViewItem item = new ListViewItem(process.name);
            item.SubItems.Add(process.need_CPU.ToString());
            item.SubItems.Add(process.need_time.ToString());
            item.SubItems.Add(process.need_memery.ToString());
            item.SubItems.Add(process.need_printer.ToString());
            listView7.Items.Add(item);
            int c = ready;
            if (ready == 1)
                timeSlice = 2;
            else
            {
                timeSlice = 0;
                listView7.Items.Clear();
                timer1.Enabled = false;
                MessageBox.Show("所有就绪队列中进程执行结束", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void runFCFS()     //先进先服务调度算法  
        {
            if (listView1.Items.Count != 0)
            {
                process.name = listView1.Items[0].SubItems[0].Text;
                process.need_CPU = int.Parse(listView1.Items[0].SubItems[1].Text);
                process.need_time = int.Parse(listView1.Items[0].SubItems[2].Text);
                process.need_memery = int.Parse(listView1.Items[0].SubItems[3].Text);
                process.need_printer = int.Parse(listView1.Items[0].SubItems[4].Text);
                process.more_time = int.Parse(listView1.Items[0].SubItems[5].Text);
                listView1.Items.Remove(listView1.Items[0]);
            }
            else
            {
                MessageBox.Show("没有就绪状态的进程", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void startP()      //开始模拟
        {
            if (radioButton1.Checked)
            {
                runPro();
                occupyCPU();
                timer1.Enabled = true;
            }
            else if (radioButton2.Checked)
            {
                runFCFS();
                occupyCPU();
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("请选择调度算法", "消息", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)      //时间片控制
        {
            if (flag)
            {
                process.more_time--;
                count++;
            }
            if (process.more_time == 0)
            {
                flag = false;
                process.state = 3;
                finishPro(process);
            }
            else if (count == timeSlice)
            {
                flag = false;
                Transfer(process);
            }
            occupyCPU();
            if (flag == false && process.name != null)
            {
                runPro();
                count = 0;
                flag = true;
            }
            if (process.name == null)
                MessageBox.Show("全部就绪队列已经执行完毕！！！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.toolStripStatusLabel1.Text = "CPU利用率：" + Convert.ToString((double.Parse(this.text3.Text) - totalCPU) / double.Parse(this.text3.Text) * 100) + "%";
            this.toolStripStatusLabel2.Text = "内存利用率：" + Convert.ToString((double.Parse(this.text1.Text) - totalMem) / double.Parse(this.text1.Text) * 100) + "%";
        }

        private void initial_set_Click(object sender, EventArgs e)//初始化设置
        {
            totalCPU = int.Parse(this.text3.Text);
            totalMem = int.Parse(this.text1.Text);
            totalPrinter = int.Parse(this.text2.Text);
            MessageBox.Show("初始化设置完成！");
        }

        private void new_job_Click(object sender, EventArgs e)    //新建进程
        {
            try
            {
                if (new_pro_name.Text != null && req_CPU.Text != null)
                { 
                    pro = new Process(new_pro_name.Text, int.Parse(req_CPU.Text), int.Parse(need_t.Text), int.Parse(req_mem.Text), int.Parse(req_printer.Text), int.Parse(need_t.Text));
                    if ((int.Parse(req_CPU.Text) > totalCPU) || (int.Parse(req_printer.Text) > totalPrinter) || (int.Parse(req_mem.Text) > totalMem))
                    {
                        MessageBox.Show("内存打印机资源不够", "创建进程失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        newPro(listView1);
                        newPro(listView4);
                        totalCPU = totalCPU - pro.need_CPU;
                        totalMem = totalMem - pro.need_memery;
                        totalPrinter = totalPrinter - pro.need_printer;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("输入进程名", "创建进程失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            catch
            {
                MessageBox.Show("");
            }

        }

        private void start_Click(object sender, EventArgs e)      //开始模拟
        {
            startP();
        }

        private void button4_Click(object sender, EventArgs e)  //活动就绪挂起进入静止就绪
        {
            if (listView1.Items.Count != 0)
            {
                Process p1 = new Process(listView1.Items[index].SubItems[0].Text, int.Parse(listView1.Items[0].SubItems[1].Text),
                int.Parse(listView1.Items[0].SubItems[2].Text), int.Parse(listView1.Items[0].SubItems[3].Text), int.Parse(listView1.Items[0].SubItems[4].Text),
                int.Parse(listView1.Items[0].SubItems[5].Text));
                p1.state = 2;
                hangup(p1);
                listView1.Items.Remove(listView1.Items[index]);
            }
            else
                MessageBox.Show("没有进程活动就绪", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)  //静止就绪激活进入活动就绪
        {
            if (listView5.Items.Count != 0)
            {
                Process p1 = new Process(listView5.Items[index].SubItems[0].Text, int.Parse(listView5.Items[0].SubItems[1].Text),
                int.Parse(listView5.Items[0].SubItems[2].Text), int.Parse(listView5.Items[0].SubItems[3].Text), int.Parse(listView5.Items[0].SubItems[4].Text),
                int.Parse(listView5.Items[0].SubItems[5].Text));
                p1.state = 1;
                wakePro(p1);
                //runPro();
                //if (timeSlice != 0)
                //    timer1.Enabled = true;
                //else
                //    MessageBox.Show("没有就绪状态的进程", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView5.Items.Remove(listView5.Items[index]);
            }
            else
                MessageBox.Show("没有进程活动就绪", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)  //活动阻塞挂起进入静止就绪
        {
            if (listView2.Items.Count != 0)
            {
                Process p1 = new Process(listView2.Items[index].SubItems[0].Text, int.Parse(listView2.Items[0].SubItems[1].Text),
                int.Parse(listView2.Items[0].SubItems[2].Text), int.Parse(listView2.Items[0].SubItems[3].Text), int.Parse(listView2.Items[0].SubItems[4].Text),
                int.Parse(listView2.Items[0].SubItems[5].Text));
                p1.state = 2;
                blockPro1(p1);
                listView2.Items.Remove(listView2.Items[index]);
            }
            else
                MessageBox.Show("没有活动阻塞的进程", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)  //静止阻塞激活进入活动阻塞
        {
            if (listView6.Items.Count != 0)
            {
                Process p1 = new Process(listView6.Items[index].SubItems[0].Text, int.Parse(listView6.Items[0].SubItems[1].Text),
                int.Parse(listView6.Items[0].SubItems[2].Text), int.Parse(listView6.Items[0].SubItems[3].Text), int.Parse(listView6.Items[0].SubItems[4].Text),
                int.Parse(listView6.Items[0].SubItems[5].Text));
                blockPro(p1);
                listView6.Items.Remove(listView6.Items[index]);
            }
            else
                MessageBox.Show("没有进程阻塞", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void wake_Click(object sender, EventArgs e)     //活动阻塞释放进入活动就绪
        {
            if (listView2.Items.Count != 0)
            {
                Process p1 = new Process(listView2.Items[index].SubItems[0].Text, int.Parse(listView2.Items[0].SubItems[1].Text),
                int.Parse(listView2.Items[0].SubItems[2].Text), int.Parse(listView2.Items[0].SubItems[3].Text), int.Parse(listView2.Items[0].SubItems[4].Text),
                int.Parse(listView2.Items[0].SubItems[5].Text));
                p1.state = 1;
                wakePro(p1);
                //runPro();
                //if (timeSlice != 0)
                //    timer1.Enabled = true;
                //else
                //    MessageBox.Show("没有就绪状态的进程", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView2.Items.Remove(listView2.Items[index]);
            }
            else
                MessageBox.Show("没有进程阻塞", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void block_Click(object sender, EventArgs e)    //执行状态阻塞进入活动阻塞
        {
            timer1.Enabled = false;
            process.state = 2;
            blockPro(process);
            runPro();
            if (timeSlice != 0)
                timer1.Enabled = true;
            else
                MessageBox.Show("没有就绪状态的进程", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void stop_Click(object sender, EventArgs e)     //执行状态挂起进入静止就绪
        {
            if (listView7.Items.Count != 0)
            {
                Process p1 = new Process(listView7.Items[index].SubItems[0].Text, int.Parse(listView7.Items[0].SubItems[1].Text),
                int.Parse(listView7.Items[0].SubItems[2].Text), int.Parse(listView7.Items[0].SubItems[3].Text), int.Parse(listView7.Items[0].SubItems[4].Text),
                int.Parse(listView7.Items[0].SubItems[5].Text));
                p1.state = 2;
                blockPro1(p1);
                listView7.Items.Remove(listView7.Items[index]);
            }
            else
                MessageBox.Show("没有活动阻塞的进程", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void reset_Click(object sender, EventArgs e)     //重置
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            listView4.Items.Clear();
            listView5.Items.Clear();
            listView6.Items.Clear();
            listView7.Items.Clear();
            text1.Text = "";
            text2.Text = "";
            new_pro_name.Text = "";
            req_CPU.Text = "";
            need_t.Text = "";
            req_mem.Text = "";
            req_printer.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void exit_Click(object sender, EventArgs e)      //退出
        {
            Main_FORM main_form = new Main_FORM();
            this.Hide();
            main_form.Show();
        }

        private void button5_Click(object sender, EventArgs e)   //暂停
        {
            timer1.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)   //继续
        {
            timer1.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Processcontrol_Load(object sender, EventArgs e)
        {

        }

        private void Processcontrol_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}