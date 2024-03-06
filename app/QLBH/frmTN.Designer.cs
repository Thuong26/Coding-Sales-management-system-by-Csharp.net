namespace QLBH
{
    partial class frmTN
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
            this.txbNhapTTN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btTracuu = new System.Windows.Forms.Button();
            this.txbTracuuMTN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.txbTTN = new System.Windows.Forms.TextBox();
            this.txbMTN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 22);
            this.button1.TabIndex = 50;
            this.button1.Text = "Bỏ qua";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(458, 463);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(52, 22);
            this.btthem.TabIndex = 49;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(607, 119);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(79, 22);
            this.btLuu.TabIndex = 48;
            this.btLuu.Text = "Tìm tất cả";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(582, 463);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(56, 22);
            this.btxoa.TabIndex = 47;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(520, 463);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(56, 22);
            this.btSua.TabIndex = 46;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // bttimkiem
            // 
            this.bttimkiem.Location = new System.Drawing.Point(372, 463);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(83, 22);
            this.bttimkiem.TabIndex = 45;
            this.bttimkiem.Text = "Tìm kiếm";
            this.bttimkiem.UseVisualStyleBackColor = true;
            this.bttimkiem.Click += new System.EventHandler(this.bttimkiem_Click);
            // 
            // txbNhapTTN
            // 
            this.txbNhapTTN.Location = new System.Drawing.Point(152, 463);
            this.txbNhapTTN.Name = "txbNhapTTN";
            this.txbNhapTTN.Size = new System.Drawing.Size(201, 20);
            this.txbNhapTTN.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Nhập tên thu ngân:";
            // 
            // btTracuu
            // 
            this.btTracuu.Location = new System.Drawing.Point(697, 119);
            this.btTracuu.Name = "btTracuu";
            this.btTracuu.Size = new System.Drawing.Size(83, 22);
            this.btTracuu.TabIndex = 42;
            this.btTracuu.Text = "Tra cứu";
            this.btTracuu.UseVisualStyleBackColor = true;
            this.btTracuu.Click += new System.EventHandler(this.btTracuu_Click);
            // 
            // txbTracuuMTN
            // 
            this.txbTracuuMTN.Location = new System.Drawing.Point(566, 80);
            this.txbTracuuMTN.Name = "txbTracuuMTN";
            this.txbTracuuMTN.Size = new System.Drawing.Size(214, 20);
            this.txbTracuuMTN.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Tra cứu mã thu ngân:";
            // 
            // dgvTN
            // 
            this.dgvTN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTN.Location = new System.Drawing.Point(7, 157);
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.RowHeadersWidth = 51;
            this.dgvTN.Size = new System.Drawing.Size(773, 287);
            this.dgvTN.TabIndex = 39;
            this.dgvTN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTN_CellContentClick);
            // 
            // txbTTN
            // 
            this.txbTTN.Location = new System.Drawing.Point(139, 118);
            this.txbTTN.Name = "txbTTN";
            this.txbTTN.Size = new System.Drawing.Size(214, 20);
            this.txbTTN.TabIndex = 38;
            // 
            // txbMTN
            // 
            this.txbMTN.Location = new System.Drawing.Point(139, 83);
            this.txbMTN.Name = "txbMTN";
            this.txbMTN.Size = new System.Drawing.Size(214, 20);
            this.txbMTN.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tên thu ngân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Mã thu ngân:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 30);
            this.label1.TabIndex = 34;
            this.label1.Text = "Danh Mục Nhân Viên Thu Ngân";
            // 
            // btQL
            // 
            this.btQL.Location = new System.Drawing.Point(716, 463);
            this.btQL.Name = "btQL";
            this.btQL.Size = new System.Drawing.Size(66, 22);
            this.btQL.TabIndex = 51;
            this.btQL.Text = "Quay lại";
            this.btQL.UseVisualStyleBackColor = true;
            this.btQL.Click += new System.EventHandler(this.btQL_Click_1);
            // 
            // frmTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 503);
            this.Controls.Add(this.btQL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.bttimkiem);
            this.Controls.Add(this.txbNhapTTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btTracuu);
            this.Controls.Add(this.txbTracuuMTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvTN);
            this.Controls.Add(this.txbTTN);
            this.Controls.Add(this.txbMTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thu Ngân";
            this.Load += new System.EventHandler(this.frmTN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
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
        private System.Windows.Forms.TextBox txbNhapTTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btTracuu;
        private System.Windows.Forms.TextBox txbTracuuMTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTN;
        private System.Windows.Forms.TextBox txbTTN;
        private System.Windows.Forms.TextBox txbMTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btQL;
    }
}