namespace ConstGenerateTool
{
    partial class FMConstClassGenerate
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
            this.rtxtFinalConst = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.rtxtInput = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassSummary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxtFinalConst
            // 
            this.rtxtFinalConst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtFinalConst.Location = new System.Drawing.Point(109, 204);
            this.rtxtFinalConst.Name = "rtxtFinalConst";
            this.rtxtFinalConst.Size = new System.Drawing.Size(631, 282);
            this.rtxtFinalConst.TabIndex = 0;
            this.rtxtFinalConst.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "常量类：";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(109, 22);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(124, 21);
            this.txtClassName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "类名：";
            // 
            // txtRegex
            // 
            this.txtRegex.Location = new System.Drawing.Point(109, 59);
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.Size = new System.Drawing.Size(562, 21);
            this.txtRegex.TabIndex = 6;
            this.txtRegex.Text = "([a-zA-Z\\d]+):([a-zA-Z\\d]+)\\|([^;；:\\|]*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "正则表达式：";
            // 
            // lblA
            // 
            this.lblA.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblA.Location = new System.Drawing.Point(107, 83);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(251, 28);
            this.lblA.TabIndex = 8;
            this.lblA.Tag = "A";
            this.lblA.Text = "([a-zA-Z\\d]+):([a-zA-Z\\d]+)\\|([^;；:\\|]*)\r\n（例：A:1|成功；B:2|失败）";
            this.lblA.DoubleClick += new System.EventHandler(this.LblRegex_DoubleClick);
            // 
            // rtxtInput
            // 
            this.rtxtInput.Location = new System.Drawing.Point(109, 114);
            this.rtxtInput.Name = "rtxtInput";
            this.rtxtInput.Size = new System.Drawing.Size(631, 55);
            this.rtxtInput.TabIndex = 9;
            this.rtxtInput.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "输入内容：";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(109, 175);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(571, 22);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(100, 21);
            this.txtPre.TabIndex = 12;
            this.txtPre.Text = "C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "前缀：";
            // 
            // txtClassSummary
            // 
            this.txtClassSummary.Location = new System.Drawing.Point(314, 22);
            this.txtClassSummary.Name = "txtClassSummary";
            this.txtClassSummary.Size = new System.Drawing.Size(183, 21);
            this.txtClassSummary.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "类注释：";
            // 
            // lblB
            // 
            this.lblB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblB.Location = new System.Drawing.Point(364, 83);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(167, 28);
            this.lblB.TabIndex = 16;
            this.lblB.Tag = "B";
            this.lblB.Text = "([a-zA-Z\\d]+):([a-zA-Z\\d]+)\r\n（例：A:1;B:2）";
            this.lblB.DoubleClick += new System.EventHandler(this.LblRegex_DoubleClick);
            // 
            // FMConstClassGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 501);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClassSummary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtxtInput);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRegex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtFinalConst);
            this.Name = "FMConstClassGenerate";
            this.Text = "常量类生成器";
            this.Load += new System.EventHandler(this.FMConstClassGenerate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtFinalConst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.RichTextBox rtxtInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClassSummary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblB;
    }
}

