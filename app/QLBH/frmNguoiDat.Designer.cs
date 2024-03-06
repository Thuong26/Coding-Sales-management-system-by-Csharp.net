namespace QLBH
{
    partial class frmNguoiDat
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
            this.label3 = new System.Windows.Forms.Label();
            this.maNDH = new System.Windows.Forms.TextBox();
            this.txbTNDH = new System.Windows.Forms.TextBox();
            this.dgvNDH = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTracuu = new System.Windows.Forms.TextBox();
            this.btTracuu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNhapNDH = new System.Windows.Forms.TextBox();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNDH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Người Đặt Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã người đặt hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên người đặt hàng:";
            // 
            // maNDH
            // 
            this.maNDH.Location = new System.Drawing.Point(133, 61);
            this.maNDH.Name = "maNDH";
            this.maNDH.Size = new System.Drawing.Size(214, 20);
            this.maNDH.TabIndex = 3;
            // 
            // txbTNDH
            // 
            this.txbTNDH.Location = new System.Drawing.Point(133, 96);
            this.txbTNDH.Name = "txbTNDH";
            this.txbTNDH.Size = new System.Drawing.Size(214, 20);
            this.txbTNDH.TabIndex = 4;
            // 
            // dgvNDH
            // 
            this.dgvNDH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvNDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNDH.Location = new System.Drawing.Point(12, 138);
            this.dgvNDH.Name = "dgvNDH";
            this.dgvNDH.RowHeadersWidth = 51;
            this.dgvNDH.Size = new System.Drawing.Size(753, 287);
            this.dgvNDH.TabIndex = 5;
            this.dgvNDH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNDH_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tra cứu mã người đặt";
            // 
            // txbTracuu
            // 
            this.txbTracuu.Location = new System.Drawing.Point(551, 64);
            this.txbTracuu.Name = "txbTracuu";
            this.txbTracuu.Size = new System.Drawing.Size(214, 20);
            this.txbTracuu.TabIndex = 7;
            // 
            // btTracuu
            // 
            this.btTracuu.Location = new System.Drawing.Point(682, 103);
            this.btTracuu.Name = "btTracuu";
            this.btTracuu.Size = new System.Drawing.Size(83, 22);
            this.btTracuu.TabIndex = 8;
            this.btTracuu.Text = "Tra cứu";
            this.btTracuu.UseVisualStyleBackColor = true;
            this.btTracuu.Click += new System.EventHandler(this.btTracuu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhập tên người đặt hàng:";
            // 
            // txbNhapNDH
            // 
            this.txbNhapNDH.Location = new System.Drawing.Point(157, 449);
            this.txbNhapNDH.Name = "txbNhapNDH";
            this.txbNhapNDH.Size = new System.Drawing.Size(190, 20);
            this.txbNhapNDH.TabIndex = 10;
            // 
            // bttimkiem
            // 
            this.bttimkiem.Location = new System.Drawing.Point(348, 447);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(83, 22);
            this.bttimkiem.TabIndex = 11;
            this.bttimkiem.Text = "Tìm kiếm";
            this.bttimkiem.UseVisualStyleBackColor = true;
            this.bttimkiem.Click += new System.EventHandler(this.bttimkiem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(495, 447);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(56, 22);
            this.btSua.TabIndex = 12;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(557, 447);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(56, 22);
            this.btxoa.TabIndex = 13;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(588, 103);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(74, 22);
            this.btLuu.TabIndex = 14;
            this.btLuu.Text = "Tìm tất cả";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(437, 447);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(52, 22);
            this.btthem.TabIndex = 15;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 22);
            this.button1.TabIndex = 16;
            this.button1.Text = "Bỏ qua";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btQL
            // 
            this.btQL.Location = new System.Drawing.Point(691, 447);
            this.btQL.Name = "btQL";
            this.btQL.Size = new System.Drawing.Size(66, 22);
            this.btQL.TabIndex = 35;
            this.btQL.Text = "Quay lại";
            this.btQL.UseVisualStyleBackColor = true;
            this.btQL.Click += new System.EventHandler(this.btQL_Click_1);
            // 
            // frmNguoiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 481);
            this.Controls.Add(this.btQL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.bttimkiem);
            this.Controls.Add(this.txbNhapNDH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btTracuu);
            this.Controls.Add(this.txbTracuu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvNDH);
            this.Controls.Add(this.txbTNDH);
            this.Controls.Add(this.maNDH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNguoiDat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục người đặt hàng";
            this.Load += new System.EventHandler(this.frmNguoiDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maNDH;
        private System.Windows.Forms.TextBox txbTNDH;
        private System.Windows.Forms.DataGridView dgvNDH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTracuu;
        private System.Windows.Forms.Button btTracuu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNhapNDH;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btQL;
    }
}