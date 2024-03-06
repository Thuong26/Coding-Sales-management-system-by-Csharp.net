namespace QLBH
{
    partial class frmXuatChiTiet
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.txbTT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txbMM = new System.Windows.Forms.ComboBox();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.txbMXCT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(566, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 22);
            this.button2.TabIndex = 174;
            this.button2.Text = "Bỏ qua";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 22);
            this.button1.TabIndex = 173;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(375, 465);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(52, 22);
            this.btthem.TabIndex = 172;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(494, 465);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(56, 22);
            this.btxoa.TabIndex = 170;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(432, 465);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(56, 22);
            this.btSua.TabIndex = 169;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(476, 64);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(228, 20);
            this.numSL.TabIndex = 168;
            this.numSL.ValueChanged += new System.EventHandler(this.numSL_ValueChanged);
            // 
            // txbTT
            // 
            this.txbTT.Location = new System.Drawing.Point(476, 96);
            this.txbTT.Name = "txbTT";
            this.txbTT.Size = new System.Drawing.Size(228, 20);
            this.txbTT.TabIndex = 163;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 162;
            this.label10.Text = "Thành tiền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(409, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 161;
            this.label11.Text = "Số lượng";
            // 
            // txbMM
            // 
            this.txbMM.FormattingEnabled = true;
            this.txbMM.Location = new System.Drawing.Point(109, 96);
            this.txbMM.Name = "txbMM";
            this.txbMM.Size = new System.Drawing.Size(213, 21);
            this.txbMM.TabIndex = 160;
            this.txbMM.SelectedIndexChanged += new System.EventHandler(this.txbMM_SelectedIndexChanged);
            // 
            // dgvNCC
            // 
            this.dgvNCC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Location = new System.Drawing.Point(12, 135);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersWidth = 51;
            this.dgvNCC.Size = new System.Drawing.Size(692, 324);
            this.dgvNCC.TabIndex = 159;
            this.dgvNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellContentClick);
            // 
            // txbMXCT
            // 
            this.txbMXCT.Location = new System.Drawing.Point(109, 62);
            this.txbMXCT.Name = "txbMXCT";
            this.txbMXCT.Size = new System.Drawing.Size(213, 20);
            this.txbMXCT.TabIndex = 158;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 157;
            this.label3.Text = "Mã món";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 156;
            this.label2.Text = "Mã đơn thanh toán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 30);
            this.label1.TabIndex = 155;
            this.label1.Text = "Phiếu Xuất Chi Tiết";
            // 
            // frmXuatChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 496);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.txbTT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbMM);
            this.Controls.Add(this.dgvNCC);
            this.Controls.Add(this.txbMXCT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmXuatChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu xuất chi tiết";
            this.Load += new System.EventHandler(this.frmXuatChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.TextBox txbTT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txbMM;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.TextBox txbMXCT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}