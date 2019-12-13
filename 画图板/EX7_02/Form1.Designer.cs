namespace EX7_02
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnFillEllipse = new System.Windows.Forms.Button();
            this.btnRec = new System.Windows.Forms.Button();
            this.btnFillRec = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLine1 = new System.Windows.Forms.Button();
            this.btnLine2 = new System.Windows.Forms.Button();
            this.btnLine3 = new System.Windows.Forms.Button();
            this.btnLine4 = new System.Windows.Forms.Button();
            this.btnLine5 = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnColorDialog = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(632, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 450);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 450);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Location = new System.Drawing.Point(0, 406);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(632, 22);
            this.statusStrip2.TabIndex = 3;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEraser);
            this.groupBox1.Controls.Add(this.btnFillRec);
            this.groupBox1.Controls.Add(this.btnRec);
            this.groupBox1.Controls.Add(this.btnFillEllipse);
            this.groupBox1.Controls.Add(this.btnEllipse);
            this.groupBox1.Controls.Add(this.btnLine);
            this.groupBox1.Controls.Add(this.btnPencil);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工具";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLine5);
            this.groupBox2.Controls.Add(this.btnLine4);
            this.groupBox2.Controls.Add(this.btnLine3);
            this.groupBox2.Controls.Add(this.btnLine2);
            this.groupBox2.Controls.Add(this.btnLine1);
            this.groupBox2.Location = new System.Drawing.Point(3, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "宽度";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBlue);
            this.groupBox3.Controls.Add(this.btnColorDialog);
            this.groupBox3.Controls.Add(this.btnBlack);
            this.groupBox3.Controls.Add(this.btnGreen);
            this.groupBox3.Controls.Add(this.btnYellow);
            this.groupBox3.Controls.Add(this.btnRed);
            this.groupBox3.Controls.Add(this.btnControl);
            this.groupBox3.Location = new System.Drawing.Point(5, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 134);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "颜色";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnPencil
            // 
            this.btnPencil.Image = ((System.Drawing.Image)(resources.GetObject("btnPencil.Image")));
            this.btnPencil.Location = new System.Drawing.Point(16, 24);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(30, 23);
            this.btnPencil.TabIndex = 0;
            this.btnPencil.Tag = "0";
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnLine
            // 
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.Location = new System.Drawing.Point(63, 24);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(30, 23);
            this.btnLine.TabIndex = 1;
            this.btnLine.Tag = "1";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnEllipse.Image")));
            this.btnEllipse.Location = new System.Drawing.Point(110, 24);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(30, 23);
            this.btnEllipse.TabIndex = 2;
            this.btnEllipse.Tag = "2";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnFillEllipse
            // 
            this.btnFillEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnFillEllipse.Image")));
            this.btnFillEllipse.Location = new System.Drawing.Point(16, 55);
            this.btnFillEllipse.Name = "btnFillEllipse";
            this.btnFillEllipse.Size = new System.Drawing.Size(30, 23);
            this.btnFillEllipse.TabIndex = 3;
            this.btnFillEllipse.Tag = "3";
            this.btnFillEllipse.UseVisualStyleBackColor = true;
            this.btnFillEllipse.Click += new System.EventHandler(this.btnFillEllipse_Click);
            // 
            // btnRec
            // 
            this.btnRec.Image = ((System.Drawing.Image)(resources.GetObject("btnRec.Image")));
            this.btnRec.Location = new System.Drawing.Point(63, 55);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(30, 23);
            this.btnRec.TabIndex = 4;
            this.btnRec.Tag = "4";
            this.btnRec.UseVisualStyleBackColor = true;
            this.btnRec.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnFillRec
            // 
            this.btnFillRec.Image = ((System.Drawing.Image)(resources.GetObject("btnFillRec.Image")));
            this.btnFillRec.Location = new System.Drawing.Point(110, 55);
            this.btnFillRec.Name = "btnFillRec";
            this.btnFillRec.Size = new System.Drawing.Size(30, 23);
            this.btnFillRec.TabIndex = 5;
            this.btnFillRec.Tag = "5";
            this.btnFillRec.UseVisualStyleBackColor = true;
            this.btnFillRec.Click += new System.EventHandler(this.btnFillRec_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.ForeColor = System.Drawing.Color.White;
            this.btnEraser.Image = ((System.Drawing.Image)(resources.GetObject("btnEraser.Image")));
            this.btnEraser.Location = new System.Drawing.Point(16, 86);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(30, 23);
            this.btnEraser.TabIndex = 6;
            this.btnEraser.Tag = "6";
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(63, 86);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(30, 23);
            this.btnNew.TabIndex = 7;
            this.btnNew.Tag = "0";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(110, 86);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Tag = "0";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLine1
            // 
            this.btnLine1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine1.Image = ((System.Drawing.Image)(resources.GetObject("btnLine1.Image")));
            this.btnLine1.Location = new System.Drawing.Point(19, 24);
            this.btnLine1.Name = "btnLine1";
            this.btnLine1.Size = new System.Drawing.Size(121, 15);
            this.btnLine1.TabIndex = 0;
            this.btnLine1.Tag = "1";
            this.btnLine1.UseVisualStyleBackColor = true;
            this.btnLine1.Click += new System.EventHandler(this.btnLine1_Click);
            // 
            // btnLine2
            // 
            this.btnLine2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine2.Image = ((System.Drawing.Image)(resources.GetObject("btnLine2.Image")));
            this.btnLine2.Location = new System.Drawing.Point(19, 45);
            this.btnLine2.Name = "btnLine2";
            this.btnLine2.Size = new System.Drawing.Size(121, 15);
            this.btnLine2.TabIndex = 1;
            this.btnLine2.Tag = "2";
            this.btnLine2.Text = "button11";
            this.btnLine2.UseVisualStyleBackColor = true;
            this.btnLine2.Click += new System.EventHandler(this.btnLine2_Click);
            // 
            // btnLine3
            // 
            this.btnLine3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine3.Image = ((System.Drawing.Image)(resources.GetObject("btnLine3.Image")));
            this.btnLine3.Location = new System.Drawing.Point(19, 66);
            this.btnLine3.Name = "btnLine3";
            this.btnLine3.Size = new System.Drawing.Size(121, 15);
            this.btnLine3.TabIndex = 2;
            this.btnLine3.Tag = "3";
            this.btnLine3.UseVisualStyleBackColor = true;
            this.btnLine3.Click += new System.EventHandler(this.btnLine3_Click);
            // 
            // btnLine4
            // 
            this.btnLine4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine4.Image = ((System.Drawing.Image)(resources.GetObject("btnLine4.Image")));
            this.btnLine4.Location = new System.Drawing.Point(18, 87);
            this.btnLine4.Name = "btnLine4";
            this.btnLine4.Size = new System.Drawing.Size(122, 15);
            this.btnLine4.TabIndex = 3;
            this.btnLine4.Tag = "4";
            this.btnLine4.UseVisualStyleBackColor = true;
            this.btnLine4.Click += new System.EventHandler(this.btnLine4_Click);
            // 
            // btnLine5
            // 
            this.btnLine5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine5.Image = ((System.Drawing.Image)(resources.GetObject("btnLine5.Image")));
            this.btnLine5.Location = new System.Drawing.Point(19, 108);
            this.btnLine5.Name = "btnLine5";
            this.btnLine5.Size = new System.Drawing.Size(121, 15);
            this.btnLine5.TabIndex = 4;
            this.btnLine5.Tag = "5";
            this.btnLine5.UseVisualStyleBackColor = true;
            this.btnLine5.Click += new System.EventHandler(this.btnLine5_Click);
            // 
            // btnControl
            // 
            this.btnControl.BackColor = System.Drawing.SystemColors.Control;
            this.btnControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControl.Location = new System.Drawing.Point(61, 38);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(30, 23);
            this.btnControl.TabIndex = 0;
            this.btnControl.UseVisualStyleBackColor = false;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.Location = new System.Drawing.Point(17, 67);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(30, 23);
            this.btnRed.TabIndex = 1;
            this.btnRed.Tag = "0";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.Location = new System.Drawing.Point(61, 67);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(30, 23);
            this.btnYellow.TabIndex = 2;
            this.btnYellow.Tag = "0";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.Location = new System.Drawing.Point(108, 67);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(30, 23);
            this.btnGreen.TabIndex = 3;
            this.btnGreen.Tag = "0";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlack.Location = new System.Drawing.Point(17, 96);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(30, 23);
            this.btnBlack.TabIndex = 4;
            this.btnBlack.Tag = "0";
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorDialog.Location = new System.Drawing.Point(108, 96);
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.Size = new System.Drawing.Size(30, 23);
            this.btnColorDialog.TabIndex = 5;
            this.btnColorDialog.Tag = "0";
            this.btnColorDialog.Text = "C";
            this.btnColorDialog.UseVisualStyleBackColor = true;
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.Location = new System.Drawing.Point(61, 96);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(30, 23);
            this.btnBlue.TabIndex = 6;
            this.btnBlue.Tag = "0";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.button21_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "画图";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnColorDialog;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLine5;
        private System.Windows.Forms.Button btnLine4;
        private System.Windows.Forms.Button btnLine3;
        private System.Windows.Forms.Button btnLine2;
        private System.Windows.Forms.Button btnLine1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnFillRec;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.Button btnFillEllipse;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.StatusStrip statusStrip2;
    }
}

