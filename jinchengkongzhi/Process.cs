using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessSimulation
{
    public partial class Process : Form
    {
        public string name;           //进程名  
        public int need_CPU;          //所需CPU  
        public int need_time;         //估计所需执行时间  
        public int wait_time;         //等待时间              
        public int need_memery;       //所需内存大小  
        public int need_printer;      //所需打印机数量  
        public int more_time;         //还需要执行的时间             
        public int state;             //表示进程的三种状态。。。执行为0、就绪为1、被阻塞等待为2、完成为3  。
        public int rank;              //处于哪个就绪状态1,2,3                     

        public Process(string namePro, int need_CPU, int need_timePro, int need_memeryPro, int need_printerPro, int more_timePro)
        {
            this.name = namePro;
            this.need_CPU = need_CPU;
            this.need_time = need_timePro;
            this.need_memery = need_memeryPro;
            this.need_printer = need_printerPro;
            this.more_time = more_timePro;
        }  

    }
}
