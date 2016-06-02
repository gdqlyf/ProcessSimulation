namespace ProcessSimulation
{
    partial class neicungongxiang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(neicungongxiang));
            this.fasongduan = new System.Windows.Forms.TextBox();
            this.gongxiangneicun = new System.Windows.Forms.TextBox();
            this.jieshouduan = new System.Windows.Forms.TextBox();
            this.gongxiang1 = new System.Windows.Forms.Label();
            this.gongxiang2 = new System.Windows.Forms.Label();
            this.gongxiang3 = new System.Windows.Forms.Label();
            this.anniu1 = new System.Windows.Forms.Button();
            this.anniu2 = new System.Windows.Forms.Button();
            this.anniu3 = new System.Windows.Forms.Button();
            this.gongxiangbiaoti = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fasongduan
            // 
            this.fasongduan.Location = new System.Drawing.Point(30, 183);
            this.fasongduan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fasongduan.Name = "fasongduan";
            this.fasongduan.Size = new System.Drawing.Size(228, 21);
            this.fasongduan.TabIndex = 0;
            this.fasongduan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gongxiangneicun
            // 
            this.gongxiangneicun.Location = new System.Drawing.Point(311, 183);
            this.gongxiangneicun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gongxiangneicun.Name = "gongxiangneicun";
            this.gongxiangneicun.Size = new System.Drawing.Size(228, 21);
            this.gongxiangneicun.TabIndex = 1;
            // 
            // jieshouduan
            // 
            this.jieshouduan.Location = new System.Drawing.Point(590, 183);
            this.jieshouduan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jieshouduan.Name = "jieshouduan";
            this.jieshouduan.Size = new System.Drawing.Size(228, 21);
            this.jieshouduan.TabIndex = 2;
            // 
            // gongxiang1
            // 
            this.gongxiang1.AutoSize = true;
            this.gongxiang1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gongxiang1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gongxiang1.Location = new System.Drawing.Point(112, 130);
            this.gongxiang1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gongxiang1.Name = "gongxiang1";
            this.gongxiang1.Size = new System.Drawing.Size(72, 20);
            this.gongxiang1.TabIndex = 3;
            this.gongxiang1.Text = "发送端";
            // 
            // gongxiang2
            // 
            this.gongxiang2.AutoSize = true;
            this.gongxiang2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gongxiang2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gongxiang2.Location = new System.Drawing.Point(379, 130);
            this.gongxiang2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gongxiang2.Name = "gongxiang2";
            this.gongxiang2.Size = new System.Drawing.Size(93, 20);
            this.gongxiang2.TabIndex = 4;
            this.gongxiang2.Text = "共享内存";
            this.gongxiang2.Click += new System.EventHandler(this.gongxiang2_Click);
            // 
            // gongxiang3
            // 
            this.gongxiang3.AutoSize = true;
            this.gongxiang3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gongxiang3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gongxiang3.Location = new System.Drawing.Point(660, 130);
            this.gongxiang3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gongxiang3.Name = "gongxiang3";
            this.gongxiang3.Size = new System.Drawing.Size(72, 20);
            this.gongxiang3.TabIndex = 5;
            this.gongxiang3.Text = "接收端";
            // 
            // anniu1
            // 
            this.anniu1.BackColor = System.Drawing.SystemColors.Info;
            this.anniu1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.anniu1.Location = new System.Drawing.Point(89, 243);
            this.anniu1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.anniu1.Name = "anniu1";
            this.anniu1.Size = new System.Drawing.Size(128, 32);
            this.anniu1.TabIndex = 6;
            this.anniu1.Text = "发送到共享内存";
            this.anniu1.UseVisualStyleBackColor = false;
            this.anniu1.Click += new System.EventHandler(this.anniu1_Click);
            // 
            // anniu2
            // 
            this.anniu2.BackColor = System.Drawing.SystemColors.Info;
            this.anniu2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.anniu2.Location = new System.Drawing.Point(650, 243);
            this.anniu2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.anniu2.Name = "anniu2";
            this.anniu2.Size = new System.Drawing.Size(125, 32);
            this.anniu2.TabIndex = 7;
            this.anniu2.Text = "接收内存映像";
            this.anniu2.UseVisualStyleBackColor = false;
            this.anniu2.Click += new System.EventHandler(this.anniu2_Click);
            // 
            // anniu3
            // 
            this.anniu3.BackColor = System.Drawing.SystemColors.Info;
            this.anniu3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.anniu3.Location = new System.Drawing.Point(368, 243);
            this.anniu3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.anniu3.Name = "anniu3";
            this.anniu3.Size = new System.Drawing.Size(128, 32);
            this.anniu3.TabIndex = 8;
            this.anniu3.Text = "清空";
            this.anniu3.UseVisualStyleBackColor = false;
            this.anniu3.Click += new System.EventHandler(this.anniu3_Click);
            // 
            // gongxiangbiaoti
            // 
            this.gongxiangbiaoti.AutoSize = true;
            this.gongxiangbiaoti.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gongxiangbiaoti.Font = new System.Drawing.Font("隶书", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gongxiangbiaoti.Location = new System.Drawing.Point(363, 32);
            this.gongxiangbiaoti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gongxiangbiaoti.Name = "gongxiangbiaoti";
            this.gongxiangbiaoti.Size = new System.Drawing.Size(133, 30);
            this.gongxiangbiaoti.TabIndex = 9;
            this.gongxiangbiaoti.Text = "内存共享";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(686, 324);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // neicungongxiang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(829, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gongxiangbiaoti);
            this.Controls.Add(this.anniu3);
            this.Controls.Add(this.anniu2);
            this.Controls.Add(this.anniu1);
            this.Controls.Add(this.gongxiang3);
            this.Controls.Add(this.gongxiang2);
            this.Controls.Add(this.gongxiang1);
            this.Controls.Add(this.jieshouduan);
            this.Controls.Add(this.gongxiangneicun);
            this.Controls.Add(this.fasongduan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "neicungongxiang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "内存共享";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fasongduan;
        private System.Windows.Forms.TextBox gongxiangneicun;
        private System.Windows.Forms.TextBox jieshouduan;
        private System.Windows.Forms.Label gongxiang1;
        private System.Windows.Forms.Label gongxiang2;
        private System.Windows.Forms.Label gongxiang3;
        private System.Windows.Forms.Button anniu1;
        private System.Windows.Forms.Button anniu2;
        private System.Windows.Forms.Button anniu3;
        private System.Windows.Forms.Label gongxiangbiaoti;
        private System.Windows.Forms.Button button1;
    }
}