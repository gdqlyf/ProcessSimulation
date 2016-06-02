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
    public partial class DeadLockBimian : Form
    {

        private bool message = false;//作为找到安全序列的标志
        private Progress progress = new Progress();//创建进程对象
        public static Progress[] allProgress=new Progress[ 50];//主窗体的进程数组副本
        public static int progressNumber;
        public static int[] Available = new int[3];
        public int temp;
        public DBMainForm mainfrm;//声明主窗体对象，用来往主窗体传值
        private SafeXuLie[] safexulie;//存放安全序列，进程名组成

        public DeadLockBimian()
        {
            InitializeComponent();
        }

        public DeadLockBimian(DBMainForm maf)
        {
            InitializeComponent();
            mainfrm = maf;
        }

        //点击窗体上返回按钮
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            //找到安全序列，将数据传给主窗体，并修改主窗体的相应的ListView控件
            if (message)
            {

                DeadLockBimian.Available.CopyTo(this.mainfrm.Available, 0);
                this.mainfrm.copyto(DeadLockBimian.allProgress, this.mainfrm.allProgress);
                this.mainfrm.updateListView(this.mainfrm.MainAvailablelistView, DeadLockBimian.Available);
                this.mainfrm.updateListView(temp, this.mainfrm.MainNeedlistView, DeadLockBimian.allProgress[temp].Need);
                this.mainfrm.updateListView(temp, this.mainfrm.MainAllocationlistView, DeadLockBimian.allProgress[temp].Allocation);
            }

            this.listViewMax.Items[temp].Selected = false ;
            this.listViewNeed.Items[temp].Selected = false ;
            this.listViewAlloc.Items[temp].Selected = false ;

            }
            catch (Exception)
            {

            }

            //关闭副窗体
            this.Close();
            //显示主窗体
            this.mainfrm.Show();
        }

        private void BankForm_Load(object sender, EventArgs e)
        {
            DBMainForm mf1 = new DBMainForm();

            try
            {

            //修改资源分配表
            for (int i = 0; i < DeadLockBimian.progressNumber ; i++)
            {
                mf1.fillListView(DeadLockBimian.allProgress[i], this.listViewMax, DeadLockBimian.allProgress[i].Max);
                if (i == temp)//第temp个进程是当前申请资源的进程
                {
                    for (int j = 0; j < 3; j++)
                    {
                            //修改已分配给进程temp的资源数
                            DeadLockBimian.allProgress[i].Allocation[j] += DeadLockBimian.allProgress[i].Request[j];
                            //修改进程temp还需要的资源数
                            DeadLockBimian.allProgress[i].Need[j] -= DeadLockBimian.allProgress[i].Request[j];
                            //修改分配给进程temp资源后剩余的资源数
                            DeadLockBimian.Available[j] -= DeadLockBimian.allProgress[i].Request[j];
                    }
                    //将已分配给进程temp的资源数显示到窗体上
                    mf1.fillListView(this.listViewAlloc, DeadLockBimian.allProgress[i].Allocation);
                    //将进程temp还需的资源数显示到窗体上
                    mf1.fillListView(this.listViewNeed, DeadLockBimian.allProgress[i].Need);
                }
                else
                {
                    //将已分配给进程i的资源数以及还需的资源数显示到窗体上
                    mf1.fillListView(this.listViewAlloc, DeadLockBimian.allProgress[i].Allocation);
                    mf1.fillListView(this.listViewNeed, DeadLockBimian.allProgress[i].Need);
                }
            }
                //将可用资源数显示到窗体上
                mf1.fillListView(this.listViewAvail , DeadLockBimian.Available);

            for (int i = 0; i < DeadLockBimian.progressNumber; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                        DeadLockBimian.allProgress[i].Request[j] = 0;//将进程的申请资源数组置0
                }
            }

            this.listViewMax.Items[temp].Selected = true;
            this.listViewNeed.Items[temp].Selected = true;
            this.listViewAlloc.Items[temp].Selected = true;


            }
            catch (Exception)
            {

            }

        }

        //点击窗体上检查安全性按钮
        private void SafeButton_Click(object sender, EventArgs e)
        {
            int[] progressQueue = new int[DeadLockBimian.progressNumber];
            this.textBox1.Text = "";
            this.listViewWork.Items.Clear();
            this.listViewNeed2.Items.Clear();
            this.listViewAlloc2.Items.Clear();
            this.listViewWorkAlloc.Items.Clear();
            this.listViewFinish.Items.Clear();

            if (safeSequence(progressQueue))//找到安全序列
            {
                fill(progressQueue);//填充work对应的ListView控件
                for (int i = 0; i < DeadLockBimian.progressNumber ; i++)
                {
                    //填充Need对应的ListView控件
                    this.mainfrm.fillListView(this.listViewNeed2, safexulie[i].need);
                    //填充Allocation对应的ListView控件
                    this.mainfrm.fillListView(this.listViewAlloc2, safexulie[i].allocation);
                    //填充Work+Allocation对应的ListView控件
                    this.mainfrm.fillListView(this.listViewWorkAlloc, safexulie[i].workAllocation);
                    //填充Finish对应的ListView控件
                    this.listViewFinish.Items.Add(new ListViewItem("true")); 
                }
            }
            else
            {
                MessageBox.Show("找不到安全序列,故系统不分配资源!", "安全性错误");
            }

        }

        //安全算法
        public bool safeSequence(int[] progressQueue)
        {
            int t=0;
            int k = 0;
            int[] work = new int[3];
            DeadLockBimian.Available.CopyTo(work, 0);//置Work[i]=Available[i]
            int[] Finish = new int[DeadLockBimian.progressNumber];
            int[] need = new int[3];
            int[] allocation = new int[3];
            safexulie = new SafeXuLie[DeadLockBimian.progressNumber];
            
            //将Finish全部置成false
            for (int i = 0; i < DeadLockBimian.progressNumber; i++)
            {
                Finish[i] = 0;
            }

            for (int i = 0; i < DeadLockBimian.progressNumber; i++)
            {
                if (Finish[i] == 0)
                {
                    DeadLockBimian.allProgress[i].Need.CopyTo(need, 0);//得到进程i的need
                    DeadLockBimian.allProgress[i].Allocation.CopyTo(allocation, 0);//得到进程i的allocation
                    this.safexulie[t] = new SafeXuLie();
                    work.CopyTo(this.safexulie[t].work, 0);
                    DeadLockBimian.allProgress[i].Need.CopyTo(this.safexulie[t].need, 0);
                    DeadLockBimian.allProgress[i].Allocation.CopyTo(this.safexulie[t].allocation, 0);


                    if (Compare(work, need)) //Finish[i]为false且Work[i]>=Need[i]
                    {
                        //当进程i可以获得资源，顺利执行后，释放原来已经分配给它的资源
                        for (int j = 0; j < 3; j++)
                        {
                            work[j] = work[j] + allocation[j];//释放获得的第j个资源
                        }
                        Finish[i] = 1;//置对应的Finish为真
                        progressQueue[k++] = i;//将进程号存放入progressQueue中
                        work.CopyTo(this.safexulie[t++].workAllocation, 0);//获取work+allocation
                        i = -1;
                    }
                }
            }

            if (k == DeadLockBimian.progressNumber)//相等则找到安全序列
            {
                this.message = true;//置message为真
                return true;
            }
            else return false;
        }

        /// <summary>
        /// 比较两个数组的大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public bool Compare(int [] a,int [] b)
        {
            for (int i = 0; i < a.Length ; i++)
            {
                if (a[i]<b[i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 填充listViewWork控件，a是安全序列，b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void fill(int[] a)
        {
            string[] s = new string[4];//创建一个字符串数组，作为创建ListViewItem对象的参数
            for (int i = 0; i < DeadLockBimian .progressNumber; i++)
            {
                s[0] = DeadLockBimian.allProgress[a[i]].Name;//首项是进程名
                this.textBox1.Text += s[0] + "  ";
                for (int j = 1; j < s.Length; j++)
                {
                    s[j] = safexulie[i].work[j-1].ToString();
                }
                ListViewItem lvt = new ListViewItem(s);//创建一个新的ListViewItem对象
                this.listViewWork.Items.Add(lvt);//将创建的ListViewItem添加到ListView控件中
            }
        }

        private void run_Click(object sender, EventArgs e)
        {
            int[] progressQueue = new int[DeadLockBimian.progressNumber];
            this.textBox1.Text = "";
            this.listViewWork.Items.Clear();
            this.listViewNeed2.Items.Clear();
            this.listViewAlloc2.Items.Clear();
            this.listViewWorkAlloc.Items.Clear();
            this.listViewFinish.Items.Clear();

            if (safeSequence(progressQueue))//找到安全序列
            {
                fill(progressQueue);//填充work对应的ListView控件
                for (int i = 0; i < DeadLockBimian.progressNumber; i++)
                {
                    //填充Need对应的ListView控件
                    this.mainfrm.fillListView(this.listViewNeed2, safexulie[i].need);
                    //填充Allocation对应的ListView控件
                    this.mainfrm.fillListView(this.listViewAlloc2, safexulie[i].allocation);
                    //填充Work+Allocation对应的ListView控件
                    this.mainfrm.fillListView(this.listViewWorkAlloc, safexulie[i].workAllocation);
                    //填充Finish对应的ListView控件
                    this.listViewFinish.Items.Add(new ListViewItem("true"));
                }
            }
        }
    }

    public class DBSafeXuLie//填充副窗体的ListView控件时使用
    {
        public int[] work;
        public int[] need;
        public int[] allocation;
        public int[] workAllocation;

        public DBSafeXuLie()
        {
            work = new int[3];
            need = new int[3];
            allocation = new int[3];
            workAllocation = new int[3];
        }
    }

}
