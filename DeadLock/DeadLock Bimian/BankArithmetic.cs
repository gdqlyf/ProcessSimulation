using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessSimulation
{
    public class Progress
    {
        private string name;//进程名，是唯一的，任两个进程不能重名
        public int[] Max = new int[3];//进程最大可申请的各种资源的数目
        public int[] Allocation = new int[3];//系统已分配给进程的各种资源的数目
        public int[] Need = new int[3];//进程还需要的各种资源的数目
        public int[] Request = new int[3];//存放进程提出申请各种资源的数目

        public string Name
        {
            get { return name; }//获得进程名
            set { name = value; }//设置进程名
        }

        //不含参数的构造方法，用来创建进程
        public Progress (){}

        /// <summary>
        /// 含3个参数构造方法，name是进程名
        /// m是最大可申请的各种资源的数目数组
        /// a是系统已分配给进程的各种资源的数目数组
        /// n是进程还需要的各种资源的数目数组
        /// </summary>
        /// <param name="name"></param>
        /// <param name="m"></param>
        /// <param name="a"></param>
        /// <param name="n"></param>
        public Progress (string name,int[] m,int[] a,int[] n)
        {
            this.name = name;
            m.CopyTo(Max, 0);
            a.CopyTo(Allocation, 0);
            n.CopyTo(Need, 0);
        }
    }
}
