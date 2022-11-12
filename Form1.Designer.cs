namespace GiaiPhuongTrinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_PT1_CheckedChanged = new System.Windows.Forms.RadioButton();
            this.radioButton_PT2_CheckedChanged = new System.Windows.Forms.RadioButton();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.tb_c = new System.Windows.Forms.TextBox();
            this.tb_ketqua = new System.Windows.Forms.TextBox();
            this.bt_giaiphuongtrinh = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_lamlai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Phương Trình ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập a";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_PT2_CheckedChanged);
            this.groupBox1.Controls.Add(this.radioButton_PT1_CheckedChanged);
            this.groupBox1.Location = new System.Drawing.Point(56, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Chức Năng";
            // 
            // radioButton_PT1_CheckedChanged
            // 
            this.radioButton_PT1_CheckedChanged.AutoSize = true;
            this.radioButton_PT1_CheckedChanged.Location = new System.Drawing.Point(67, 25);
            this.radioButton_PT1_CheckedChanged.Name = "radioButton_PT1_CheckedChanged";
            this.radioButton_PT1_CheckedChanged.Size = new System.Drawing.Size(198, 24);
            this.radioButton_PT1_CheckedChanged.TabIndex = 0;
            this.radioButton_PT1_CheckedChanged.TabStop = true;
            this.radioButton_PT1_CheckedChanged.Text = "Phương Trình Bậc Nhất";
            this.radioButton_PT1_CheckedChanged.UseVisualStyleBackColor = true;
            this.radioButton_PT1_CheckedChanged.CheckedChanged += new System.EventHandler(this.radioButton_PT1_CheckedChanged_CheckedChanged);
            // 
            // radioButton_PT2_CheckedChanged
            // 
            this.radioButton_PT2_CheckedChanged.AutoSize = true;
            this.radioButton_PT2_CheckedChanged.Location = new System.Drawing.Point(67, 73);
            this.radioButton_PT2_CheckedChanged.Name = "radioButton_PT2_CheckedChanged";
            this.radioButton_PT2_CheckedChanged.Size = new System.Drawing.Size(188, 24);
            this.radioButton_PT2_CheckedChanged.TabIndex = 0;
            this.radioButton_PT2_CheckedChanged.TabStop = true;
            this.radioButton_PT2_CheckedChanged.Text = "Phương Trình Bậc Hai";
            this.radioButton_PT2_CheckedChanged.UseVisualStyleBackColor = true;
            this.radioButton_PT2_CheckedChanged.CheckedChanged += new System.EventHandler(this.radioButton_PT2_CheckedChanged_CheckedChanged);
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(138, 240);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(200, 26);
            this.tb_a.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kết Quả";
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(138, 291);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(200, 26);
            this.tb_b.TabIndex = 3;
            // 
            // tb_c
            // 
            this.tb_c.Location = new System.Drawing.Point(138, 346);
            this.tb_c.Name = "tb_c";
            this.tb_c.Size = new System.Drawing.Size(200, 26);
            this.tb_c.TabIndex = 3;
            // 
            // tb_ketqua
            // 
            this.tb_ketqua.Location = new System.Drawing.Point(138, 397);
            this.tb_ketqua.Multiline = true;
            this.tb_ketqua.Name = "tb_ketqua";
            this.tb_ketqua.Size = new System.Drawing.Size(200, 171);
            this.tb_ketqua.TabIndex = 3;
            // 
            // bt_giaiphuongtrinh
            // 
            this.bt_giaiphuongtrinh.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_giaiphuongtrinh.Location = new System.Drawing.Point(446, 240);
            this.bt_giaiphuongtrinh.Name = "bt_giaiphuongtrinh";
            this.bt_giaiphuongtrinh.Size = new System.Drawing.Size(311, 59);
            this.bt_giaiphuongtrinh.TabIndex = 4;
            this.bt_giaiphuongtrinh.Text = "Giải Phương Trình";
            this.bt_giaiphuongtrinh.UseVisualStyleBackColor = false;
            this.bt_giaiphuongtrinh.Click += new System.EventHandler(this.bt_giaiphuongtrinh_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.Aqua;
            this.bt_thoat.Location = new System.Drawing.Point(446, 386);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(311, 59);
            this.bt_thoat.TabIndex = 4;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_lamlai
            // 
            this.bt_lamlai.BackColor = System.Drawing.Color.SpringGreen;
            this.bt_lamlai.Location = new System.Drawing.Point(446, 313);
            this.bt_lamlai.Name = "bt_lamlai";
            this.bt_lamlai.Size = new System.Drawing.Size(311, 59);
            this.bt_lamlai.TabIndex = 4;
            this.bt_lamlai.Text = "Làm Lại";
            this.bt_lamlai.UseVisualStyleBackColor = false;
            this.bt_lamlai.Click += new System.EventHandler(this.bt_lamlai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 706);
            this.Controls.Add(this.bt_lamlai);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_giaiphuongtrinh);
            this.Controls.Add(this.tb_ketqua);
            this.Controls.Add(this.tb_c);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_PT2_CheckedChanged;
        private System.Windows.Forms.RadioButton radioButton_PT1_CheckedChanged;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.TextBox tb_c;
        private System.Windows.Forms.TextBox tb_ketqua;
        private System.Windows.Forms.Button bt_giaiphuongtrinh;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_lamlai;
    }
}

