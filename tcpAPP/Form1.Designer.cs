namespace tcpAPP
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
            this.label1 = new System.Windows.Forms.Label();
            this.VipTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VportTextBox = new System.Windows.Forms.TextBox();
            this.VconsoleTextBox = new System.Windows.Forms.TextBox();
            this.VsendTextBox = new System.Windows.Forms.TextBox();
            this.VipListBox = new System.Windows.Forms.ListBox();
            this.VserBtn = new System.Windows.Forms.Button();
            this.VcliBtn = new System.Windows.Forms.Button();
            this.VsendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(324, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址";
            // 
            // VipTextBox
            // 
            this.VipTextBox.Location = new System.Drawing.Point(383, 30);
            this.VipTextBox.Name = "VipTextBox";
            this.VipTextBox.Size = new System.Drawing.Size(153, 21);
            this.VipTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(325, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "端口号";
            // 
            // VportTextBox
            // 
            this.VportTextBox.Location = new System.Drawing.Point(384, 69);
            this.VportTextBox.Name = "VportTextBox";
            this.VportTextBox.Size = new System.Drawing.Size(152, 21);
            this.VportTextBox.TabIndex = 1;
            // 
            // VconsoleTextBox
            // 
            this.VconsoleTextBox.BackColor = System.Drawing.Color.White;
            this.VconsoleTextBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VconsoleTextBox.ForeColor = System.Drawing.Color.Black;
            this.VconsoleTextBox.Location = new System.Drawing.Point(33, 30);
            this.VconsoleTextBox.Multiline = true;
            this.VconsoleTextBox.Name = "VconsoleTextBox";
            this.VconsoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.VconsoleTextBox.Size = new System.Drawing.Size(270, 314);
            this.VconsoleTextBox.TabIndex = 2;
            // 
            // VsendTextBox
            // 
            this.VsendTextBox.BackColor = System.Drawing.Color.Snow;
            this.VsendTextBox.Location = new System.Drawing.Point(33, 371);
            this.VsendTextBox.Multiline = true;
            this.VsendTextBox.Name = "VsendTextBox";
            this.VsendTextBox.Size = new System.Drawing.Size(270, 104);
            this.VsendTextBox.TabIndex = 3;
            // 
            // VipListBox
            // 
            this.VipListBox.BackColor = System.Drawing.Color.Snow;
            this.VipListBox.FormattingEnabled = true;
            this.VipListBox.ItemHeight = 12;
            this.VipListBox.Location = new System.Drawing.Point(328, 111);
            this.VipListBox.Name = "VipListBox";
            this.VipListBox.Size = new System.Drawing.Size(208, 232);
            this.VipListBox.TabIndex = 4;
            // 
            // VserBtn
            // 
            this.VserBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.VserBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VserBtn.ForeColor = System.Drawing.Color.Black;
            this.VserBtn.Location = new System.Drawing.Point(327, 371);
            this.VserBtn.Name = "VserBtn";
            this.VserBtn.Size = new System.Drawing.Size(209, 24);
            this.VserBtn.TabIndex = 5;
            this.VserBtn.Text = "创建服务器";
            this.VserBtn.UseVisualStyleBackColor = false;
            this.VserBtn.Click += new System.EventHandler(this.VserBtn_click);
            // 
            // VcliBtn
            // 
            this.VcliBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.VcliBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VcliBtn.ForeColor = System.Drawing.Color.Black;
            this.VcliBtn.Location = new System.Drawing.Point(327, 412);
            this.VcliBtn.Name = "VcliBtn";
            this.VcliBtn.Size = new System.Drawing.Size(209, 24);
            this.VcliBtn.TabIndex = 5;
            this.VcliBtn.Text = "创建客户端";
            this.VcliBtn.UseVisualStyleBackColor = false;
            this.VcliBtn.Click += new System.EventHandler(this.VcliBtn_click);
            // 
            // VsendBtn
            // 
            this.VsendBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.VsendBtn.ForeColor = System.Drawing.Color.Black;
            this.VsendBtn.Location = new System.Drawing.Point(327, 451);
            this.VsendBtn.Name = "VsendBtn";
            this.VsendBtn.Size = new System.Drawing.Size(209, 24);
            this.VsendBtn.TabIndex = 5;
            this.VsendBtn.Text = "发送消息";
            this.VsendBtn.UseVisualStyleBackColor = false;
            this.VsendBtn.Click += new System.EventHandler(this.VsendBtn_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 501);
            this.Controls.Add(this.VsendBtn);
            this.Controls.Add(this.VcliBtn);
            this.Controls.Add(this.VserBtn);
            this.Controls.Add(this.VipListBox);
            this.Controls.Add(this.VsendTextBox);
            this.Controls.Add(this.VconsoleTextBox);
            this.Controls.Add(this.VportTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VipTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "tcp 服务器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VipTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VportTextBox;
        private System.Windows.Forms.TextBox VconsoleTextBox;
        private System.Windows.Forms.TextBox VsendTextBox;
        private System.Windows.Forms.ListBox VipListBox;
        private System.Windows.Forms.Button VserBtn;
        private System.Windows.Forms.Button VcliBtn;
        private System.Windows.Forms.Button VsendBtn;
    }
}

