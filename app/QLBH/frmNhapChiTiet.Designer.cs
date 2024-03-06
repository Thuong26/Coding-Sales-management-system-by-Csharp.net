namespace QLBH
{
    partial class frmNhapChiTiet
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
            this.cancle = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.numSl = new System.Windows.Forms.NumericUpDown();
            this.txbGC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txbMH = new System.Windows.Forms.ComboBox();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.txbMNCT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDG = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // cancle
            // 
            this.cancle.Location = new System.Drawing.Point(555, 476);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(66, 22);
            this.cancle.TabIndex = 173;
            this.cancle.Text = "Bỏ qua";
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.cancle_Click_1);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(627, 476);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(66, 22);
            this.back.TabIndex = 172;
            this.back.Text = "Quay lại";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click_1);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(374, 476);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(52, 22);
            this.btthem.TabIndex = 171;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(493, 476);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(56, 22);
            this.btxoa.TabIndex = 170;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(431, 476);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(56, 22);
            this.btSua.TabIndex = 169;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // numSl
            // 
            this.numSl.Location = new System.Drawing.Point(465, 64);
            this.numSl.Name = "numSl";
            this.numSl.Size = new System.Drawing.Size(228, 20);
            this.numSl.TabIndex = 168;
            // 
            // txbGC
            // 
            this.txbGC.Location = new System.Drawing.Point(465, 188);
            this.txbGC.Name = "txbGC";
            this.txbGC.Size = new System.Drawing.Size(228, 20);
            this.txbGC.TabIndex = 167;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 166;
            this.label4.Text = "Ghi chú";
            // 
            // txbTT
            // 
            this.txbTT.Location = new System.Drawing.Point(465, 149);
            this.txbTT.Name = "txbTT";
            this.txbTT.Size = new System.Drawing.Size(228, 20);
            this.txbTT.TabIndex = 163;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 162;
            this.label10.Text = "Thành tiền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(382, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 161;
            this.label11.Text = "Số lượng";
            // 
            // txbMH
            // 
            this.txbMH.FormattingEnabled = true;
            this.txbMH.Location = new System.Drawing.Point(108, 107);
            this.txbMH.Name = "txbMH";
            this.txbMH.Size = new System.Drawing.Size(213, 21);
            this.txbMH.TabIndex = 160;
            // 
            // dgvNCC
            // 
            this.dgvNCC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Location = new System.Drawing.Point(11, 223);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersWidth = 51;
            this.dgvNCC.Size = new System.Drawing.Size(682, 247);
            this.dgvNCC.TabIndex = 159;
            // 
            // txbMNCT
            // 
            this.txbMNCT.Location = new System.Drawing.Point(108, 73);
            this.txbMNCT.Name = "txbMNCT";
            this.txbMNCT.Size = new System.Drawing.Size(213, 20);
            this.txbMNCT.TabIndex = 158;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 157;
            this.label3.Text = "Mã hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 156;
            this.label2.Text = "Mã biên nhận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 155;
            this.label1.Text = "Phiếu Nhập Chi Tiết";
            // 
            // txbDG
            // 
            this.txbDG.Location = new System.Drawing.Point(465, 103);
            this.txbDG.Name = "txbDG";
            this.txbDG.Size = new System.Drawing.Size(228, 20);
            this.txbDG.TabIndex = 175;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 174;
            this.label7.Text = "Đơn giá:";
            // 
            // frmNhapChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 513);
            this.Controls.Add(this.txbDG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.back);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.numSl);
            this.Controls.Add(this.txbGC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbTT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txbMH);
            this.Controls.Add(this.dgvNCC);
            this.Controls.Add(this.txbMNCT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNhapChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu nhập chi tiết";
            this.Load += new System.EventHandler(this.frmNhapChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancle;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.NumericUpDown numSl;
        private System.Windows.Forms.TextBox txbGC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txbMH;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.TextBox txbMNCT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDG;
        private System.Windows.Forms.Label label7;
    }
}