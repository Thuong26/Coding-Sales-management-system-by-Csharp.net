namespace QLBH
{
    partial class frmHH
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
            this.button1 = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.txbNhapTMH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvHN = new System.Windows.Forms.DataGridView();
            this.txbTNDH = new System.Windows.Forms.TextBox();
            this.txbMH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numSLH = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txbDVT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbDG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btTracuu = new System.Windows.Forms.Button();
            this.cbTraCuuMH = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLH)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 22);
            this.button1.TabIndex = 33;
            this.button1.Text = "Bỏ qua";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(400, 487);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(52, 22);
            this.btthem.TabIndex = 32;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(518, 237);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(67, 22);
            this.btLuu.TabIndex = 31;
            this.btLuu.Text = "Tìm tất cả";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(520, 487);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(56, 22);
            this.btxoa.TabIndex = 30;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(458, 487);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(56, 22);
            this.btSua.TabIndex = 29;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click_1);
            // 
            // bttimkiem
            // 
            this.bttimkiem.Location = new System.Drawing.Point(306, 487);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(83, 22);
            this.bttimkiem.TabIndex = 28;
            this.bttimkiem.Text = "Tìm kiếm";
            this.bttimkiem.UseVisualStyleBackColor = true;
            this.bttimkiem.Click += new System.EventHandler(this.bttimkiem_Click);
            // 
            // txbNhapTMH
            // 
            this.txbNhapTMH.Location = new System.Drawing.Point(116, 487);
            this.txbNhapTMH.Name = "txbNhapTMH";
            this.txbNhapTMH.Size = new System.Drawing.Size(178, 20);
            this.txbNhapTMH.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nhập tên mặt hàng:";
            // 
            // dgvHN
            // 
            this.dgvHN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvHN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHN.Location = new System.Drawing.Point(12, 265);
            this.dgvHN.Name = "dgvHN";
            this.dgvHN.RowHeadersWidth = 51;
            this.dgvHN.Size = new System.Drawing.Size(707, 201);
            this.dgvHN.TabIndex = 22;
            this.dgvHN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHN_CellContentClick);
            // 
            // txbTNDH
            // 
            this.txbTNDH.Location = new System.Drawing.Point(93, 118);
            this.txbTNDH.Name = "txbTNDH";
            this.txbTNDH.Size = new System.Drawing.Size(214, 20);
            this.txbTNDH.TabIndex = 21;
            // 
            // txbMH
            // 
            this.txbMH.Location = new System.Drawing.Point(93, 83);
            this.txbMH.Name = "txbMH";
            this.txbMH.Size = new System.Drawing.Size(214, 20);
            this.txbMH.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên mặt hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Danh Mục Hàng Hóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Số Lượng";
            // 
            // numSLH
            // 
            this.numSLH.Location = new System.Drawing.Point(505, 84);
            this.numSLH.Name = "numSLH";
            this.numSLH.Size = new System.Drawing.Size(214, 20);
            this.numSLH.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Đơn vị tính:";
            // 
            // txbDVT
            // 
            this.txbDVT.Location = new System.Drawing.Point(505, 121);
            this.txbDVT.Name = "txbDVT";
            this.txbDVT.Size = new System.Drawing.Size(214, 20);
            this.txbDVT.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Đơn giá:";
            // 
            // txbDG
            // 
            this.txbDG.Location = new System.Drawing.Point(505, 159);
            this.txbDG.Name = "txbDG";
            this.txbDG.Size = new System.Drawing.Size(214, 20);
            this.txbDG.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Tra cứu mã hàng:";
            // 
            // btTracuu
            // 
            this.btTracuu.Location = new System.Drawing.Point(653, 237);
            this.btTracuu.Name = "btTracuu";
            this.btTracuu.Size = new System.Drawing.Size(66, 22);
            this.btTracuu.TabIndex = 41;
            this.btTracuu.Text = "Tra cứu";
            this.btTracuu.UseVisualStyleBackColor = true;
            this.btTracuu.Click += new System.EventHandler(this.btTracuu_Click);
            // 
            // cbTraCuuMH
            // 
            this.cbTraCuuMH.Location = new System.Drawing.Point(505, 199);
            this.cbTraCuuMH.Margin = new System.Windows.Forms.Padding(2);
            this.cbTraCuuMH.Name = "cbTraCuuMH";
            this.cbTraCuuMH.Size = new System.Drawing.Size(214, 20);
            this.cbTraCuuMH.TabIndex = 42;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(590, 237);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(58, 22);
            this.btn_reset.TabIndex = 43;
            this.btn_reset.Text = "Làm mới";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btQL
            // 
            this.btQL.Location = new System.Drawing.Point(652, 487);
            this.btQL.Name = "btQL";
            this.btQL.Size = new System.Drawing.Size(66, 22);
            this.btQL.TabIndex = 44;
            this.btQL.Text = "Quay lại";
            this.btQL.UseVisualStyleBackColor = true;
            this.btQL.Click += new System.EventHandler(this.btQL_Click_1);
            // 
            // frmHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 530);
            this.Controls.Add(this.btQL);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.cbTraCuuMH);
            this.Controls.Add(this.btTracuu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbDG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbDVT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numSLH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.bttimkiem);
            this.Controls.Add(this.txbNhapTMH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvHN);
            this.Controls.Add(this.txbTNDH);
            this.Controls.Add(this.txbMH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hàng Hóa";
            this.Load += new System.EventHandler(this.frmHH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.TextBox txbNhapTMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvHN;
        private System.Windows.Forms.TextBox txbTNDH;
        private System.Windows.Forms.TextBox txbMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSLH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbDVT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbDG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btTracuu;
        private System.Windows.Forms.TextBox cbTraCuuMH;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btQL;
    }
}