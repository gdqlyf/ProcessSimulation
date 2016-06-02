using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace ProcessSimulation
{
    public class WorkObject
    {
        private int id;
        private string name;
        private int arrivaltime;
        private int severtime;
        private int begintime;
        private int endtime;
        private int zhouzhuan;//周转时间
        private float bili;//周转时间/服务时间
        private bool isrunning = false;//标识当前作业是否运行之中(只有占用CPU时才为true)
        private bool issetup = false;//标识当前作业是否启动,只有曾经运行过该值就为true即使被抢占了
        private bool iswaiting = false;//标识是否在等待运行
        private bool isend = false;
        private int haverunTime;//实际已经占用cpu的时间
        public int ID
        {
            set { this.id = value; }
            get { return this.id; }
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public int ArrivalTime
        {
            set { this.arrivaltime = value; }
            get { return this.arrivaltime; }
        }
        public int ServerTime
        {
            set { this.severtime = value; }
            get { return this.severtime; }
        }
        public int BeginTime
        {
            set { this.begintime = value; }
            get { return this.begintime; }
        }
        public int EndTime
        {
            set { this.endtime = value; }
            get { return this.endtime; }
        }
        public int ZhouZhuan
        {
            set { this.zhouzhuan = value; }
            get { return this.zhouzhuan; }
        }
        public float BiLi
        {
            set { this.bili = value; }
            get { return this.bili; }
        }
        public bool isRunning
        {
            set { this.isrunning = value; }
            get { return this.isrunning; }
        }
        public bool isSetup
        {
            set { this.issetup = value; }
            get { return this.issetup; }
        }
        public bool isWaiting
        {
            set { this.iswaiting = value; }
            get { return this.iswaiting; }
        }
        public bool isEnd
        {
            set { this.isend = value; }
            get { return this.isend; }
        }
        public int HaveRunTime
        {
            set { this.haverunTime = value; }
            get { return this.haverunTime; }
        }
        public WorkObject(int _id, string _name, int ar, int sev)
        {
            this.id = _id;
            this.name = _name;
            this.arrivaltime = ar;
            this.severtime = sev;
        }
        public WorkObject()
        {
        }
        /// <summary>
        /// 浅拷贝
        /// </summary>
        /// <returns></returns>
        public WorkObject Copy()
        {
            return this.MemberwiseClone() as WorkObject;
        }
    }
}
