using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace ProcessSimulation
{
    class UiDisplay
    {
        /// <summary>
        /// 初始化各作业的Lable并摆放在每一行的开始位置,返回下一组的其实坐标
        /// 如：FCFS: A..........
        ///           B..........
        ///           C..........
        ///     SRT:  A..........
        /// </summary>
        /// <param name="pane1">控件容器</param>
        /// <param name="workList">作业集合</param>
        /// <param name="headstring">标题，如FCFS\SRT\SPN等</param>
        /// <param name="p">起始坐标</param>
        private void SetLableOfWork(ref Panel pane1, ref WorkCollection workList, string headstring, ref Point p)
        {
            Label HeadLable = new Label();
            HeadLable.Text = headstring;
            HeadLable.AutoSize = true;
            pane1.Controls.Add(HeadLable);
            HeadLable.Location = p;
            //摆放各作业的Lable
            int i = 0;
            int x = p.X + HeadLable.Width + 5;
            int y = p.Y;
            foreach (WorkObject work in workList)
            {
                Label myLable = new Label();
                myLable.Name = "myLable" + i.ToString();
                myLable.Text = work.Name;
                myLable.AutoSize = true;
                pane1.Controls.Add(myLable);
                myLable.Location = new Point(x, y);
                y += 25;
                i++;
            }
            p.X = x - HeadLable.Width - 5;
            p.Y = y;
        }
        public void SetLableOfALLWork(ref Panel panel1, ref WorkCollection workList, Point p)
        {
            SetLableOfWork(ref panel1, ref workList, "先来先服务: ", ref p);
            SetLableOfWork(ref panel1, ref workList, "最短进程优先:", ref p);
            SetLableOfWork(ref panel1, ref workList, "时间片轮转:", ref p);
            SetLableOfWork(ref panel1, ref workList, "最高响应比:", ref p);
        }
        public void SetButtonStyle(ref Button button1)
        {
            button1.BackColor = Color.Blue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Width = 0;
            button1.Height = 12;
            button1.Enabled = true;
        }
        public void AddButton(ref Panel panel1,ref Button myButton ,Point p)
        {
            myButton = new Button();
            SetButtonStyle(ref myButton);
            panel1.Controls.Add(myButton);
            myButton.Location = p;

        }
        public void AddButtonWidth(ref Button button1, int growth)
        {
            //button1.Width+=
        }
    }
}
