namespace tcpAPP
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.VipTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VportTextBox = new System.Windows.Forms.TextBox();
            this.VconsoleTextBox = new System.Windows.Forms.TextBox();
            this.VsendTextBox = new System.Windows.Forms.TextBox();
            this.VconncentBtn = new System.Windows.Forms.Button();
            this.VsendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(29, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "IP地址";
            // 
            // VipTextBox
            // 
            this.VipTextBox.Location = new System.Drawing.Point(89, 26);
            this.VipTextBox.Name = "VipTextBox";
            this.VipTextBox.Size = new System.Drawing.Size(142, 21);
            this.VipTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(29, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "端口号";
            // 
            // VportTextBox
            // 
            this.VportTextBox.Location = new System.Drawing.Point(89, 61);
            this.VportTextBox.Name = "VportTextBox";
            this.VportTextBox.Size = new System.Drawing.Size(142, 21);
            this.VportTextBox.TabIndex = 1;
            // 
            // VconsoleTextBox
            // 
            this.VconsoleTextBox.Location = new System.Drawing.Point(32, 99);
            this.VconsoleTextBox.Multiline = true;
            this.VconsoleTextBox.Name = "VconsoleTextBox";
            this.VconsoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.VconsoleTextBox.Size = new System.Drawing.Size(312, 179);
            this.VconsoleTextBox.TabIndex = 2;
            // 
            // VsendTextBox
            // 
            this.VsendTextBox.Location = new System.Drawing.Point(32, 298);
            this.VsendTextBox.Multiline = true;
            this.VsendTextBox.Name = "VsendTextBox";
            this.VsendTextBox.Size = new System.Drawing.Size(312, 65);
            this.VsendTextBox.TabIndex = 2;
            // 
            // VconncentBtn
            // 
            this.VconncentBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.VconncentBtn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VconncentBtn.ForeColor = System.Drawing.Color.Black;
            this.VconncentBtn.Location = new System.Drawing.Point(253, 26);
            this.VconncentBtn.Name = "VconncentBtn";
            this.VconncentBtn.Size = new System.Drawing.Size(91, 56);
            this.VconncentBtn.TabIndex = 3;
            this.VconncentBtn.Text = "连接服务器";
            this.VconncentBtn.UseVisualStyleBackColor = false;
            this.VconncentBtn.Click += new System.EventHandler(this.VconnectBtn_click);
            // 
            // VsendBtn
            // 
            this.VsendBtn.Location = new System.Drawing.Point(32, 379);
            this.VsendBtn.Name = "VsendBtn";
            this.VsendBtn.Size = new System.Drawing.Size(312, 28);
            this.VsendBtn.TabIndex = 4;
            this.VsendBtn.Text = "发送消息";
            this.VsendBtn.UseVisualStyleBackColor = true;
            this.VsendBtn.Click += new System.EventHandler(this.VsendBtn_click);
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(374, 426);
            this.Controls.Add(this.VsendBtn);
            this.Controls.Add(this.VconncentBtn);
            this.Controls.Add(this.VsendTextBox);
            this.Controls.Add(this.VconsoleTextBox);
            this.Controls.Add(this.VportTextBox);
            this.Controls.Add(this.VipTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "tcp 客户端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VipTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VportTextBox;
        private System.Windows.Forms.TextBox VconsoleTextBox;
        private System.Windows.Forms.TextBox VsendTextBox;
        private System.Windows.Forms.Button VconncentBtn;
        private System.Windows.Forms.Button VsendBtn;
    }
}