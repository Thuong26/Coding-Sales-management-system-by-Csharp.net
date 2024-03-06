namespace QLBH
{
    partial class frmNguoiNhanHang
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
            this.txbNhapNN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btTracuu = new System.Windows.Forms.Button();
            this.txbTracuuNN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvNN = new System.Windows.Forms.DataGridView();
            this.txbTNN = new System.Windows.Forms.TextBox();
            this.txbMNN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNN)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 22);
            this.button1.TabIndex = 33;
            this.button1.Text = "Bỏ qua";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(467, 463);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(52, 22);
            this.btthem.TabIndex = 32;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(613, 119);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(66, 22);
            this.btLuu.TabIndex = 31;
            this.btLuu.Text = "Tìm tất cả";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(587, 463);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(56, 22);
            this.btxoa.TabIndex = 30;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(525, 463);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(56, 22);
            this.btSua.TabIndex = 29;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // bttimkiem
            // 
            this.bttimkiem.Location = new System.Drawing.Point(378, 463);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(83, 22);
            this.bttimkiem.TabIndex = 28;
            this.bttimkiem.Text = "Tìm kiếm";
            this.bttimkiem.UseVisualStyleBackColor = true;
            this.bttimkiem.Click += new System.EventHandler(this.bttimkiem_Click);
            // 
            // txbNhapNN
            // 
            this.txbNhapNN.Location = new System.Drawing.Point(171, 463);
            this.txbNhapNN.Name = "txbNhapNN";
            this.txbNhapNN.Size = new System.Drawing.Size(201, 20);
            this.txbNhapNN.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nhập tên người nhận:";
            // 
            // btTracuu
            // 
            this.btTracuu.Location = new System.Drawing.Point(696, 119);
            this.btTracuu.Name = "btTracuu";
            this.btTracuu.Size = new System.Drawing.Size(83, 22);
            this.btTracuu.TabIndex = 25;
            this.btTracuu.Text = "Tra cứu";
            this.btTracuu.UseVisualStyleBackColor = true;
            this.btTracuu.Click += new System.EventHandler(this.btTracuu_Click);
            // 
            // txbTracuuNN
            // 
            this.txbTracuuNN.Location = new System.Drawing.Point(565, 80);
            this.txbTracuuNN.Name = "txbTracuuNN";
            this.txbTracuuNN.Size = new System.Drawing.Size(214, 20);
            this.txbTracuuNN.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tra cứu mã người nhận:";
            // 
            // dgvNN
            // 
            this.dgvNN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvNN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNN.Location = new System.Drawing.Point(26, 157);
            this.dgvNN.Name = "dgvNN";
            this.dgvNN.RowHeadersWidth = 51;
            this.dgvNN.Size = new System.Drawing.Size(766, 287);
            this.dgvNN.TabIndex = 22;
            this.dgvNN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNN_CellContentClick);
            // 
            // txbTNN
            // 
            this.txbTNN.Location = new System.Drawing.Point(158, 118);
            this.txbTNN.Name = "txbTNN";
            this.txbTNN.Size = new System.Drawing.Size(214, 20);
            this.txbTNN.TabIndex = 21;
            // 
            // txbMNN
            // 
            this.txbMNN.Location = new System.Drawing.Point(158, 83);
            this.txbMNN.Name = "txbMNN";
            this.txbMNN.Size = new System.Drawing.Size(214, 20);
            this.txbMNN.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên người nhận hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã người nhận hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Danh Mục Người Nhận Hàng";
            // 
            // btQL
            // 
            this.btQL.Location = new System.Drawing.Point(721, 463);
            this.btQL.Name = "btQL";
            this.btQL.Size = new System.Drawing.Size(66, 22);
            this.btQL.TabIndex = 35;
            this.btQL.Text = "Quay lại";
            this.btQL.UseVisualStyleBackColor = true;
            this.btQL.Click += new System.EventHandler(this.btQL_Click);
            // 
            // frmNguoiNhanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 512);
            this.Controls.Add(this.btQL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.bttimkiem);
            this.Controls.Add(this.txbNhapNN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btTracuu);
            this.Controls.Add(this.txbTracuuNN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvNN);
            this.Controls.Add(this.txbTNN);
            this.Controls.Add(this.txbMNN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNguoiNhanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người nhận hàng";
            this.Load += new System.EventHandler(this.frmNguoiNhanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNN)).EndInit();
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
        private System.Windows.Forms.TextBox txbNhapNN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btTracuu;
        private System.Windows.Forms.TextBox txbTracuuNN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvNN;
        private System.Windows.Forms.TextBox txbTNN;
        private System.Windows.Forms.TextBox txbMNN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btQL;
    }
}