namespace QLBH
{
    partial class frmQL
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
            this.txbNhapTQL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btTracuu = new System.Windows.Forms.Button();
            this.txbTracuuQL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvQL = new System.Windows.Forms.DataGridView();
            this.txbTQL = new System.Windows.Forms.TextBox();
            this.txbMQL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQL)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 22);
            this.button1.TabIndex = 33;
            this.button1.Text = "Bỏ qua";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(420, 446);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(52, 22);
            this.btthem.TabIndex = 32;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(579, 107);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(68, 22);
            this.btLuu.TabIndex = 31;
            this.btLuu.Text = "Tìm tất cả";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(540, 446);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(56, 22);
            this.btxoa.TabIndex = 30;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(478, 446);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(56, 22);
            this.btSua.TabIndex = 29;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // bttimkiem
            // 
            this.bttimkiem.Location = new System.Drawing.Point(345, 446);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(65, 22);
            this.bttimkiem.TabIndex = 28;
            this.bttimkiem.Text = "Tìm kiếm";
            this.bttimkiem.UseVisualStyleBackColor = true;
            this.bttimkiem.Click += new System.EventHandler(this.bttimkiem_Click);
            // 
            // txbNhapTQL
            // 
            this.txbNhapTQL.Location = new System.Drawing.Point(138, 446);
            this.txbNhapTQL.Name = "txbNhapTQL";
            this.txbNhapTQL.Size = new System.Drawing.Size(160, 20);
            this.txbNhapTQL.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Nhập tên người quản lý:";
            // 
            // btTracuu
            // 
            this.btTracuu.Location = new System.Drawing.Point(660, 107);
            this.btTracuu.Name = "btTracuu";
            this.btTracuu.Size = new System.Drawing.Size(83, 22);
            this.btTracuu.TabIndex = 25;
            this.btTracuu.Text = "Tra cứu";
            this.btTracuu.UseVisualStyleBackColor = true;
            this.btTracuu.Click += new System.EventHandler(this.btTracuu_Click);
            // 
            // txbTracuuQL
            // 
            this.txbTracuuQL.Location = new System.Drawing.Point(529, 69);
            this.txbTracuuQL.Name = "txbTracuuQL";
            this.txbTracuuQL.Size = new System.Drawing.Size(214, 20);
            this.txbTracuuQL.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tra cứu mã người quản lý:";
            // 
            // dgvQL
            // 
            this.dgvQL.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQL.Location = new System.Drawing.Point(11, 135);
            this.dgvQL.Name = "dgvQL";
            this.dgvQL.RowHeadersWidth = 51;
            this.dgvQL.Size = new System.Drawing.Size(740, 287);
            this.dgvQL.TabIndex = 22;
            this.dgvQL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQL_CellContentClick);
            // 
            // txbTQL
            // 
            this.txbTQL.Location = new System.Drawing.Point(160, 96);
            this.txbTQL.Name = "txbTQL";
            this.txbTQL.Size = new System.Drawing.Size(214, 20);
            this.txbTQL.TabIndex = 21;
            // 
            // txbMQL
            // 
            this.txbMQL.Location = new System.Drawing.Point(160, 61);
            this.txbMQL.Name = "txbMQL";
            this.txbMQL.Size = new System.Drawing.Size(214, 20);
            this.txbMQL.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên người quản lý:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã người quản lý:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Danh Mục Nhân Viên Quản Lý";
            // 
            // btQL
            // 
            this.btQL.Location = new System.Drawing.Point(677, 446);
            this.btQL.Name = "btQL";
            this.btQL.Size = new System.Drawing.Size(66, 22);
            this.btQL.TabIndex = 34;
            this.btQL.Text = "Quay lại";
            this.btQL.UseVisualStyleBackColor = true;
            this.btQL.Click += new System.EventHandler(this.btQL_Click_1);
            // 
            // frmQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 483);
            this.Controls.Add(this.btQL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.bttimkiem);
            this.Controls.Add(this.txbNhapTQL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btTracuu);
            this.Controls.Add(this.txbTracuuQL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvQL);
            this.Controls.Add(this.txbTQL);
            this.Controls.Add(this.txbMQL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DM nhân viên quản lý";
            this.Load += new System.EventHandler(this.frmQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQL)).EndInit();
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
        private System.Windows.Forms.TextBox txbNhapTQL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btTracuu;
        private System.Windows.Forms.TextBox txbTracuuQL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvQL;
        private System.Windows.Forms.TextBox txbTQL;
        private System.Windows.Forms.TextBox txbMQL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btQL;
    }
}