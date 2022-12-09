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
            this.lblB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFieldSummary = new System.Windows.Forms.TextBox();
            this.txtFieldValue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxMyRegex = new System.Windows.Forms.ComboBox();
            this.lblMyRegex = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDefaultType = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxSelectedType = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grBRegex = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grBRegex.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtFinalConst
            // 
            this.rtxtFinalConst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtFinalConst.Location = new System.Drawing.Point(103, 171);
            this.rtxtFinalConst.Name = "rtxtFinalConst";
            this.rtxtFinalConst.Size = new System.Drawing.Size(755, 532);
            this.rtxtFinalConst.TabIndex = 23;
            this.rtxtFinalConst.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "常量类：";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(65, 20);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(129, 21);
            this.txtClassName.TabIndex = 11;
            this.txtClassName.Text = "ClassName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "类名";
            // 
            // txtRegex
            // 
            this.txtRegex.Location = new System.Drawing.Point(106, 36);
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.Size = new System.Drawing.Size(612, 21);
            this.txtRegex.TabIndex = 2;
            this.txtRegex.Text = "([^\\s:：；;，,\\|]+):([^\\s:：；;，,\\|]+)";
            this.txtRegex.TextChanged += new System.EventHandler(this.txtRegex_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "正则表达式：";
            // 
            // lblB
            // 
            this.lblB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblB.Location = new System.Drawing.Point(353, 60);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(365, 28);
            this.lblB.TabIndex = 5;
            this.lblB.Tag = "B";
            this.lblB.Text = "([^\\s:：；;，,\\|]+):([^\\s:：；;，,\\|]+)\\|([^\\s:：；;，,\\|]+)\r\n(S:1|系统,U:2|用户)\r\n";
            this.lblB.Click += new System.EventHandler(this.lblRegex_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "输入内容：";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(103, 142);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 21;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(65, 100);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(129, 21);
            this.txtPre.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "前缀";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "默认类型";
            // 
            // lblA
            // 
            this.lblA.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblA.Location = new System.Drawing.Point(104, 61);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(243, 28);
            this.lblA.TabIndex = 4;
            this.lblA.Tag = "A";
            this.lblA.Text = "([^\\s:：；;，,\\|]+):([^\\s:：；;，,\\|]+)\r\n(S:系统,U:用户)";
            this.lblA.Click += new System.EventHandler(this.lblRegex_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(106, 9);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(930, 21);
            this.txtInput.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtFieldSummary);
            this.groupBox1.Controls.Add(this.txtFieldValue);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtFieldName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(864, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 105);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // txtFieldSummary
            // 
            this.txtFieldSummary.Location = new System.Drawing.Point(65, 75);
            this.txtFieldSummary.Name = "txtFieldSummary";
            this.txtFieldSummary.Size = new System.Drawing.Size(129, 21);
            this.txtFieldSummary.TabIndex = 17;
            // 
            // txtFieldValue
            // 
            this.txtFieldValue.Location = new System.Drawing.Point(65, 48);
            this.txtFieldValue.Name = "txtFieldValue";
            this.txtFieldValue.Size = new System.Drawing.Size(129, 21);
            this.txtFieldValue.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "属性说明";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "属性值";
            // 
            // txtFieldName
            // 
            this.txtFieldName.Location = new System.Drawing.Point(65, 21);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.Size = new System.Drawing.Size(129, 21);
            this.txtFieldName.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "属性名称";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(184, 142);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 22;
            this.btnCopy.Text = "复制";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(724, 37);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(41, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxMyRegex
            // 
            this.cbxMyRegex.FormattingEnabled = true;
            this.cbxMyRegex.Location = new System.Drawing.Point(113, 13);
            this.cbxMyRegex.Name = "cbxMyRegex";
            this.cbxMyRegex.Size = new System.Drawing.Size(507, 20);
            this.cbxMyRegex.TabIndex = 6;
            this.cbxMyRegex.SelectedValueChanged += new System.EventHandler(this.cbxMyRegex_SelectedValueChanged);
            // 
            // lblMyRegex
            // 
            this.lblMyRegex.AutoSize = true;
            this.lblMyRegex.Location = new System.Drawing.Point(6, 16);
            this.lblMyRegex.Name = "lblMyRegex";
            this.lblMyRegex.Size = new System.Drawing.Size(101, 12);
            this.lblMyRegex.TabIndex = 23;
            this.lblMyRegex.Text = "我的正则表达式：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 12);
            this.label11.TabIndex = 24;
            this.label11.Text = "系统默认正则：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtDefaultType);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbxSelectedType);
            this.groupBox2.Controls.Add(this.txtClassName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPre);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(864, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 135);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // txtDefaultType
            // 
            this.txtDefaultType.Enabled = false;
            this.txtDefaultType.Location = new System.Drawing.Point(65, 47);
            this.txtDefaultType.Name = "txtDefaultType";
            this.txtDefaultType.Size = new System.Drawing.Size(129, 21);
            this.txtDefaultType.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "自选类型";
            // 
            // cbxSelectedType
            // 
            this.cbxSelectedType.FormattingEnabled = true;
            this.cbxSelectedType.Location = new System.Drawing.Point(65, 74);
            this.cbxSelectedType.Name = "cbxSelectedType";
            this.cbxSelectedType.Size = new System.Drawing.Size(129, 20);
            this.cbxSelectedType.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(626, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(41, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grBRegex
            // 
            this.grBRegex.Controls.Add(this.cbxMyRegex);
            this.grBRegex.Controls.Add(this.btnDelete);
            this.grBRegex.Controls.Add(this.lblMyRegex);
            this.grBRegex.Location = new System.Drawing.Point(103, 92);
            this.grBRegex.Name = "grBRegex";
            this.grBRegex.Size = new System.Drawing.Size(681, 37);
            this.grBRegex.TabIndex = 27;
            this.grBRegex.TabStop = false;
            this.grBRegex.Visible = false;
            // 
            // FMConstClassGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 715);
            this.Controls.Add(this.grBRegex);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRegex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtFinalConst);
            this.Name = "FMConstClassGenerate";
            this.Text = "常量类生成器";
            this.Load += new System.EventHandler(this.FMConstClassGenerate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grBRegex.ResumeLayout(false);
            this.grBRegex.PerformLayout();
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
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFieldSummary;
        private System.Windows.Forms.TextBox txtFieldValue;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxMyRegex;
        private System.Windows.Forms.Label lblMyRegex;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxSelectedType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grBRegex;
        private System.Windows.Forms.TextBox txtDefaultType;
    }
}

