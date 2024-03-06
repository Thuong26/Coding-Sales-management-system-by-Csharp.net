namespace QLBH
{
    partial class frmNhap
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
            this.label7 = new System.Windows.Forms.Label();
            this.btQL = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.txbMBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maNDH = new System.Windows.Forms.ComboBox();
            this.maNN = new System.Windows.Forms.ComboBox();
            this.maQL = new System.Windows.Forms.ComboBox();
            this.thanhtien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.maNCC = new System.Windows.Forms.ComboBox();
            this.maDVCC = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_NCT = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 102;
            this.label7.Text = "Mã đơn vị vận chuyển";
            // 
            // btQL
            // 
            this.btQL.Location = new System.Drawing.Point(663, 472);
            this.btQL.Name = "btQL";
            this.btQL.Size = new System.Drawing.Size(66, 22);
            this.btQL.TabIndex = 101;
            this.btQL.Text = "Quay lại";
            this.btQL.UseVisualStyleBackColor = true;
            this.btQL.Click += new System.EventHandler(this.btQL_Click_1);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(410, 472);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(52, 22);
            this.btthem.TabIndex = 100;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(529, 472);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(56, 22);
            this.btxoa.TabIndex = 98;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(467, 472);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(56, 22);
            this.btSua.TabIndex = 97;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Mã nhà cung cấp";
            // 
            // dgvNCC
            // 
            this.dgvNCC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Location = new System.Drawing.Point(12, 214);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersWidth = 51;
            this.dgvNCC.Size = new System.Drawing.Size(717, 248);
            this.dgvNCC.TabIndex = 92;
            this.dgvNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellContentClick);
            // 
            // txbMBN
            // 
            this.txbMBN.Location = new System.Drawing.Point(109, 65);
            this.txbMBN.Name = "txbMBN";
            this.txbMBN.Size = new System.Drawing.Size(213, 20);
            this.txbMBN.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Mã người đặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Mã biên nhận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 30);
            this.label1.TabIndex = 87;
            this.label1.Text = "Danh Mục Phiếu Nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 108;
            this.label6.Text = "Mã người nhận";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 110;
            this.label9.Text = "Mã người quản lý";
            // 
            // maNDH
            // 
            this.maNDH.FormattingEnabled = true;
            this.maNDH.Location = new System.Drawing.Point(109, 99);
            this.maNDH.Name = "maNDH";
            this.maNDH.Size = new System.Drawing.Size(213, 21);
            this.maNDH.TabIndex = 111;
            // 
            // maNN
            // 
            this.maNN.FormattingEnabled = true;
            this.maNN.Location = new System.Drawing.Point(109, 137);
            this.maNN.Name = "maNN";
            this.maNN.Size = new System.Drawing.Size(213, 21);
            this.maNN.TabIndex = 112;
            // 
            // maQL
            // 
            this.maQL.FormattingEnabled = true;
            this.maQL.Location = new System.Drawing.Point(109, 172);
            this.maQL.Name = "maQL";
            this.maQL.Size = new System.Drawing.Size(213, 21);
            this.maQL.TabIndex = 113;
            // 
            // thanhtien
            // 
            this.thanhtien.Location = new System.Drawing.Point(501, 134);
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.Size = new System.Drawing.Size(228, 20);
            this.thanhtien.TabIndex = 116;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 115;
            this.label10.Text = "Thành tiền";
            // 
            // maNCC
            // 
            this.maNCC.FormattingEnabled = true;
            this.maNCC.Location = new System.Drawing.Point(501, 67);
            this.maNCC.Name = "maNCC";
            this.maNCC.Size = new System.Drawing.Size(228, 21);
            this.maNCC.TabIndex = 118;
            // 
            // maDVCC
            // 
            this.maDVCC.FormattingEnabled = true;
            this.maDVCC.Location = new System.Drawing.Point(501, 99);
            this.maDVCC.Name = "maDVCC";
            this.maDVCC.Size = new System.Drawing.Size(228, 21);
            this.maDVCC.TabIndex = 119;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 22);
            this.button1.TabIndex = 120;
            this.button1.Text = "Bỏ qua";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_NCT
            // 
            this.btn_NCT.Location = new System.Drawing.Point(14, 472);
            this.btn_NCT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NCT.Name = "btn_NCT";
            this.btn_NCT.Size = new System.Drawing.Size(124, 21);
            this.btn_NCT.TabIndex = 123;
            this.btn_NCT.Text = "Thêm nhập chi tiết";
            this.btn_NCT.UseVisualStyleBackColor = true;
            this.btn_NCT.Click += new System.EventHandler(this.btn_NCT_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(677, 172);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(52, 22);
            this.btn_refresh.TabIndex = 124;
            this.btn_refresh.Text = "Tải lại";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // frmNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 504);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_NCT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maDVCC);
            this.Controls.Add(this.maNCC);
            this.Controls.Add(this.thanhtien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.maQL);
            this.Controls.Add(this.maNN);
            this.Controls.Add(this.maNDH);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btQL);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvNCC);
            this.Controls.Add(this.txbMBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu nhập";
            this.Load += new System.EventHandler(this.frmNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btQL;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.TextBox txbMBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox maNDH;
        private System.Windows.Forms.ComboBox maNN;
        private System.Windows.Forms.ComboBox maQL;
        private System.Windows.Forms.TextBox thanhtien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox maNCC;
        private System.Windows.Forms.ComboBox maDVCC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_NCT;
        private System.Windows.Forms.Button btn_refresh;
    }
}