using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btNDH_Click(object sender, EventArgs e)
        {
            frmNguoiDat frmnv = new frmNguoiDat();
            frmnv.Show();
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            frmNhap frmN = new frmNhap();
            frmN.Show();
        }

        private void btNNH_Click(object sender, EventArgs e)
        {
            frmNguoiNhanHang frmNNH = new frmNguoiNhanHang();
            frmNNH.Show();
        }

        private void btHH_Click(object sender, EventArgs e)
        {
            frmHH frmHH = new frmHH();
            frmHH.Show();
        }

        private void btNCC_Click(object sender, EventArgs e)
        {
            frmNCC frmNCC = new frmNCC();
            frmNCC.Show();
        }

        private void btTN_Click(object sender, EventArgs e)
        {
            frmTN frmTN = new frmTN();
            frmTN.Show();
        }

        private void btQL_Click(object sender, EventArgs e)
        {
            frmQL frmQL = new frmQL();
            frmQL.Show();
        }

        private void btban_Click(object sender, EventArgs e)
        {
            frmBan frmBan = new frmBan();
            frmBan.Show();
        }

        private void btMN_Click(object sender, EventArgs e)
        {
            frmMN frmMN = new frmMN();
            frmMN.Show();
        }

        private void btXuat_Click(object sender, EventArgs e)
        {
            frmXuat frmXuat = new frmXuat();
            frmXuat.Show();
        }

        private void btDVVC_Click(object sender, EventArgs e)
        {
            fmsDVVC frmDVVC = new  fmsDVVC();
            frmDVVC.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
