namespace QLBH
{
    partial class frmMN
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
            this.btTracuu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.bttimkiem = new System.Windows.Forms.Button();
            this.txbNhapTMN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMN = new System.Windows.Forms.DataGridView();
            this.txbTMN = new System.Windows.Forms.TextBox();
            this.txbMM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbDG = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.cbTraCuuMM = new System.Windows.Forms.ComboBox();
            this.btQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMN)).BeginInit();
            this.SuspendLayout();
            // 
            // btTracuu
            // 
            this.btTracuu.Location = new System.Drawing.Point(641, 147);
            this.btTracuu.Name = "btTracuu";
            this.btTracuu.Size = new System.Drawing.Size(66, 22);
            this.btTracuu.TabIndex = 64;
            this.btTracuu.Text = "Tra cứu";
            this.btTracuu.UseVisualStyleBackColor = true;
            this.btTracuu.Click += new System.EventHandler(this.btTracuu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Tra cứu mã món:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 22);
            this.button1.TabIndex = 56;
            this.button1.Text = "Bỏ qua";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(398, 476);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(52, 22);
            this.btthem.TabIndex = 55;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(473, 147);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(74, 22);
            this.btLuu.TabIndex = 54;
            this.btLuu.Text = "Tìm tất cả";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(518, 476);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(56, 22);
            this.btxoa.TabIndex = 53;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(456, 476);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(56, 22);
            this.btSua.TabIndex = 52;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // bttimkiem
            // 
            this.bttimkiem.Location = new System.Drawing.Point(310, 476);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(83, 22);
            this.bttimkiem.TabIndex = 51;
            this.bttimkiem.Text = "Tìm kiếm";
            this.bttimkiem.UseVisualStyleBackColor = true;
            this.bttimkiem.Click += new System.EventHandler(this.bttimkiem_Click);
            // 
            // txbNhapTMN
            // 
            this.txbNhapTMN.Location = new System.Drawing.Point(129, 474);
            this.txbNhapTMN.Name = "txbNhapTMN";
            this.txbNhapTMN.Size = new System.Drawing.Size(171, 20);
            this.txbNhapTMN.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Nhập tên món nước:";
            // 
            // dgvMN
            // 
            this.dgvMN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvMN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMN.Location = new System.Drawing.Point(9, 175);
            this.dgvMN.Name = "dgvMN";
            this.dgvMN.RowHeadersWidth = 51;
            this.dgvMN.Size = new System.Drawing.Size(712, 282);
            this.dgvMN.TabIndex = 47;
            this.dgvMN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMN_CellContentClick);
            // 
            // txbTMN
            // 
            this.txbTMN.Location = new System.Drawing.Point(86, 109);
            this.txbTMN.Name = "txbTMN";
            this.txbTMN.Size = new System.Drawing.Size(214, 20);
            this.txbTMN.TabIndex = 46;
            // 
            // txbMM
            // 
            this.txbMM.Location = new System.Drawing.Point(86, 74);
            this.txbMM.Name = "txbMM";
            this.txbMM.Size = new System.Drawing.Size(214, 20);
            this.txbMM.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Tên món:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Mã món:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 30);
            this.label1.TabIndex = 42;
            this.label1.Text = "Danh Mục Món Nước";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Đơn giá:";
            // 
            // txbDG
            // 
            this.txbDG.Location = new System.Drawing.Point(490, 77);
            this.txbDG.Name = "txbDG";
            this.txbDG.Size = new System.Drawing.Size(214, 20);
            this.txbDG.TabIndex = 61;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(558, 147);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(74, 22);
            this.btn_reset.TabIndex = 65;
            this.btn_reset.Text = "Làm mới";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // cbTraCuuMM
            // 
            this.cbTraCuuMM.FormattingEnabled = true;
            this.cbTraCuuMM.Location = new System.Drawing.Point(490, 112);
            this.cbTraCuuMM.Name = "cbTraCuuMM";
            this.cbTraCuuMM.Size = new System.Drawing.Size(214, 21);
            this.cbTraCuuMM.TabIndex = 63;
            // 
            // btQL
            // 
            this.btQL.Location = new System.Drawing.Point(652, 476);
            this.btQL.Name = "btQL";
            this.btQL.Size = new System.Drawing.Size(66, 22);
            this.btQL.TabIndex = 66;
            this.btQL.Text = "Quay lại";
            this.btQL.UseVisualStyleBackColor = true;
            this.btQL.Click += new System.EventHandler(this.btQL_Click_1);
            // 
            // frmMN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 529);
            this.Controls.Add(this.btQL);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btTracuu);
            this.Controls.Add(this.cbTraCuuMM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbDG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.bttimkiem);
            this.Controls.Add(this.txbNhapTMN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvMN);
            this.Controls.Add(this.txbTMN);
            this.Controls.Add(this.txbMM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Món nước";
            this.Load += new System.EventHandler(this.frmMN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTracuu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button bttimkiem;
        private System.Windows.Forms.TextBox txbNhapTMN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvMN;
        private System.Windows.Forms.TextBox txbTMN;
        private System.Windows.Forms.TextBox txbMM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbDG;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ComboBox cbTraCuuMM;
        private System.Windows.Forms.Button btQL;
    }
}