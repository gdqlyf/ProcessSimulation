using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ProcessSimulation
{
    public partial class jiance : Form
    {
        private string path = Environment.CurrentDirectory + @"\data.txt";
        private WorkCollection workList;
        private UiDisplay uiDisplay=new UiDisplay();//声明显示和添加控件的类对象
        private Schedule sdule=new Schedule();//进行调度的对象
        private WorkCollection wcFCFS;
        private WorkCollection wcSPN;
        private WorkCollection wcSRT;
        private WorkCollection wcHRRN;
        private WorkObject CurrentWork;//当前运行的作业
        private Button growthButton;//动态改变宽度的按钮
        private Queue q=new Queue();//先到先服务的队列
        private WorkCollection wcRuning=new WorkCollection();//该组作业演示时动态改变的集合
        private int workCount=0;//已执行完毕的作业计数器
        private int countOfTime1=0;//记录时钟Timer1的时间到达次数
        private int setupTime = 0;//已运行时间，以秒为计
        private int beginTime = 0;//每个作业占用CPU的起始时间，最短剩余时间优先时用到
        private Timer timer1;//时钟
        private int which=0;//为0表示在执行FCFS,为1表示要执行SPN
        private bool isPause=false;//true表示演示已经启动只是暂停了，false表示第一次启动演示
        public jiance()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 启动或暂停演示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (toolStripButton2.Text == "启动")
            {
                //设置图片
                toolStripButton2.Image = Properties.Resources.stop;
                toolStripButton2.Text = "暂停";
                if (!isPause)//第一次启动运行,不是被暂停的
                {
                    isPause = false;
                    //先来先服务，准备队列，并准备显示列表
                    wcFCFS = workList.Clone();//进行了深拷贝
                    BindDataGridView(ref wcFCFS,ref dataGridView1);
                    //最短作业优先
                    wcSPN = workList.Clone();
                    BindDataGridView(ref wcSPN, ref dataGridView2);
                    //最短剩余时间优先
                    wcSRT = workList.Clone();
                    BindDataGridView(ref wcSRT, ref dataGridView3);
                    //最高响应比
                    wcHRRN = workList.Clone();
                    BindDataGridView(ref wcHRRN, ref dataGridView4);
                    //作业开始计时工作
                    timer1 = new Timer();
                    timer1.Interval = 100;
                    timer1.Tick += new EventHandler(timer1_Tick);
                    timer1.Start();
                }
                else//演示已经开始了，只是被暂停了，恢复运行
                {
                    timer1.Start();
                }
            }
            else
            {
                isPause = true;
                toolStripButton2.Image = Properties.Resources.setup;
                toolStripButton2.Text = "启动";
                timer1.Stop();
            }

        }
        /// <summary>
        /// 绑定DataGridView控件
        /// </summary>
        /// <param name="wcFCFS"></param>
        /// <param name="mydataGridView"></param>
        private void BindDataGridView(ref WorkCollection workColl,ref DataGridView mydataGridView)
        {
            BindingSource bs = new BindingSource();
            foreach (object item in workColl)
            {
                bs.Add(item);
            }
            mydataGridView.AutoGenerateColumns = true;
            mydataGridView.DataSource = bs;
            mydataGridView.AutoGenerateColumns = false;//一定要加这句，要不然没法移除列
            mydataGridView.Columns.Remove("isSetup");
            mydataGridView.Columns.Remove("isWaiting");
            mydataGridView.Columns.Remove("isRunning");
            mydataGridView.Columns.Remove("isEnd");
            mydataGridView.Columns.Remove("HaveRunTime");
           
            mydataGridView.Columns[0].ReadOnly = true;
            mydataGridView.Columns[1].HeaderText = "作业名称";
            mydataGridView.Columns[2].HeaderText = "到达时间";
            mydataGridView.Columns[3].HeaderText = "服务时间";
            mydataGridView.Columns[4].HeaderText = "开始时间";
            mydataGridView.Columns[5].HeaderText = "结束时间";
            mydataGridView.Columns[6].HeaderText = "周转时间";
            mydataGridView.Columns[7].HeaderText = "带权周转时间";

            mydataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        /// <summary>
        /// 设置作业参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //如果演示已经运行中，停止他
            if (toolStripButton2.Text == "暂停"||isPause==true)
            {
                timer1.Stop();
                toolStripButton2.Image = Properties.Resources.setup;
                toolStripButton2.Text = "启动";
                toolStripLabel2.Text = Convert.ToString(0);
                setupTime = 0;
                countOfTime1 = 0;
                workCount = 0;
                CurrentWork = null;
                isPause = false;
                wcRuning.dataList.Clear();
            }
            Form form2 = new Form2(ref workList);
            form2.ShowDialog();
            if (form2.DialogResult == DialogResult.OK)
            {
                this.panel1.Controls.Clear();
                //timer1 = new Timer();
                //timer1.Interval = 100;
                //timer1.Tick += new EventHandler(timer1_Tick);
                uiDisplay.SetLableOfALLWork(ref panel1, ref workList, new Point(5, 20));
            }
        }
        /// <summary>
        /// timer事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            countOfTime1++;
            if (countOfTime1 % 10 == 0)
                setupTime++;
            toolStripLabel2.Text = "当前时间："+setupTime.ToString()+"s";
            //toolStripLabel1.Text = DateTime.Now.ToLongTimeString();
            //先到先服务
            if (which == 0)
                FCFS();
            else if (which == 1)
                SPN();
            else if (which == 2)
                SPT();
            else if (which == 3)
                HRRN();
        }
        /// <summary>
        /// 最高响应比优先
        /// </summary>
        private void HRRN()
        {
            if (countOfTime1 == 1)
                tabControl1.SelectedIndex = 3;
            if (countOfTime1 % 10 == 0 || countOfTime1 == 1)
            {
                foreach (WorkObject work in wcHRRN)
                {
                    if (work.ArrivalTime == setupTime)//有任务到达
                        wcRuning.dataList.Add(work);
                }
            }
            //取任务
            if (CurrentWork == null && wcRuning.Count != 0)//如果当前任务为空而且队列中还有任务，执行下面
                CurrentWork=sdule.FecthWorkForHRRN(ref wcRuning, setupTime);
            //运行任务
            if (CurrentWork != null)
            {
                //运行任务
                if (!CurrentWork.isSetup)
                {
                    //运行任务
                    sdule.WorkRun(ref CurrentWork, setupTime);
                    //设置显示效果
                    uiDisplay.AddButton(ref panel1,
                        ref growthButton,
                        new Point(200 + 5 * countOfTime1, 20 + 25 * CurrentWork.ID + workList.Count * 25 * which));
                }
                growthButton.Width += 5;
                //结束任务
                if (setupTime - CurrentWork.BeginTime >= CurrentWork.ServerTime)
                {
                    sdule.workEndForHRRN(ref wcRuning, ref CurrentWork, setupTime);
                    workCount++;//已经完成的作业计数器
                }
            }
            if (workCount == workList.Count)//所有作业都完成了
            {
                AllWorkEnd(4);//重置条件
                tabControl1.TabPages[3].Controls[tabControl1.TabPages[3].Controls.IndexOfKey("myTextBox13")].Text = sdule.averageOfZhouZhuan(ref wcHRRN).ToString();//求平均周转
                tabControl1.TabPages[3].Controls[tabControl1.TabPages[3].Controls.IndexOfKey("myTextBox23")].Text = sdule.averageOfZhouZhuan1(ref wcHRRN).ToString();
            }
            dataGridView4.Refresh();
        }
        /// <summary>
        /// 最短剩余时间优先
        /// </summary>
        private void SPT()
        {
            if (countOfTime1 == 1)
                tabControl1.SelectedIndex = 2;
            if (countOfTime1 % 10 == 0 || countOfTime1 == 1)
            {
                foreach (WorkObject work in wcSRT)
                {
                    if (work.ArrivalTime == setupTime)//有任务到达
                    {
                        wcRuning.dataList.Add(work);
                        if (CurrentWork == null)
                        {
                            CurrentWork = sdule.FecthWorkForSPT(ref wcRuning);
                            if (CurrentWork != null)
                                CurrentWork.isWaiting = true;
                        }
                        else//新加的作业是否比当前作业剩余时间短
                        {
                            if (work.ServerTime < (CurrentWork.ServerTime - CurrentWork.HaveRunTime))
                            {
                                //对于立马要结束的作业执行多一次，防止立马完成的任务，没有正常结束
                                if (CurrentWork.HaveRunTime == CurrentWork.ServerTime - 1)//判断是否是要结束的任务
                                {
                                    growthButton.Width += 5;
                                    CurrentWork.HaveRunTime++;
                                    //结束任务
                                    sdule.WorkEndForSPT(ref wcRuning, ref CurrentWork, setupTime);
                                    workCount++;//已经完成的作业计数器
                                }
                                else//如果不是，保存
                                {
                                    growthButton.Width += 5;
                                    CurrentWork.HaveRunTime++;
                                    sdule.SaveCurrentWorkForSPT(ref CurrentWork);//保存当前作业
                                }
                                CurrentWork = work;//抢占
                                CurrentWork.isWaiting = true;
                            }
                        }
                    }
                }

            }
            if (CurrentWork == null && wcRuning.Count != 0)//执行完一个作业，但是又没有新作业到达时执行
            {
                CurrentWork = sdule.FecthWorkForSPT(ref wcRuning);
                if (CurrentWork != null)
                    CurrentWork.isWaiting = true;
            }
            if (CurrentWork != null)
            {
                //运行任务
                if (!CurrentWork.isSetup)//作业第一次启动
                    CurrentWork.BeginTime = setupTime;//设置起始时间
                if (CurrentWork.isWaiting)
                {
                    sdule.WorkRunForSPT(ref CurrentWork, setupTime);
                    //设置显示效果
                    uiDisplay.AddButton(ref panel1,
                        ref growthButton,
                        new Point(200 + 5 * countOfTime1,
                            20 + 25 * CurrentWork.ID + workList.Count * 25 * which));
                    beginTime = setupTime;//标识此次运行的起始时间
                }
                growthButton.Width += 5;
                if (countOfTime1 % 10 == 0&&setupTime>beginTime)//每秒钟到来
                    CurrentWork.HaveRunTime++;
                //结束任务
                if (CurrentWork.HaveRunTime == CurrentWork.ServerTime)
                {
                    sdule.WorkEndForSPT(ref wcRuning, ref CurrentWork, setupTime);//这里还将已经完成的作业移除
                    workCount++;//已经完成的作业计数器
                }
            }
            if (workCount == workList.Count)//所有作业都完成了
            {
                AllWorkEnd(3);//重置条件
                tabControl1.TabPages[2].Controls[tabControl1.TabPages[2].Controls.IndexOfKey("myTextBox12")].Text = sdule.averageOfZhouZhuan(ref wcSRT).ToString();//求平均周转
                tabControl1.TabPages[2].Controls[tabControl1.TabPages[2].Controls.IndexOfKey("myTextBox22")].Text = sdule.averageOfZhouZhuan1(ref wcSRT).ToString();
            }
            dataGridView3.Refresh();


        }
        //最短进程优先
        private void SPN()
        {
            if (countOfTime1 == 1)
                tabControl1.SelectedIndex = 1;
            if (countOfTime1 % 10 == 0 || countOfTime1 == 1)
            {
                foreach (WorkObject work in wcSPN)
                {
                    if (work.ArrivalTime == setupTime)//有任务到达
                        wcRuning.dataList.Add(work);
                }
            }
            //取任务
            if (CurrentWork == null && wcRuning.Count != 0)//如果当前任务为空而且队列中还有任务，执行下面
                CurrentWork = sdule.FecthWorkForSPN(ref wcRuning);
            //运行任务
            if (CurrentWork != null)
            {
                //运行任务
                if (!CurrentWork.isSetup)
                {
                    //运行任务
                    sdule.WorkRun(ref CurrentWork, setupTime);
                    //设置显示效果
                    uiDisplay.AddButton(ref panel1,
                        ref growthButton,
                        new Point(200 + 5 * countOfTime1, 20 + 25 * CurrentWork.ID + workList.Count * 25 * which));
                }
                growthButton.Width += 5;
                //结束任务
                if (setupTime - CurrentWork.BeginTime >= CurrentWork.ServerTime)
                {
                    sdule.workEnd(ref CurrentWork, setupTime);
                    workCount++;//已经完成的作业计数器
                }
            }
            if (workCount == workList.Count)//所有作业都完成了
            {
                AllWorkEnd(2);//重置条件
                tabControl1.TabPages[1].Controls[tabControl1.TabPages[1].Controls.IndexOfKey("myTextBox11")].Text = sdule.averageOfZhouZhuan(ref wcSPN).ToString();//求平均周转
                tabControl1.TabPages[1].Controls[tabControl1.TabPages[1].Controls.IndexOfKey("myTextBox21")].Text = sdule.averageOfZhouZhuan1(ref wcSPN).ToString();
            }
            dataGridView2.Refresh();
        }
        private void FCFS()
        {
            //每秒判断一次是否有任务到达
            if (countOfTime1 % 10 == 0||countOfTime1==1)
            {
                foreach (WorkObject work in wcFCFS)
                {
                    if (work.ArrivalTime == setupTime)
                        q.Enqueue(work);
                }
            }
            //取任务
            if (CurrentWork == null && q.Count != 0)//如果当前任务为空而且队列中还有任务，执行下面
                CurrentWork=sdule.FecthWork(ref q);
            if (CurrentWork != null)
            {
                if (!CurrentWork.isSetup)
                {
                    //运行任务
                    sdule.WorkRun(ref CurrentWork,setupTime);
                    //设置显示效果
                    uiDisplay.AddButton(ref panel1,
                        ref growthButton,
                        new Point(200 + 5 * countOfTime1, 20 + 25 * CurrentWork.ID + workList.Count * 25 * which));
                }
                growthButton.Width += 5;
                //结束任务
                if (setupTime - CurrentWork.BeginTime >= CurrentWork.ServerTime)
                {
                    sdule.workEnd(ref CurrentWork,setupTime);
                    workCount++;//已经完成的作业计数器
                }
            }
            if (workCount == wcFCFS.Count)//FCFS所有作业都完成了
            {
                AllWorkEnd(1);//重置条件
                tabControl1.TabPages[0].Controls[tabControl1.TabPages[0].Controls.IndexOfKey("myTextBox10")].Text = sdule.averageOfZhouZhuan(ref wcFCFS).ToString();//求平均周转
                tabControl1.TabPages[0].Controls[tabControl1.TabPages[0].Controls.IndexOfKey("myTextBox20")].Text = sdule.averageOfZhouZhuan1(ref wcFCFS).ToString();
            }
            dataGridView1.Refresh();
        }
        private void AllWorkEnd(int Next)
        {
            which =Next;
            workCount = 0;
            //重置时钟
            countOfTime1 = 0;
            setupTime = 0;
            toolStripLabel2.Text = setupTime.ToString();
            if (wcRuning.Count != 0)
                wcRuning.dataList.Clear();
            if (Next >= 4)
                timer1.Stop();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            tabControl1.Height =200;
            tabControl1.TabPages[0].Width = Width - 200;
            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                myLabel = (Label)tabControl1.TabPages[i].Controls[tabControl1.TabPages[i].Controls.IndexOfKey("myLabel1"+i.ToString())];
                myLabel.Location = new Point(Width - 180, 0);

                myTextBox= (TextBox)tabControl1.TabPages[i].Controls[tabControl1.TabPages[i].Controls.IndexOfKey("myTextBox1" + i.ToString())];
                myTextBox.Location = new Point(Width - 180, 28);


                myLabel = (Label)tabControl1.TabPages[i].Controls[tabControl1.TabPages[i].Controls.IndexOfKey("myLabel2" + i.ToString())];
                myLabel.Location = new Point(Width - 180, 66);


                myTextBox = (TextBox)tabControl1.TabPages[i].Controls[tabControl1.TabPages[i].Controls.IndexOfKey("myTextBox2" + i.ToString())];
                myTextBox.Location = new Point(Width - 180, 94);
            }
        }
        //停止演示
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //如果演示已经运行中，停止他
            if (toolStripButton2.Text == "暂停" || isPause == true)
            {
                timer1.Stop();
                which = 0;
                toolStripButton2.Image = Properties.Resources.setup;
                toolStripButton2.Text = "启动";
                toolStripLabel2.Text = Convert.ToString(0);
                setupTime = 0;
                countOfTime1 = 0;
                workCount = 0;
                CurrentWork = null;
                isPause = false;
                wcRuning.dataList.Clear();
                panel1.Controls.Remove(growthButton);
            }
        }
        private TextBox myTextBox;
        private Label myLabel;
        private void Form1_Load(object sender, EventArgs e)
        {
            //读取默认的数据
            ReadAndWriteTXT rw = new ReadAndWriteTXT(path, System.IO.FileMode.OpenOrCreate);
            workList = rw.ReadTXT();//return a Object of workCollection
            UiDisplay uiDisplay = new UiDisplay();
            this.panel1.Controls.Clear();
            uiDisplay.SetLableOfALLWork(ref panel1, ref workList, new Point(5, 20));
            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                myLabel = new Label();
                myLabel.Name = "myLabel1" + i.ToString();
                myLabel.Text = "平均周转时间:";
                tabControl1.TabPages[i].Controls.Add(myLabel);
                myLabel.Location = new Point(Width - 180, 0);
                myLabel.Anchor = AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left;

                myTextBox = new TextBox();
                myTextBox.Name = "myTextBox1" + i.ToString();
                myTextBox.Text = "0";
                myTextBox.ForeColor = Color.Red;
                tabControl1.TabPages[i].Controls.Add(myTextBox);
                myTextBox.Anchor = AnchorStyles.Top & AnchorStyles.Right & AnchorStyles.Bottom & AnchorStyles.Left;
                myTextBox.Location = new Point(Width - 180, 28);


                myLabel = new Label();
                myLabel.Text = "平均带权周转时间:";
                myLabel.AutoSize = true;
                myLabel.Name = "myLabel2" + i.ToString();
                tabControl1.TabPages[i].Controls.Add(myLabel);
                myLabel.Location = new Point(Width - 180, 66);
                myLabel.Anchor = AnchorStyles.Top & AnchorStyles.Right & AnchorStyles.Bottom & AnchorStyles.Left;

                myTextBox = new TextBox();
                myTextBox.Name = "myTextBox2" + i.ToString();
                myTextBox.Text = "0";
                myTextBox.ForeColor = Color.Red;
                tabControl1.TabPages[i].Controls.Add(myTextBox);
                myTextBox.Location = new Point(Width - 180, 94);
                myTextBox.Anchor = AnchorStyles.Top & AnchorStyles.Right & AnchorStyles.Bottom & AnchorStyles.Left;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_FORM main_form = new Main_FORM();
            this.Hide();
            main_form.Show();
        }

        private void jiance_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
