namespace QLBH
{
    partial class Form1
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
            this.btban = new System.Windows.Forms.Button();
            this.btHH = new System.Windows.Forms.Button();
            this.btNCC = new System.Windows.Forms.Button();
            this.btNDH = new System.Windows.Forms.Button();
            this.btNNH = new System.Windows.Forms.Button();
            this.btNhap = new System.Windows.Forms.Button();
            this.btQL = new System.Windows.Forms.Button();
            this.btTN = new System.Windows.Forms.Button();
            this.btXuat = new System.Windows.Forms.Button();
            this.btMN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btDVVC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phần Mềm Quản Lý Bán Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(235, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quán Cafe BIG HOME";
            // 
            // btban
            // 
            this.btban.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btban.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btban.Location = new System.Drawing.Point(337, 233);
            this.btban.Name = "btban";
            this.btban.Size = new System.Drawing.Size(189, 26);
            this.btban.TabIndex = 3;
            this.btban.Text = "Danh mục bàn";
            this.btban.UseVisualStyleBackColor = false;
            this.btban.Click += new System.EventHandler(this.btban_Click);
            // 
            // btHH
            // 
            this.btHH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btHH.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHH.Location = new System.Drawing.Point(55, 280);
            this.btHH.Name = "btHH";
            this.btHH.Size = new System.Drawing.Size(156, 23);
            this.btHH.TabIndex = 4;
            this.btHH.Text = "Danh mục hàng hóa";
            this.btHH.UseVisualStyleBackColor = false;
            this.btHH.Click += new System.EventHandler(this.btHH_Click);
            // 
            // btNCC
            // 
            this.btNCC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNCC.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNCC.Location = new System.Drawing.Point(55, 318);
            this.btNCC.Name = "btNCC";
            this.btNCC.Size = new System.Drawing.Size(156, 26);
            this.btNCC.TabIndex = 5;
            this.btNCC.Text = "Danh mục nhà cung cấp";
            this.btNCC.UseVisualStyleBackColor = false;
            this.btNCC.Click += new System.EventHandler(this.btNCC_Click);
            // 
            // btNDH
            // 
            this.btNDH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNDH.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNDH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btNDH.Location = new System.Drawing.Point(55, 235);
            this.btNDH.Name = "btNDH";
            this.btNDH.Size = new System.Drawing.Size(156, 28);
            this.btNDH.TabIndex = 6;
            this.btNDH.Text = "Danh mục người đặt hàng";
            this.btNDH.UseVisualStyleBackColor = false;
            this.btNDH.Click += new System.EventHandler(this.btNDH_Click);
            // 
            // btNNH
            // 
            this.btNNH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNNH.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNNH.Location = new System.Drawing.Point(55, 189);
            this.btNNH.Name = "btNNH";
            this.btNNH.Size = new System.Drawing.Size(156, 28);
            this.btNNH.TabIndex = 7;
            this.btNNH.Text = "Danh mục người nhận hàng";
            this.btNNH.UseVisualStyleBackColor = false;
            this.btNNH.Click += new System.EventHandler(this.btNNH_Click);
            // 
            // btNhap
            // 
            this.btNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhap.Location = new System.Drawing.Point(55, 143);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(156, 26);
            this.btNhap.TabIndex = 8;
            this.btNhap.Text = "Danh mục nhập";
            this.btNhap.UseVisualStyleBackColor = false;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // btQL
            // 
            this.btQL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btQL.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQL.Location = new System.Drawing.Point(337, 186);
            this.btQL.Name = "btQL";
            this.btQL.Size = new System.Drawing.Size(189, 29);
            this.btQL.TabIndex = 9;
            this.btQL.Text = "Danh mục nhân viên quản lý";
            this.btQL.UseVisualStyleBackColor = false;
            this.btQL.Click += new System.EventHandler(this.btQL_Click);
            // 
            // btTN
            // 
            this.btTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTN.Location = new System.Drawing.Point(337, 141);
            this.btTN.Name = "btTN";
            this.btTN.Size = new System.Drawing.Size(189, 28);
            this.btTN.TabIndex = 10;
            this.btTN.Text = "Danh mục nhân viên thu Ngân";
            this.btTN.UseVisualStyleBackColor = false;
            this.btTN.Click += new System.EventHandler(this.btTN_Click);
            // 
            // btXuat
            // 
            this.btXuat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXuat.Location = new System.Drawing.Point(337, 319);
            this.btXuat.Name = "btXuat";
            this.btXuat.Size = new System.Drawing.Size(189, 23);
            this.btXuat.TabIndex = 11;
            this.btXuat.Text = "Danh mục xuất";
            this.btXuat.UseVisualStyleBackColor = false;
            this.btXuat.Click += new System.EventHandler(this.btXuat_Click);
            // 
            // btMN
            // 
            this.btMN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btMN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMN.Location = new System.Drawing.Point(337, 278);
            this.btMN.Name = "btMN";
            this.btMN.Size = new System.Drawing.Size(189, 23);
            this.btMN.TabIndex = 12;
            this.btMN.Text = "Danh mục món nước";
            this.btMN.UseVisualStyleBackColor = false;
            this.btMN.Click += new System.EventHandler(this.btMN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::QLBH.Properties.Resources.Screenshot_2023_11_26_004009;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 632);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btDVVC
            // 
            this.btDVVC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDVVC.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDVVC.Location = new System.Drawing.Point(337, 363);
            this.btDVVC.Name = "btDVVC";
            this.btDVVC.Size = new System.Drawing.Size(189, 26);
            this.btDVVC.TabIndex = 13;
            this.btDVVC.Text = "Danh mục đơn vị vận chuyển";
            this.btDVVC.UseVisualStyleBackColor = false;
            this.btDVVC.Click += new System.EventHandler(this.btDVVC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 454);
            this.Controls.Add(this.btDVVC);
            this.Controls.Add(this.btMN);
            this.Controls.Add(this.btXuat);
            this.Controls.Add(this.btTN);
            this.Controls.Add(this.btQL);
            this.Controls.Add(this.btNhap);
            this.Controls.Add(this.btNNH);
            this.Controls.Add(this.btNDH);
            this.Controls.Add(this.btNCC);
            this.Controls.Add(this.btHH);
            this.Controls.Add(this.btban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btban;
        private System.Windows.Forms.Button btHH;
        private System.Windows.Forms.Button btNCC;
        private System.Windows.Forms.Button btNDH;
        private System.Windows.Forms.Button btNNH;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.Button btQL;
        private System.Windows.Forms.Button btTN;
        private System.Windows.Forms.Button btXuat;
        private System.Windows.Forms.Button btMN;
        private System.Windows.Forms.Button btDVVC;
    }
}