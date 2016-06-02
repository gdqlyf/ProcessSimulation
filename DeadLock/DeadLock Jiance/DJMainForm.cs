using ProcessSimulation;
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
    public partial class DJMainForm : Form
    {
        private Progress progress = new Progress();//创建进程progress
        public Progress[] allProgress = new Progress[50];//存放添加的所有进程
        private int progressNumber = 0;//进程数目

        public int[] Available = new int[3];//资源数组
        
        private int temp;//提出申请的资源号

        public DJMainForm()
        {
            
            InitializeComponent();//初始化主窗体
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Available[0] = int.Parse(this.comboBox4.Text);
            Available[1] = int.Parse(this.comboBox5.Text);
            Available[2] = int.Parse(this.comboBox6.Text);
            this.MainAvailablelistView.Items.Clear();
            DJMainForm mainForm = new DJMainForm();
            mainForm.fillListView(MainAvailablelistView,Available);
            //this.Close();
            //mainForm.ShowDialog();
            button1.Enabled = false;
            MessageBox.Show("可利用资源初始化成功！");
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Main_FORM zhucaidan = new Main_FORM();
            this.Hide();
            zhucaidan.Show();
            
        }

        //进程申请资源
        private void ApplyResourcebutton_Click(object sender, EventArgs e)
        {
            Progress pro = new Progress();//创建新进程
            for (int i = 0; i < this.progressNumber; i++)
            {
                if (allProgress[i].Name.Equals (this.comboBoxProgressName.SelectedItem))
                {
                    pro = this.allProgress[i];
                    pro.Request[0] = int.Parse(this.comboBox1.Text);
                    pro.Request[1] = int.Parse(this.comboBox2.Text);
                    pro.Request[2] = int.Parse(this.comboBox3.Text);
                    temp = i;
                    break;
                }
            }

            if (checkApplyResNeed(pro))//pro.Request[i]<=pro.Need[i],进程申请资源数小于其需求数
            {
                if (checkApplyResAvail(pro))//pro.Request[i]<=pro.Available[i],进程申请资源数小于资源可利用资源数
                {
                    DeadLockJiance bankfrm = new DeadLockJiance(this);//创建新的副窗体
                    copyto(this.allProgress, DeadLockJiance.allProgress);//创建进程副本
                    DeadLockJiance.progressNumber = this.progressNumber;//向副窗体传递进程数目
                    this.Available.CopyTo(DeadLockJiance.Available, 0);//向父窗体传递目前系统可利用资源数目
                    bankfrm.temp = this.temp;//传递给副本申请资源的进程号
                    bankfrm.Show();//显示副窗体
                }
                else
                {
                    //置进程申请资源的数目为0
                    pro.Request[0] = 0;
                    pro.Request[1] = 0;
                    pro.Request[2] = 0;
                    MessageBox.Show("此进程请求资源数大于系统目前可用资源数!","申请资源错误");
                }
            }
            else
            {
                //置进程申请资源的数目为0
                pro.Request[0] = 0;
                pro.Request[1] = 0;
                pro.Request[2] = 0;
                MessageBox.Show("此进程请求资源数大于其需求数!", "申请资源错误");
            }
        }

        //添加新进程
        private void AddProgressButton_Click_1(object sender, EventArgs e)
        {
            //若用户在窗体上的textbox中没有输入内容，默认进程名
            if (this.textBoxProgressName.Text == "")
            {
                //默认进程名
                this.textBoxProgressName.Text = "进程" + this.progressNumber.ToString();
            }
            
            //置进程名为用户在窗体上的textbox中输入的内容
            progress.Name = this.textBoxProgressName.Text;

            //新进程的进程名是否与原有的进程重名
            if (nameUnique())//新进程的进程名与原有的进程不重名
            {
                //创建新进程
                allProgress[this.progressNumber] = new Progress();
                //设置进程名为用户输入的进程名
                allProgress[this.progressNumber].Name = progress.Name;
                //设置进程最大可需1类资源数目
                allProgress[this.progressNumber].Max[0] = int.Parse(this.comboBoxFirstReource.Text);
                //设置进程最大可需2类资源数目
                allProgress[this.progressNumber].Max[1] = int.Parse(this.comboBoxSecondReource.Text);
                //设置进程最大可需3类资源数目
                allProgress[this.progressNumber].Max[2] = int.Parse(this.comboBoxThirdReource.Text);
                //置设置进程目前还需资源数目初始值等于最大可需求资源数目
                allProgress[this.progressNumber].Max.CopyTo(allProgress[this.progressNumber].Need, 0);

                //将进程信息填充到窗体的listview控件中
                fillListView(progress, this.MainMaxlistView, allProgress[this.progressNumber].Max);
                fillListView(this.MainNeedlistView, allProgress[this.progressNumber].Need);
                fillListView(this.MainAllocationlistView, allProgress[this.progressNumber].Allocation);
                //将进程名添加入申请资源时用户需选择的进程名
                this.comboBoxProgressName.Items.AddRange(new object[] { progress.Name });
                //进程数加1
                this.progressNumber++;
                //窗体上显示的进程数加1
                this.labelProgressnumber.Text = this.progressNumber.ToString();
            }
            else//新进程的进程名与原有的进程重名
            {
                MessageBox.Show("已有这个进程名，请改一下进程名使其是唯一的!", "创建进程错误");
            }

            this.comboBoxProgressName.SelectedIndex = 0;
            this.textBoxProgressName.Text = "";
        }

        /// <summary>
        /// 判断进程名是否唯一，若唯一则返回true，否则返回false
        /// </summary>
        /// <returns></returns>
        public bool nameUnique()
        {
            for (int i = 0; i < this.progressNumber; i++)
            {
                if (allProgress[i].Name == progress.Name) return false;
            }
            return true;
        }

        /// <summary>
        /// 填充ListView控件
        /// </summary>
        /// <param name="listView1"></param>
        /// <param name="a"></param>
        public void fillListView(ListView listView1, int[] a)
        {
            string[] b = new string[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i].ToString();
            }
            //创建ListViewItem对象，用数组b填充
            ListViewItem listViewItem1 = new ListViewItem(b);
            //将创建的ListViewItem对象添加到ListView中
            listView1.Items.Add(listViewItem1);
        }

        /// <summary>
        /// 填充ListView控件，此控件中首列是进程名
        /// </summary>
        /// <param name="progress1"></param>
        /// <param name="listView1"></param>
        /// <param name="a"></param>
        public void fillListView(Progress progress1, ListView listView1, int[] a)
        {
            string[] b = new string[4];
            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    b[i] = progress1.Name;
                }
                else
                {
                    b[i] = a[i - 1].ToString();
                }
            }
            //创建ListViewItem对象，用数组b填充
            ListViewItem listViewItem1 = new ListViewItem(b);
            //将创建的ListViewItem对象添加到ListView中
            listView1.Items.Add(listViewItem1);
        }

        /// <summary>
        /// 更新ListView控件的第temp个项目
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="listView"></param>
        /// <param name="a"></param>
        public void updateListView(int temp, ListView listView, int[] a)
        {
            string[] b = new string[3];

            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i].ToString();
            }
            //更新listview中第temp个项目的值
            listView.Items[temp] = new ListViewItem(b);
        }

        /// <summary>
        /// 更新ListView控件的第0个项目，用来更新窗体上显示的系统可利用资源数目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public void updateListView(ListView listView, int[] a)
        {
            string[] b = new string[3];

            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i].ToString();
            }
            //更新listview中第0个项目的值
            listView.Items[0] = new ListViewItem(b);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.comboBoxFirstReource.SelectedIndex = 0;
            this.comboBoxSecondReource.SelectedIndex = 0;
            this.comboBoxThirdReource.SelectedIndex = 0;
            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;
            this.comboBox3.SelectedIndex = 0;
            this.comboBox4.SelectedIndex = 0;
            this.comboBox5.SelectedIndex = 0;
            this.comboBox6.SelectedIndex = 0;

            //显示资源目前可利用数目
            fillListView(this.MainAvailablelistView, this.Available);
        }

        /// <summary>
        /// 检查进程申请的资源数目是否小于其需求数目，若小于则返回true
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool checkApplyResNeed(Progress p)
        {
            for (int i = 0; i < 3; i++)
            {
                if (p.Request[i] > p.Need[i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 检查进程申请的资源数目是否小于可利用资源数目，若小于则返回true
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool checkApplyResAvail(Progress p)
        {
            for (int i = 0; i < 3; i++)
            {
                if (p.Request[i] > this.Available[i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 将进程数组a中的数据复制到进程数组b中
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void copyto(Progress[] a, Progress[] b)
        {
            for (int i = 0; i < this.progressNumber; i++)
            {
                b[i] = new Progress();
                b[i].Name = a[i].Name;
                a[i].Max.CopyTo(b[i].Max, 0);
                a[i].Need.CopyTo(b[i].Need, 0);
                a[i].Request.CopyTo(b[i].Request, 0);
                a[i].Allocation.CopyTo(b[i].Allocation, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeadLockItem MainForm = new DeadLockItem();
            this.Hide();
            MainForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
