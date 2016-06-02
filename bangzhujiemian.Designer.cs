namespace ProcessSimulation
{
    partial class bangzhu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bangzhu));
            this.bangzhuzt = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bang1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bangzhuzt
            // 
            this.bangzhuzt.AutoSize = true;
            this.bangzhuzt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bangzhuzt.Font = new System.Drawing.Font("隶书", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bangzhuzt.Location = new System.Drawing.Point(299, 24);
            this.bangzhuzt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bangzhuzt.Name = "bangzhuzt";
            this.bangzhuzt.Size = new System.Drawing.Size(89, 35);
            this.bangzhuzt.TabIndex = 0;
            this.bangzhuzt.Text = "帮助";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "5个模块的具体内容：",
            "（1）进程控制模块：进程的创建（可以分为自动创建、手动创建）、进程的撤销、进程状态的",
            "     变化、进程间的祖先关系、进程对各类资源的使用情况等。",
            "（2）进程调度模块：需要实现先来先服务、短作业优先、多级反馈队列、时间片轮转、高响应",
            "     比调度算法。",
            "（3）进程同步模块：编写生产者-消费者问题。",
            "（4）进程通信模块：实现共享内存、消息队列和管道通信三种通信方式。",
            "（5）死锁模块：实现死锁避免，死锁预防和死锁检测功能。 "});
            this.listBox1.Location = new System.Drawing.Point(34, 97);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(634, 212);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bang1
            // 
            this.bang1.BackColor = System.Drawing.SystemColors.Info;
            this.bang1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bang1.Location = new System.Drawing.Point(539, 334);
            this.bang1.Margin = new System.Windows.Forms.Padding(2);
            this.bang1.Name = "bang1";
            this.bang1.Size = new System.Drawing.Size(95, 36);
            this.bang1.TabIndex = 2;
            this.bang1.Text = "返回";
            this.bang1.UseVisualStyleBackColor = false;
            this.bang1.Click += new System.EventHandler(this.bang1_Click);
            // 
            // bangzhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(699, 404);
            this.Controls.Add(this.bang1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bangzhuzt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "bangzhu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帮助";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bangzhu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bangzhuzt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bang1;
    }
}