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
    public partial class Form2 : Form
    {
        private string path = Environment.CurrentDirectory + @"\data.txt";
        private WorkCollection workListLocal;
        public Form2(ref WorkCollection workList)
        {
            InitializeComponent();
            workListLocal = workList;//将父窗体传过来的对象引用在本地创建副本
            InitGridViewData();//Init dataGridView data which is save in txt file
            toolTip1.ToolTipTitle = "提示";
            toolTip1.SetToolTip(this.button2,"如果要保存数据作为下次运行的默认数据，请点击保存默认按钮\n如果不想保存数据，直接按确认按钮");
            toolTip1.SetToolTip(this.button1, "保存数据可作为下次运行的默认数据");
        }
        /// <summary>
        /// 初始化dataGridView数据
        /// </summary>
        private void InitGridViewData()
        {
            BindingSource bs = new BindingSource();
            foreach (object item in workListLocal)
            {
                bs.Add(item);
            }
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = bs;
            dataGridView1.AutoGenerateColumns = false;//一定要加这句，要不然没法移除列
            dataGridView1.Columns.Remove("BeginTime");
            dataGridView1.Columns.Remove("EndTime");
            dataGridView1.Columns.Remove("ZhouZhuan");
            dataGridView1.Columns.Remove("BiLi");
            dataGridView1.Columns.Remove("isSetup");
            dataGridView1.Columns.Remove("isWaiting");
            dataGridView1.Columns.Remove("isRunning");
            dataGridView1.Columns.Remove("isEnd");
            dataGridView1.Columns.Remove("HaveRunTime");

            dataGridView1.Columns[2].HeaderText = "作业名称";
            dataGridView1.Columns[3].HeaderText = "到达时间";
            dataGridView1.Columns[4].HeaderText = "服务时间";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].ReadOnly = true;
        }
        /// <summary>
        /// 保存数据到TXT中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ReadAndWriteTXT rw = new ReadAndWriteTXT(path,System.IO.FileMode.Create);
            string temp=null;
            for(int i=0;i<dataGridView1.RowCount-1;i++)
            {
                for (int j = 1; j < dataGridView1.Rows[i].Cells.Count;j++ )
                {
                    if (j == 1)
                        temp += dataGridView1.Rows[i].Cells[j].Value;
                    else 
                        temp += "-"+dataGridView1.Rows[i].Cells[j].Value;
                }
                temp += System.Environment.NewLine;
            }
            rw.WriteTXT(temp);
            MessageBox.Show("数据保存成功");
        }
        /// <summary>
        /// 每当产生新行时，设置其默认值，
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            int count = dataGridView1.RowCount;
            //ID
            dataGridView1.Rows[count - 1].Cells[1].Value = count - 1;
            //Name
            dataGridView1.Rows[count - 1].Cells[2].Value ="<enter name>";
            //Arrival Time
            dataGridView1.Rows[count - 1].Cells[3].Value =0;
            //Sever Time
            dataGridView1.Rows[count - 1].Cells[4].Value =0;
        }
        /// <summary>
        /// 保存作业信息到WordCollection对象集合中去，然后关闭设置参数的子窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //save process to the object of WorkCollection
            workListLocal.dataList.Clear();
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                WorkObject wo = new WorkObject(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value),
                    dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value),
                    Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value));
                workListLocal.dataList.Add(wo);
            }
            //Close form2
            this.Close();
        }
        /// <summary>
        /// 删除作业
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
        }
        /// <summary>
        /// 移除行后重新设置ID号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                dataGridView1.Rows[i].Cells[1].Value = i;
        }
    }
}
