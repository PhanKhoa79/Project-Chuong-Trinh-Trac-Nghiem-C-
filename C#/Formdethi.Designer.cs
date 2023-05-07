namespace Nhom10
{
    partial class Formdethi
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
            this.dataGridView_cauhoi = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_monthi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_maCauHoi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_chuong = new System.Windows.Forms.ComboBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.textBox_daDung = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_xuatEx = new System.Windows.Forms.Button();
            this.button_nhapEx = new System.Windows.Forms.Button();
            this.button_timKiem = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.comboBox_mucdo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_daD = new System.Windows.Forms.TextBox();
            this.textBox_daC = new System.Windows.Forms.TextBox();
            this.textBox_daB = new System.Windows.Forms.TextBox();
            this.textBox_daA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_cauhoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cauhoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_cauhoi
            // 
            this.dataGridView_cauhoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_cauhoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_cauhoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cauhoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column10,
            this.Column8,
            this.Column9});
            this.dataGridView_cauhoi.Location = new System.Drawing.Point(-26, 46);
            this.dataGridView_cauhoi.Name = "dataGridView_cauhoi";
            this.dataGridView_cauhoi.Size = new System.Drawing.Size(976, 187);
            this.dataGridView_cauhoi.TabIndex = 149;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdCauHoi";
            this.Column1.FillWeight = 80F;
            this.Column1.HeaderText = "Mã Câu Hỏi";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CauHoi";
            this.Column2.FillWeight = 200F;
            this.Column2.HeaderText = "Câu Hỏi";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Dap_An_A";
            this.Column3.HeaderText = "Đáp Án A";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Dap_An_B";
            this.Column4.HeaderText = "Đáp Án B";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Dap_An_C";
            this.Column5.HeaderText = "Đáp Án C";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Dap_An_D";
            this.Column6.HeaderText = "Đáp Án D";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DapAnDung";
            this.Column7.FillWeight = 80F;
            this.Column7.HeaderText = "Đáp Án Đúng";
            this.Column7.Name = "Column7";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TenMonThi";
            this.Column10.FillWeight = 90F;
            this.Column10.HeaderText = "Môn Thi";
            this.Column10.Name = "Column10";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenMucDo";
            this.Column8.FillWeight = 90F;
            this.Column8.HeaderText = "Mức Độ";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TenChuong";
            this.Column9.FillWeight = 80F;
            this.Column9.HeaderText = "Chương";
            this.Column9.Name = "Column9";
            // 
            // comboBox_monthi
            // 
            this.comboBox_monthi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_monthi.FormattingEnabled = true;
            this.comboBox_monthi.Location = new System.Drawing.Point(141, 5);
            this.comboBox_monthi.Name = "comboBox_monthi";
            this.comboBox_monthi.Size = new System.Drawing.Size(127, 23);
            this.comboBox_monthi.TabIndex = 148;
            this.comboBox_monthi.SelectedValueChanged += new System.EventHandler(this.comboBox_monthi_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-31, -28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 147;
            this.label1.Text = "Tên Môn Thi: ";
            // 
            // textBox_maCauHoi
            // 
            this.textBox_maCauHoi.Location = new System.Drawing.Point(455, 268);
            this.textBox_maCauHoi.Name = "textBox_maCauHoi";
            this.textBox_maCauHoi.Size = new System.Drawing.Size(174, 20);
            this.textBox_maCauHoi.TabIndex = 146;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(380, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 145;
            this.label11.Text = "Mã Câu Hỏi: ";
            // 
            // comboBox_chuong
            // 
            this.comboBox_chuong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_chuong.FormattingEnabled = true;
            this.comboBox_chuong.Location = new System.Drawing.Point(664, 291);
            this.comboBox_chuong.Name = "comboBox_chuong";
            this.comboBox_chuong.Size = new System.Drawing.Size(136, 23);
            this.comboBox_chuong.TabIndex = 144;
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(730, 429);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(58, 27);
            this.button_refresh.TabIndex = 143;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            // 
            // textBox_daDung
            // 
            this.textBox_daDung.Location = new System.Drawing.Point(392, 330);
            this.textBox_daDung.Name = "textBox_daDung";
            this.textBox_daDung.Size = new System.Drawing.Size(174, 20);
            this.textBox_daDung.TabIndex = 142;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(389, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 141;
            this.label10.Text = "Đáp án đúng";
            // 
            // button_xuatEx
            // 
            this.button_xuatEx.Location = new System.Drawing.Point(632, 429);
            this.button_xuatEx.Name = "button_xuatEx";
            this.button_xuatEx.Size = new System.Drawing.Size(77, 27);
            this.button_xuatEx.TabIndex = 140;
            this.button_xuatEx.Text = "Xuất Excel";
            this.button_xuatEx.UseVisualStyleBackColor = true;
            // 
            // button_nhapEx
            // 
            this.button_nhapEx.Location = new System.Drawing.Point(632, 373);
            this.button_nhapEx.Name = "button_nhapEx";
            this.button_nhapEx.Size = new System.Drawing.Size(87, 27);
            this.button_nhapEx.TabIndex = 139;
            this.button_nhapEx.Text = "Nhập Excel";
            this.button_nhapEx.UseVisualStyleBackColor = true;
            // 
            // button_timKiem
            // 
            this.button_timKiem.Location = new System.Drawing.Point(535, 429);
            this.button_timKiem.Name = "button_timKiem";
            this.button_timKiem.Size = new System.Drawing.Size(58, 27);
            this.button_timKiem.TabIndex = 138;
            this.button_timKiem.Text = "Tìm Kiếm";
            this.button_timKiem.UseVisualStyleBackColor = true;
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(535, 373);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(58, 27);
            this.button_xoa.TabIndex = 137;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            // 
            // button_sua
            // 
            this.button_sua.Location = new System.Drawing.Point(438, 429);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(58, 27);
            this.button_sua.TabIndex = 136;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(438, 373);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(58, 27);
            this.button_them.TabIndex = 135;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = true;
            // 
            // comboBox_mucdo
            // 
            this.comboBox_mucdo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_mucdo.FormattingEnabled = true;
            this.comboBox_mucdo.Location = new System.Drawing.Point(664, 339);
            this.comboBox_mucdo.Name = "comboBox_mucdo";
            this.comboBox_mucdo.Size = new System.Drawing.Size(136, 23);
            this.comboBox_mucdo.TabIndex = 134;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(598, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 133;
            this.label9.Text = "Mức Độ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(599, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 132;
            this.label8.Text = "Chương:";
            // 
            // textBox_daD
            // 
            this.textBox_daD.Location = new System.Drawing.Point(64, 463);
            this.textBox_daD.Name = "textBox_daD";
            this.textBox_daD.Size = new System.Drawing.Size(260, 20);
            this.textBox_daD.TabIndex = 131;
            // 
            // textBox_daC
            // 
            this.textBox_daC.Location = new System.Drawing.Point(66, 424);
            this.textBox_daC.Name = "textBox_daC";
            this.textBox_daC.Size = new System.Drawing.Size(260, 20);
            this.textBox_daC.TabIndex = 130;
            // 
            // textBox_daB
            // 
            this.textBox_daB.Location = new System.Drawing.Point(66, 383);
            this.textBox_daB.Name = "textBox_daB";
            this.textBox_daB.Size = new System.Drawing.Size(260, 20);
            this.textBox_daB.TabIndex = 129;
            // 
            // textBox_daA
            // 
            this.textBox_daA.Location = new System.Drawing.Point(66, 345);
            this.textBox_daA.Name = "textBox_daA";
            this.textBox_daA.Size = new System.Drawing.Size(260, 20);
            this.textBox_daA.TabIndex = 128;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 127;
            this.label7.Text = "D.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 126;
            this.label6.Text = "C.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 124;
            this.label4.Text = "A.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 123;
            this.label3.Text = "Đáp án";
            // 
            // textBox_cauhoi
            // 
            this.textBox_cauhoi.Location = new System.Drawing.Point(79, 268);
            this.textBox_cauhoi.Multiline = true;
            this.textBox_cauhoi.Name = "textBox_cauhoi";
            this.textBox_cauhoi.Size = new System.Drawing.Size(260, 36);
            this.textBox_cauhoi.TabIndex = 122;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 121;
            this.label2.Text = "Câu Hỏi: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 125;
            this.label5.Text = "B.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 19);
            this.label12.TabIndex = 150;
            this.label12.Text = "Tên Môn Thi: ";
            // 
            // Formdethi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 494);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView_cauhoi);
            this.Controls.Add(this.comboBox_monthi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_maCauHoi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox_chuong);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.textBox_daDung);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button_xuatEx);
            this.Controls.Add(this.button_nhapEx);
            this.Controls.Add(this.button_timKiem);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.comboBox_mucdo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_daD);
            this.Controls.Add(this.textBox_daC);
            this.Controls.Add(this.textBox_daB);
            this.Controls.Add(this.textBox_daA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_cauhoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Name = "Formdethi";
            this.Text = "Đề Thi";
            this.Load += new System.EventHandler(this.Formdethi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cauhoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_cauhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.ComboBox comboBox_monthi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_maCauHoi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_chuong;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.TextBox textBox_daDung;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_xuatEx;
        private System.Windows.Forms.Button button_nhapEx;
        private System.Windows.Forms.Button button_timKiem;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.ComboBox comboBox_mucdo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_daD;
        private System.Windows.Forms.TextBox textBox_daC;
        private System.Windows.Forms.TextBox textBox_daB;
        private System.Windows.Forms.TextBox textBox_daA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_cauhoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
    }
}