namespace c___hinh_tron
{
    partial class Form1
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
            this.btncv = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btndt = new System.Windows.Forms.Button();
            this.txtBK = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkdt1 = new System.Windows.Forms.CheckBox();
            this.rdbdt1 = new System.Windows.Forms.RadioButton();
            this.chkcv1 = new System.Windows.Forms.CheckBox();
            this.rdbcv1 = new System.Windows.Forms.RadioButton();
            this.btntinh1 = new System.Windows.Forms.Button();
            this.btntinh2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncv
            // 
            this.btncv.Location = new System.Drawing.Point(380, 273);
            this.btncv.Name = "btncv";
            this.btncv.Size = new System.Drawing.Size(75, 23);
            this.btncv.TabIndex = 0;
            this.btncv.Text = "Chu Vi";
            this.btncv.UseVisualStyleBackColor = true;
            this.btncv.Click += new System.EventHandler(this.btncv_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(79, 73);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(91, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "NHẬP BÁN KÍNH";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(176, 122);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 2;
            // 
            // btndt
            // 
            this.btndt.Location = new System.Drawing.Point(66, 273);
            this.btndt.Name = "btndt";
            this.btndt.Size = new System.Drawing.Size(75, 23);
            this.btndt.TabIndex = 0;
            this.btndt.Text = "Diện Tích";
            this.btndt.UseVisualStyleBackColor = true;
            this.btndt.Click += new System.EventHandler(this.btndt_Click);
            // 
            // txtBK
            // 
            this.txtBK.Location = new System.Drawing.Point(176, 70);
            this.txtBK.Name = "txtBK";
            this.txtBK.Size = new System.Drawing.Size(100, 20);
            this.txtBK.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(106, 125);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(51, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "KETQUA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbcv1);
            this.groupBox1.Controls.Add(this.rdbdt1);
            this.groupBox1.Location = new System.Drawing.Point(347, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 86);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkcv1);
            this.groupBox2.Controls.Add(this.chkdt1);
            this.groupBox2.Location = new System.Drawing.Point(563, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 82);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Chức Năng";
            // 
            // chkdt1
            // 
            this.chkdt1.AutoSize = true;
            this.chkdt1.Location = new System.Drawing.Point(6, 19);
            this.chkdt1.Name = "chkdt1";
            this.chkdt1.Size = new System.Drawing.Size(74, 17);
            this.chkdt1.TabIndex = 0;
            this.chkdt1.Text = "Diện Tích";
            this.chkdt1.UseVisualStyleBackColor = true;
            // 
            // rdbdt1
            // 
            this.rdbdt1.AutoSize = true;
            this.rdbdt1.Location = new System.Drawing.Point(18, 21);
            this.rdbdt1.Name = "rdbdt1";
            this.rdbdt1.Size = new System.Drawing.Size(73, 17);
            this.rdbdt1.TabIndex = 1;
            this.rdbdt1.TabStop = true;
            this.rdbdt1.Text = "Diện Tích";
            this.rdbdt1.UseVisualStyleBackColor = true;
            // 
            // chkcv1
            // 
            this.chkcv1.AutoSize = true;
            this.chkcv1.Location = new System.Drawing.Point(6, 42);
            this.chkcv1.Name = "chkcv1";
            this.chkcv1.Size = new System.Drawing.Size(56, 17);
            this.chkcv1.TabIndex = 0;
            this.chkcv1.Text = "Chu vi";
            this.chkcv1.UseVisualStyleBackColor = true;
            // 
            // rdbcv1
            // 
            this.rdbcv1.AutoSize = true;
            this.rdbcv1.Location = new System.Drawing.Point(18, 44);
            this.rdbcv1.Name = "rdbcv1";
            this.rdbcv1.Size = new System.Drawing.Size(55, 17);
            this.rdbcv1.TabIndex = 1;
            this.rdbcv1.TabStop = true;
            this.rdbcv1.Text = "Chu vi";
            this.rdbcv1.UseVisualStyleBackColor = true;
            // 
            // btntinh1
            // 
            this.btntinh1.Location = new System.Drawing.Point(347, 172);
            this.btntinh1.Name = "btntinh1";
            this.btntinh1.Size = new System.Drawing.Size(75, 23);
            this.btntinh1.TabIndex = 6;
            this.btntinh1.Text = "Tính 1";
            this.btntinh1.UseVisualStyleBackColor = true;
            this.btntinh1.Click += new System.EventHandler(this.btntinh1_Click);
            // 
            // btntinh2
            // 
            this.btntinh2.Location = new System.Drawing.Point(609, 172);
            this.btntinh2.Name = "btntinh2";
            this.btntinh2.Size = new System.Drawing.Size(75, 23);
            this.btntinh2.TabIndex = 7;
            this.btntinh2.Text = "Tính 2";
            this.btntinh2.UseVisualStyleBackColor = true;
            this.btntinh2.Click += new System.EventHandler(this.btntinh2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntinh2);
            this.Controls.Add(this.btntinh1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtBK);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btndt);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btncv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncv;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btndt;
        private System.Windows.Forms.TextBox txtBK;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbcv1;
        private System.Windows.Forms.RadioButton rdbdt1;
        private System.Windows.Forms.CheckBox chkcv1;
        private System.Windows.Forms.CheckBox chkdt1;
        private System.Windows.Forms.Button btntinh1;
        private System.Windows.Forms.Button btntinh2;
    }
}

