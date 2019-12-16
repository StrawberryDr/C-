namespace StudentMIS
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.myDefaultBtn = new System.Windows.Forms.Button();
            this.myCancleBtn = new System.Windows.Forms.Button();
            this.tbxUsr = new System.Windows.Forms.TextBox();
            this.tbxPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(153, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(178, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // myDefaultBtn
            // 
            this.myDefaultBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.myDefaultBtn.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myDefaultBtn.Location = new System.Drawing.Point(157, 220);
            this.myDefaultBtn.Name = "myDefaultBtn";
            this.myDefaultBtn.Size = new System.Drawing.Size(142, 35);
            this.myDefaultBtn.TabIndex = 2;
            this.myDefaultBtn.Text = "确认";
            this.myDefaultBtn.UseVisualStyleBackColor = true;
            this.myDefaultBtn.Click += new System.EventHandler(this.myDefaultBtn_Click);
            // 
            // myCancleBtn
            // 
            this.myCancleBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.myCancleBtn.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myCancleBtn.Location = new System.Drawing.Point(336, 220);
            this.myCancleBtn.Name = "myCancleBtn";
            this.myCancleBtn.Size = new System.Drawing.Size(139, 35);
            this.myCancleBtn.TabIndex = 3;
            this.myCancleBtn.Text = "重写";
            this.myCancleBtn.UseVisualStyleBackColor = true;
            this.myCancleBtn.Click += new System.EventHandler(this.myCancleBtn_Click);
            // 
            // tbxUsr
            // 
            this.tbxUsr.Location = new System.Drawing.Point(269, 82);
            this.tbxUsr.Name = "tbxUsr";
            this.tbxUsr.Size = new System.Drawing.Size(206, 25);
            this.tbxUsr.TabIndex = 4;
            this.tbxUsr.TextChanged += new System.EventHandler(this.tbxUsr_TextChanged);
            // 
            // tbxPwd
            // 
            this.tbxPwd.Location = new System.Drawing.Point(269, 122);
            this.tbxPwd.Name = "tbxPwd";
            this.tbxPwd.PasswordChar = '*';
            this.tbxPwd.Size = new System.Drawing.Size(206, 25);
            this.tbxPwd.TabIndex = 5;
            // 
            // Login
            // 
            this.AcceptButton = this.myDefaultBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.myCancleBtn;
            this.ClientSize = new System.Drawing.Size(604, 339);
            this.Controls.Add(this.tbxPwd);
            this.Controls.Add(this.tbxUsr);
            this.Controls.Add(this.myCancleBtn);
            this.Controls.Add(this.myDefaultBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button myDefaultBtn;
        private System.Windows.Forms.Button myCancleBtn;
        private System.Windows.Forms.TextBox tbxUsr;
        private System.Windows.Forms.TextBox tbxPwd;
    }
}