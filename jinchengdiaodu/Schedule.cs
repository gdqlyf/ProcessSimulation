using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
namespace ProcessSimulation
{
    class Schedule
    {

        /// <summary>
        /// 最短进程优先SPN，选出未运行的作业的最短进程
        /// </summary>
        /// <param name="workList"></param>
        /// <returns></returns>
        public WorkObject FecthWorkForSPN(ref WorkCollection workList)
        {
            if (workList.Count == 0)
                return null;
            WorkObject minwork = new WorkObject();
            foreach (WorkObject work in workList)
            {
                if (!work.isEnd)
                {
                    minwork = work;//找到第一个未完成的作业
                    break;
                }
            }
            foreach (WorkObject work in workList)
            {
                if (!work.isEnd && work.ServerTime < minwork.ServerTime)
                {
                    minwork=work;
                }
            }

            return minwork;
        }
        #region//先到先服务
        /// <summary>
        /// 从队列中取最先到达的任务
        /// </summary>
        /// <param name="q"></param>
        /// <returns></returns>
        public WorkObject FecthWork(ref Queue q)
        {
            WorkObject work = (WorkObject)null;
            if (q.Count != 0)
            {
                work = (WorkObject)q.Dequeue();
                work.isSetup = false;
                work.isWaiting = true;
            }
            return work;
        }
        /// <summary>
        /// 作业运行的相关操作
        /// </summary>
        /// <param name="growthButton"></param>
        public void WorkRun(ref WorkObject CurrentWork,int setupTime)
        {
            //运行任务 
            CurrentWork.isSetup = true;
            CurrentWork.BeginTime = setupTime;
            CurrentWork.isRunning = true;
            CurrentWork.isWaiting = false;
        }
        /// <summary>
        /// 作业结束时执行
        /// </summary>
        public void workEnd(ref WorkObject CurrentWork,int setupTime)
        {
            CurrentWork.isRunning = false;
            CurrentWork.isEnd = true;
            CurrentWork.EndTime = setupTime;
            CurrentWork.ZhouZhuan = setupTime - CurrentWork.ArrivalTime;
            CurrentWork.BiLi = CurrentWork.ZhouZhuan / CurrentWork.ServerTime;
            CurrentWork = (WorkObject)null;
        }
        #endregion
        #region//最短剩余时间优先
        public WorkObject FecthWorkForSPT(ref WorkCollection workList)
        {
            if (workList.Count == 0)
                return null;
            WorkObject minwork= workList[0];
            foreach (WorkObject work in workList)
            {
                if ((work.ServerTime - work.HaveRunTime )< (minwork.ServerTime - minwork.HaveRunTime))
                    minwork = work;
            }
            return minwork;
        }
        /// <summary>
        /// 最短剩余时间优先，作业运行的相关操作
        /// 此方法没有设置起始时间，只有当作业第一次启动时才设其实时间
        /// 当isSetup为false时表示还没有启动过，之后isSetup为true
        /// </summary>
        /// <param name="growthButton"></param>
        public void WorkRunForSPT(ref WorkObject CurrentWork, int setupTime)
        {
            //运行任务 
            CurrentWork.isSetup = true;
            CurrentWork.isRunning = true;
            CurrentWork.isWaiting = false;
        }
        /// <summary>
        /// 最短剩余时间优先，作业被抢占时保存当前作业的相关操作
        /// </summary>
        /// <param name="CurrentWork"></param>
        /// <param name="setupTime"></param>
        /// <param name="setupTime">此次运行的开始时间</param>
        public void SaveCurrentWorkForSPT(ref WorkObject CurrentWork)
        {
            CurrentWork.isRunning = false;
            CurrentWork.isWaiting = true;
        }
        /// <summary>
        /// 最短剩余时间优先，作业结束时的相关操作
        /// </summary>
        /// <param name="CurrentWork"></param>
        /// <param name="setupTime"></param>
        public void WorkEndForSPT(ref WorkCollection wcSPT, ref WorkObject CurrentWork, int setupTime)
        {
            CurrentWork.isRunning = false;
            CurrentWork.isWaiting = false;
            CurrentWork.isEnd = true;
            CurrentWork.EndTime = setupTime;
            CurrentWork.ZhouZhuan = CurrentWork.EndTime - CurrentWork.ArrivalTime;
            CurrentWork.BiLi = CurrentWork.ZhouZhuan / CurrentWork.ServerTime;
            wcSPT.dataList.Remove(CurrentWork);
            CurrentWork = (WorkObject)null;
        }
        #endregion
        #region//最高响应比优先
        public WorkObject FecthWorkForHRRN(ref WorkCollection wcRunning,int setupTime)
        {
            if (wcRunning.Count == 0)
                return null;
            WorkObject maxwork=wcRunning[0];
            //响应比=（等待时间+服务时间）/服务时间
            float R=(setupTime-maxwork.ArrivalTime+maxwork.ServerTime)/maxwork.ServerTime;
            float each;
            foreach (WorkObject work in wcRunning)
            {
                each=(setupTime-work.ArrivalTime+work.ServerTime)/work.ServerTime;
                if (each > R)
                    maxwork = work;
            }
            return maxwork;
        }
        public void workEndForHRRN(ref WorkCollection wcRunning,ref WorkObject CurrentWork,int setupTime)
        {
            CurrentWork.isRunning = false;
            CurrentWork.isWaiting = false;
            CurrentWork.isEnd = true;
            CurrentWork.EndTime = setupTime;
            CurrentWork.ZhouZhuan = CurrentWork.EndTime - CurrentWork.ArrivalTime;
            CurrentWork.BiLi = CurrentWork.ZhouZhuan / CurrentWork.ServerTime;
            wcRunning.dataList.Remove(CurrentWork);
            CurrentWork = (WorkObject)null;
        }
        #endregion
        /// <summary>
        /// 求平均周转时间
        /// </summary>
        /// <param name="wc"></param>
        /// <returns></returns>
        public float averageOfZhouZhuan(ref WorkCollection wc)
        {
            float total = 0;
            foreach (WorkObject work in wc)
            {
                total += work.ZhouZhuan;
            }
            return total / wc.Count;
        }
        /// <summary>
        /// 求平均带权周转时间
        /// </summary>
        /// <param name="wc"></param>
        /// <returns></returns>
        public float averageOfZhouZhuan1(ref WorkCollection wc)
        {
            float total = 0;
            foreach (WorkObject work in wc)
            {
                total += work.BiLi;
            }
            return total / wc.Count;
        }
    }
}