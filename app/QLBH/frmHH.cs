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
    public partial class frmHH : Form
    {
        private ConnectSql connectSql;

        public frmHH()
        {
            InitializeComponent();
            connectSql = new ConnectSql();
        }

        private void openConnect()
        {
            connectSql.openConnect();
        }

        private void closeConnect()
        {
            connectSql.closeConnect();
        }

        private DataTable Request(string cmd)
        {
            return connectSql.Request(cmd);
        }

        private void clear()
        {
            txbDG.Clear();
            txbDVT.Clear();
            txbTNDH.Clear();
            txbNhapTMH.Clear();
            txbMH.Clear();
            cbTraCuuMH.Clear();
            txbMH.Enabled = true;
        }

        // Load toan bo khi vao form
        private void LoadData()
        {
            string query = "select Hang.MaHang,Hang.TenMH,Hang.DVT,Hang.DonGia from Hang";
            DataTable dt = Request(query);
            if (dt != null)
            {
                dgvHN.DataSource = dt;
            }
        }

        private void frmHH_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string productname = txbNhapTMH.Text.Trim().ToLower();
            if (productname == "")
            {
                MessageBox.Show("Bạn cần nhập tên để tìm kiếm");
                return;
            }
            else
            {
                // query lay danh sach ten nguoi dung
                string query = $"select Hang.MaHang, Hang.TenMH, Hang.DVT, Hang.DonGia from Hang where Hang.TenMH collate Latin1_General_CI_AI like N'%{productname}%'";
                DataTable dt = Request(query);
                if (dt != null)
                {
                    dgvHN.DataSource = dt;
                    clear();
                    txbNhapTMH.Text = productname;
                }
                return;
            }
        }

        private void btTracuu_Click(object sender, EventArgs e)
        {
            string hanghoaId = cbTraCuuMH.Text.Trim();
            if (hanghoaId == "")
            {
                MessageBox.Show("Mã hàng hóa không được để trống!");
                return;
            }
            else
            {
                string query = $"select Hang.MaHang, Hang.TenMH, Hang.DVT, Hang.DonGia from Hang where Hang.MaHang = '{hanghoaId}'";
                DataTable dt = Request(query);
                if (dt != null)
                {
                    dgvHN.DataSource = dt;
                    clear();
                    cbTraCuuMH.Text = hanghoaId;
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy hàng hóa với id = {hanghoaId}");
                }
                return;
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            decimal dg;
            string hanghoaId = txbMH.Text.Trim();
            string hanghoaName = txbTNDH.Text.Trim();
            string dvt = txbDVT.Text.Trim();
            if (decimal.TryParse(txbDG.Text, out dg) && dg > 0)
            {
                dg = decimal.Parse(txbDG.Text);
            }
            else
            {
                MessageBox.Show("Đơn giá phải là định đạng tiền");
                txbDG.Text = string.Empty;
                return;
            }

            // bắt các case trường hợp không hợp lệ
            if (hanghoaId == "" || hanghoaName == "" || dvt == "" || dg == 0)
            {
                MessageBox.Show("Các trường không hợp lệ! Yêu cầu nhập lại!");
                return;
            }
            else
            {
                DataTable dt = new DataTable();
                // Kiem tra xem id da ton tai hay chua
                string querycheck = $"select MaHang from Hang where Hang.MaHang = '{hanghoaId}'";
                string query = $"Insert into Hang values ('{hanghoaId}', N'{hanghoaName}', N'{dvt}', {dg} )";
                dt = Request(querycheck);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Id Hàng đã tồn tại");
                    txbMH.Text = string.Empty;
                    txbMH.Enabled = true;
                    return;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        MessageBox.Show($"Thêm mới id = {hanghoaId} thành công!");
                        // Thực hiện thành công
                        LoadData();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm mới không thành công!");
                        return;
                    }
                }
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string hanghoaId = txbMH.Text.Trim();
            DataTable dt = new DataTable();
            // Kiem tra xem id da ton tai hay chua
            string query = $"delete from Hang where Hang.MaHang = '{hanghoaId}'";
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {
                string countquerry = $"select MaHang from Hang where Hang.MaHang = '{hanghoaId}'";
                dt = Request(countquerry);
                if (dt.Rows.Count == 0 || dt == null)
                {
                    MessageBox.Show("Mã hàng không tồn tại!");
                    return;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        // Thực hiện thành công
                        LoadData();
                        txbMH.Enabled = true;
                        clear();
                        return;
                    }
                }
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }
        
        private void btLuu_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvHN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvHN.CurrentRow.Index;
            txbMH.Text = dgvHN.Rows[i].Cells[0].Value.ToString();
            txbTNDH.Text = dgvHN.Rows[i].Cells[1].Value.ToString();
            txbDVT.Text = dgvHN.Rows[i].Cells[2].Value.ToString();
            txbDG.Text = dgvHN.Rows[i].Cells[3].Value.ToString();
            txbMH.Enabled = false;
        }

        private void btSua_Click_1(object sender, EventArgs e)
        {
            decimal dg;
            string hanghoaid = txbMH.Text.Trim();
            string hanghoaname = txbTNDH.Text.Trim();
            string dvt = txbDVT.Text.Trim();
            if (decimal.TryParse(txbDG.Text, out dg))
            {
                dg = decimal.Parse(txbDG.Text);
            }
            else
            {
                MessageBox.Show("Đơn giá phải là định đạng tiền");
                txbDG.Text = string.Empty;
                return;
            }

            if (hanghoaid == "" || hanghoaname == "" || dvt == "" || dg == 0)
            {
                MessageBox.Show("Các trường không hợp lệ! Yêu cầu nhập lại!");
                return;
            }
            else
            {
                DataTable dt = new DataTable();
                string query = $"Update Hang set TenMH = N'{hanghoaname}', DVT = N'{dvt}', Dongia = {dg} where MaHang = '{hanghoaid}'";
                string countquerry = $"select MaHang from Hang where Hang.MaHang = '{hanghoaid}'";
                dt = Request(countquerry);
                if (dt.Rows.Count == 0 || dt == null)
                {
                    MessageBox.Show("Mã hàng không tồn tại!");
                    return;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        MessageBox.Show($"Sửa thông tin hàng hóa {hanghoaid} thành công");
                        LoadData();
                        clear();
                        txbMH.Enabled = true;
                        return;
                    }
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clear();
            LoadData();
        }

        private void btQL_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
