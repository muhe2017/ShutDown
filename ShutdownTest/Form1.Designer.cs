namespace ShutdownTest
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CPUlabel = new System.Windows.Forms.Label();
            this.Second = new System.Windows.Forms.Label();
            this.ClosingLab = new System.Windows.Forms.Label();
            this.CloseLab = new System.Windows.Forms.Label();
            this.InText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Overtime = new System.Windows.Forms.TextBox();
            this.CPURadioBtn = new System.Windows.Forms.RadioButton();
            this.TimeRadioBtn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinRadioBtn = new System.Windows.Forms.RadioButton();
            this.MaxRadioBtn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Minute = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前CPU占用率：";
            // 
            // CPUlabel
            // 
            this.CPUlabel.AutoSize = true;
            this.CPUlabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CPUlabel.Location = new System.Drawing.Point(221, 35);
            this.CPUlabel.Name = "CPUlabel";
            this.CPUlabel.Size = new System.Drawing.Size(17, 12);
            this.CPUlabel.TabIndex = 1;
            this.CPUlabel.Text = "0%";
            // 
            // Second
            // 
            this.Second.AutoSize = true;
            this.Second.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Second.Location = new System.Drawing.Point(91, 206);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(21, 22);
            this.Second.TabIndex = 2;
            this.Second.Text = "X";
            // 
            // ClosingLab
            // 
            this.ClosingLab.AutoSize = true;
            this.ClosingLab.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ClosingLab.Location = new System.Drawing.Point(209, 153);
            this.ClosingLab.Name = "ClosingLab";
            this.ClosingLab.Size = new System.Drawing.Size(29, 12);
            this.ClosingLab.TabIndex = 3;
            this.ClosingLab.Text = "时间";
            // 
            // CloseLab
            // 
            this.CloseLab.AutoSize = true;
            this.CloseLab.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseLab.Location = new System.Drawing.Point(14, 179);
            this.CloseLab.Name = "CloseLab";
            this.CloseLab.Size = new System.Drawing.Size(174, 27);
            this.CloseLab.TabIndex = 4;
            this.CloseLab.Text = "系统即将断电";
            // 
            // InText
            // 
            this.InText.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InText.Location = new System.Drawing.Point(206, 50);
            this.InText.Name = "InText";
            this.InText.Size = new System.Drawing.Size(32, 21);
            this.InText.TabIndex = 5;
            this.InText.Text = "10";
            this.InText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InText_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "设定CPU占用率：";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(206, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(17, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "超时时间：";
            // 
            // Overtime
            // 
            this.Overtime.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Overtime.Location = new System.Drawing.Point(206, 71);
            this.Overtime.Name = "Overtime";
            this.Overtime.Size = new System.Drawing.Size(32, 21);
            this.Overtime.TabIndex = 9;
            this.Overtime.Text = "5";
            this.Overtime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Overtime_KeyPress);
            // 
            // CPURadioBtn
            // 
            this.CPURadioBtn.AutoSize = true;
            this.CPURadioBtn.Location = new System.Drawing.Point(5, 10);
            this.CPURadioBtn.Name = "CPURadioBtn";
            this.CPURadioBtn.Size = new System.Drawing.Size(107, 16);
            this.CPURadioBtn.TabIndex = 10;
            this.CPURadioBtn.TabStop = true;
            this.CPURadioBtn.Text = "占用率控制关机";
            this.CPURadioBtn.UseVisualStyleBackColor = true;
            // 
            // TimeRadioBtn
            // 
            this.TimeRadioBtn.AutoSize = true;
            this.TimeRadioBtn.Location = new System.Drawing.Point(5, 105);
            this.TimeRadioBtn.Name = "TimeRadioBtn";
            this.TimeRadioBtn.Size = new System.Drawing.Size(95, 16);
            this.TimeRadioBtn.TabIndex = 11;
            this.TimeRadioBtn.TabStop = true;
            this.TimeRadioBtn.Text = "计时控制关机";
            this.TimeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MinRadioBtn);
            this.panel1.Controls.Add(this.MaxRadioBtn);
            this.panel1.Location = new System.Drawing.Point(104, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 23);
            this.panel1.TabIndex = 12;
            // 
            // MinRadioBtn
            // 
            this.MinRadioBtn.AutoSize = true;
            this.MinRadioBtn.Location = new System.Drawing.Point(46, 3);
            this.MinRadioBtn.Name = "MinRadioBtn";
            this.MinRadioBtn.Size = new System.Drawing.Size(47, 16);
            this.MinRadioBtn.TabIndex = 1;
            this.MinRadioBtn.TabStop = true;
            this.MinRadioBtn.Text = "小于";
            this.MinRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MaxRadioBtn
            // 
            this.MaxRadioBtn.AutoSize = true;
            this.MaxRadioBtn.Location = new System.Drawing.Point(0, 3);
            this.MaxRadioBtn.Name = "MaxRadioBtn";
            this.MaxRadioBtn.Size = new System.Drawing.Size(47, 16);
            this.MaxRadioBtn.TabIndex = 0;
            this.MaxRadioBtn.TabStop = true;
            this.MaxRadioBtn.Text = "大于";
            this.MaxRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "延时关机（分）：";
            // 
            // Minute
            // 
            this.Minute.Location = new System.Drawing.Point(207, 119);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(32, 21);
            this.Minute.TabIndex = 14;
            this.Minute.Text = "5";
            this.Minute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Minute_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "关机时间：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Minute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TimeRadioBtn);
            this.Controls.Add(this.CPURadioBtn);
            this.Controls.Add(this.Overtime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InText);
            this.Controls.Add(this.CloseLab);
            this.Controls.Add(this.ClosingLab);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.CPUlabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "关机v1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CPUlabel;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Label ClosingLab;
        private System.Windows.Forms.Label CloseLab;
        private System.Windows.Forms.TextBox InText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Overtime;
        private System.Windows.Forms.RadioButton CPURadioBtn;
        private System.Windows.Forms.RadioButton TimeRadioBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton MinRadioBtn;
        private System.Windows.Forms.RadioButton MaxRadioBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Minute;
        private System.Windows.Forms.Label label3;

    }
}

