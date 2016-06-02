namespace ProcessSimulation
{
    partial class shuoming
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shuoming));
            this.shuo1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shuo1
            // 
            this.shuo1.AutoSize = true;
            this.shuo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.shuo1.Font = new System.Drawing.Font("隶书", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.shuo1.Location = new System.Drawing.Point(247, 37);
            this.shuo1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shuo1.Name = "shuo1";
            this.shuo1.Size = new System.Drawing.Size(163, 35);
            this.shuo1.TabIndex = 0;
            this.shuo1.Text = "系统说明";
            this.shuo1.Click += new System.EventHandler(this.shuo1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "  本系统的设计是为了更好的辅助教师教学，提升教学效果。同时,也可以让学",
            "生能更好的理解教学内容,帮助学生建立进程管理部分的整体概念，提高学习",
            "效率。具体来说,本系统将会实现以下目标：",
            "（1）针对进程的创建与注销、进程调度、进程同步、进程通信、死锁的避免",
            "   、进程间祖先关系进行展示。",
            "（2）实现系统中各个数据的替换，方便教学举例。",
            "（3）系统具有安全性、可靠性、稳定性、实用性。"});
            this.listBox1.Location = new System.Drawing.Point(40, 86);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(580, 276);
            this.listBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(516, 379);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shuoming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(664, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.shuo1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "shuoming";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统说明";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.shuoming_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shuo1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}