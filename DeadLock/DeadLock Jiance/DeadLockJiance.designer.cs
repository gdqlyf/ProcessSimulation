namespace ProcessSimulation
{
    partial class DeadLockJiance
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeadLockJiance));
            this.listViewMax = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewAlloc = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewNeed = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewAvail = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Maxlable = new System.Windows.Forms.Label();
            this.Allocationlabel = new System.Windows.Forms.Label();
            this.Needlabel = new System.Windows.Forms.Label();
            this.Availablelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewWorkAlloc = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewAlloc2 = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewNeed2 = new System.Windows.Forms.ListView();
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewWork = new System.Windows.Forms.ListView();
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewFinish = new System.Windows.Forms.ListView();
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.run = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewMax
            // 
            this.listViewMax.BackColor = System.Drawing.Color.LavenderBlush;
            this.listViewMax.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewMax.ForeColor = System.Drawing.Color.DarkViolet;
            this.listViewMax.FullRowSelect = true;
            this.listViewMax.GridLines = true;
            this.listViewMax.HideSelection = false;
            this.listViewMax.Location = new System.Drawing.Point(16, 61);
            this.listViewMax.MultiSelect = false;
            this.listViewMax.Name = "listViewMax";
            this.listViewMax.Size = new System.Drawing.Size(246, 121);
            this.listViewMax.TabIndex = 0;
            this.listViewMax.UseCompatibleStateImageBehavior = false;
            this.listViewMax.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "进程";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "1类资源";
            this.columnHeader2.Width = 62;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "2类资源";
            this.columnHeader3.Width = 59;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "3类资源";
            this.columnHeader4.Width = 58;
            // 
            // listViewAlloc
            // 
            this.listViewAlloc.BackColor = System.Drawing.Color.LavenderBlush;
            this.listViewAlloc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listViewAlloc.ForeColor = System.Drawing.Color.DarkViolet;
            this.listViewAlloc.FullRowSelect = true;
            this.listViewAlloc.GridLines = true;
            this.listViewAlloc.HideSelection = false;
            this.listViewAlloc.Location = new System.Drawing.Point(257, 61);
            this.listViewAlloc.MultiSelect = false;
            this.listViewAlloc.Name = "listViewAlloc";
            this.listViewAlloc.Size = new System.Drawing.Size(185, 121);
            this.listViewAlloc.TabIndex = 1;
            this.listViewAlloc.UseCompatibleStateImageBehavior = false;
            this.listViewAlloc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "1类资源";
            this.columnHeader9.Width = 61;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "2类资源";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "3类资源";
            // 
            // listViewNeed
            // 
            this.listViewNeed.BackColor = System.Drawing.Color.LavenderBlush;
            this.listViewNeed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewNeed.ForeColor = System.Drawing.Color.DarkViolet;
            this.listViewNeed.FullRowSelect = true;
            this.listViewNeed.GridLines = true;
            this.listViewNeed.HideSelection = false;
            this.listViewNeed.Location = new System.Drawing.Point(439, 61);
            this.listViewNeed.MultiSelect = false;
            this.listViewNeed.Name = "listViewNeed";
            this.listViewNeed.Size = new System.Drawing.Size(185, 121);
            this.listViewNeed.TabIndex = 2;
            this.listViewNeed.UseCompatibleStateImageBehavior = false;
            this.listViewNeed.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "1类资源";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "2类资源";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "3类资源";
            // 
            // listViewAvail
            // 
            this.listViewAvail.BackColor = System.Drawing.Color.LavenderBlush;
            this.listViewAvail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader12,
            this.columnHeader13});
            this.listViewAvail.ForeColor = System.Drawing.Color.DarkViolet;
            this.listViewAvail.FullRowSelect = true;
            this.listViewAvail.GridLines = true;
            this.listViewAvail.HideSelection = false;
            this.listViewAvail.Location = new System.Drawing.Point(621, 61);
            this.listViewAvail.MultiSelect = false;
            this.listViewAvail.Name = "listViewAvail";
            this.listViewAvail.Size = new System.Drawing.Size(185, 121);
            this.listViewAvail.TabIndex = 3;
            this.listViewAvail.UseCompatibleStateImageBehavior = false;
            this.listViewAvail.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "1类资源";
            this.columnHeader8.Width = 61;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "2类资源";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "3类资源";
            // 
            // Maxlable
            // 
            this.Maxlable.BackColor = System.Drawing.Color.Transparent;
            this.Maxlable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Maxlable.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Maxlable.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Maxlable.Location = new System.Drawing.Point(79, 36);
            this.Maxlable.Name = "Maxlable";
            this.Maxlable.Size = new System.Drawing.Size(183, 22);
            this.Maxlable.TabIndex = 5;
            this.Maxlable.Text = "      Max";
            // 
            // Allocationlabel
            // 
            this.Allocationlabel.BackColor = System.Drawing.Color.Transparent;
            this.Allocationlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Allocationlabel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Allocationlabel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Allocationlabel.Location = new System.Drawing.Point(258, 36);
            this.Allocationlabel.Name = "Allocationlabel";
            this.Allocationlabel.Size = new System.Drawing.Size(184, 22);
            this.Allocationlabel.TabIndex = 6;
            this.Allocationlabel.Text = "   Allocation";
            // 
            // Needlabel
            // 
            this.Needlabel.BackColor = System.Drawing.Color.Transparent;
            this.Needlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Needlabel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Needlabel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Needlabel.Location = new System.Drawing.Point(439, 36);
            this.Needlabel.Name = "Needlabel";
            this.Needlabel.Size = new System.Drawing.Size(185, 22);
            this.Needlabel.TabIndex = 7;
            this.Needlabel.Text = "     Need";
            // 
            // Availablelabel
            // 
            this.Availablelabel.BackColor = System.Drawing.Color.Transparent;
            this.Availablelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Availablelabel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Availablelabel.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Availablelabel.Location = new System.Drawing.Point(620, 36);
            this.Availablelabel.Name = "Availablelabel";
            this.Availablelabel.Size = new System.Drawing.Size(186, 22);
            this.Availablelabel.TabIndex = 8;
            this.Availablelabel.Text = "    Available";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(623, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Work+Allocation";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label2.Location = new System.Drawing.Point(441, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "   Allocation";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(259, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "     Need";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label4.Location = new System.Drawing.Point(80, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "     Work";
            // 
            // listViewWorkAlloc
            // 
            this.listViewWorkAlloc.BackColor = System.Drawing.Color.LavenderBlush;
            this.listViewWorkAlloc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.listViewWorkAlloc.ForeColor = System.Drawing.Color.DarkViolet;
            this.listViewWorkAlloc.GridLines = true;
            this.listViewWorkAlloc.Location = new System.Drawing.Point(623, 67);
            this.listViewWorkAlloc.Name = "listViewWorkAlloc";
            this.listViewWorkAlloc.Size = new System.Drawing.Size(185, 122);
            this.listViewWorkAlloc.TabIndex = 12;
            this.listViewWorkAlloc.UseCompatibleStateImageBehavior = false;
            this.listViewWorkAlloc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "1类资源";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "2类资源";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "3类资源";
            // 
            // listViewAlloc2
            // 
            this.listViewAlloc2.BackColor = System.Drawing.Color.LavenderBlush;
            this.listViewAlloc2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.listViewAlloc2.ForeColor = System.Drawing.Color.DarkViolet;
            this.listViewAlloc2.GridLines = true;
            this.listViewAlloc2.Location = new System.Drawing.Point(441, 67);
            this.listViewAlloc2.Name = "listViewAlloc2";
            this.listViewAlloc2.Size = new System.Drawing.Size(185, 122);
            this.listViewAlloc2.TabIndex = 11;
            this.listViewAlloc2.UseCompatibleStateImageBehavior = false;
            this.listViewAlloc2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "1类资源";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "2类资源";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "3类资源";
            // 
            // listViewNeed2
            // 
            this.listViewNeed2.BackColor = System.Drawing.Color.LavenderBlush;
            this.listViewNeed2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22});
            this.listViewNeed2.ForeColor = System.Drawing.Color.DarkViolet;
            this.listViewNeed2.GridLines = true;
            this.listViewNeed2.Location = new System.Drawing.Point(259, 67);
            this.listViewNeed2.Name = "listViewNeed2";
            this.listViewNeed2.Size = new System.Drawing.Size(185, 122);
            this.listViewNeed2.TabIndex = 10;
            this.listViewNeed2.UseCompatibleStateImageBehavior = false;
            this.listViewNeed2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "1类资源";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "2类资源";
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "3类资源";
            // 
            // listViewWork
            // 
            this.listViewWork.BackColor = System.Drawing.Color.LavenderBlush;
            this.listViewWork.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26});
            this.listViewWork.ForeColor = System.Drawing.Color.DarkViolet;
            this.listViewWork.GridLines = true;
            this.listViewWork.Location = new System.Drawing.Point(15, 67);
            this.listViewWork.Name = "listViewWork";
            this.listViewWork.Size = new System.Drawing.Size(249, 122);
            this.listViewWork.TabIndex = 9;
            this.listViewWork.UseCompatibleStateImageBehavior = false;
            this.listViewWork.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "进程";
            this.columnHeader23.Width = 63;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "1类资源";
            this.columnHeader24.Width = 62;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "2类资源";
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "3类资源";
            // 
            // listViewFinish
            // 
            this.listViewFinish.BackColor = System.Drawing.Color.LavenderBlush;
            this.listViewFinish.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader27});
            this.listViewFinish.ForeColor = System.Drawing.Color.DarkViolet;
            this.listViewFinish.GridLines = true;
            this.listViewFinish.Location = new System.Drawing.Point(803, 67);
            this.listViewFinish.Name = "listViewFinish";
            this.listViewFinish.Size = new System.Drawing.Size(85, 122);
            this.listViewFinish.TabIndex = 17;
            this.listViewFinish.UseCompatibleStateImageBehavior = false;
            this.listViewFinish.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "         ";
            this.columnHeader27.Width = 77;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label5.Location = new System.Drawing.Point(803, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Finish";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Maxlable);
            this.groupBox1.Controls.Add(this.listViewMax);
            this.groupBox1.Controls.Add(this.listViewAlloc);
            this.groupBox1.Controls.Add(this.listViewNeed);
            this.groupBox1.Controls.Add(this.listViewAvail);
            this.groupBox1.Controls.Add(this.Allocationlabel);
            this.groupBox1.Controls.Add(this.Needlabel);
            this.groupBox1.Controls.Add(this.Availablelabel);
            this.groupBox1.Location = new System.Drawing.Point(28, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 198);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "系统假定分配资源";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.run);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listViewWork);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.listViewNeed2);
            this.groupBox2.Controls.Add(this.listViewFinish);
            this.groupBox2.Controls.Add(this.listViewAlloc2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listViewWorkAlloc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(2, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(904, 304);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运行情况";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(396, 252);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(383, 23);
            this.progressBar1.TabIndex = 25;
            // 
            // run
            // 
            this.run.BackColor = System.Drawing.SystemColors.Info;
            this.run.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.run.ForeColor = System.Drawing.Color.Blue;
            this.run.Location = new System.Drawing.Point(128, 252);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(145, 29);
            this.run.TabIndex = 0;
            this.run.Text = "开始运行";
            this.run.UseVisualStyleBackColor = false;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(414, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeadLockJiance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(902, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeadLockJiance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "死锁检测";
            this.Load += new System.EventHandler(this.BankForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewMax;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listViewAlloc;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ListView listViewNeed;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView listViewAvail;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Label Maxlable;
        private System.Windows.Forms.Label Allocationlabel;
        private System.Windows.Forms.Label Needlabel;
        private System.Windows.Forms.Label Availablelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewWorkAlloc;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ListView listViewAlloc2;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ListView listViewNeed2;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ListView listViewWork;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ListView listViewFinish;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

