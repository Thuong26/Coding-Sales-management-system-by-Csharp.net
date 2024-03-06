namespace QLBH
{
    partial class frmDN
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bthuy = new System.Windows.Forms.Button();
            this.btDN = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTDN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLBH.Properties.Resources.DN1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 421);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(211, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đăng Nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bthuy
            // 
            this.bthuy.BackColor = System.Drawing.SystemColors.GrayText;
            this.bthuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.ForeColor = System.Drawing.SystemColors.Info;
            this.bthuy.Location = new System.Drawing.Point(226, 316);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(84, 31);
            this.bthuy.TabIndex = 12;
            this.bthuy.Text = "Hủy";
            this.bthuy.UseVisualStyleBackColor = false;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btDN
            // 
            this.btDN.BackColor = System.Drawing.Color.SteelBlue;
            this.btDN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDN.ForeColor = System.Drawing.Color.Snow;
            this.btDN.Location = new System.Drawing.Point(226, 268);
            this.btDN.Name = "btDN";
            this.btDN.Size = new System.Drawing.Size(84, 31);
            this.btDN.TabIndex = 11;
            this.btDN.Text = "Đăng nhập";
            this.btDN.UseVisualStyleBackColor = false;
            this.btDN.Click += new System.EventHandler(this.btDN_Click_1);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(188, 226);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(244, 20);
            this.txtMK.TabIndex = 14;
            this.txtMK.UseSystemPasswordChar = true;
            this.txtMK.TextChanged += new System.EventHandler(this.txtMK_TextChanged);
            // 
            // txtDN
            // 
            this.txtDN.Location = new System.Drawing.Point(188, 180);
            this.txtDN.Name = "txtDN";
            this.txtDN.Size = new System.Drawing.Size(244, 20);
            this.txtDN.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(86, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mật khẩu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTDN
            // 
            this.txtTDN.AutoSize = true;
            this.txtTDN.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDN.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtTDN.Location = new System.Drawing.Point(85, 180);
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Size = new System.Drawing.Size(89, 15);
            this.txtTDN.TabIndex = 11;
            this.txtTDN.Text = "Tên đăng nhập:";
            this.txtTDN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 406);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.btDN);
            this.Controls.Add(this.txtDN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTDN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDN_FormClosing);
            this.Load += new System.EventHandler(this.frmDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTDN;
    }
}

