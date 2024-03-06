using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmNCC : Form
    {

        private ConnectSql connectSql;
        public frmNCC()
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
            txbMNCC.Clear();
            txbSDTNCC.Clear();
            txbTNCC.Clear();
            txbMNCC.Enabled = true;
            cbTraCuuNCC.Text = string.Empty;
        }

        // Regex kiem tra ten
        private bool isString(string checkstring)
        {
            string pattern = "^([\\p{L}]{2,}\\s?)+([\\p{L}]{1,}\\s?)*[\\p{L}]{2,}$";

            return Regex.IsMatch(checkstring, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
        }

        // Load toan bo khi vao form
        private void LoadData()
        {
            string query = "select NhaCungCap.MaNCC, NhaCungCap.TenNCC, NhaCungCap.SDT from NhaCungCap";
            DataTable dt = Request(query);
            if (dt != null)
            {
                dgvNCC.DataSource = dt;
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            LoadData();
            clear();
        }

        // tim kiem nha cung cap ten
        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string nccname = txbNhapNCC.Text.Trim().ToLower();
            if (nccname == "")
            {
                MessageBox.Show("Bạn cần nhập tên để tìm kiếm");
                return;
            }
            else
            {
                // query lay danh sach ten nguoi dung
                string query = $"select NhaCungCap.MaNCC, NhaCungCap.TenNCC, NhaCungCap.SDT from NhaCungCap where NhaCungCap.TenNCC collate Latin1_General_CI_AI like N'%{nccname}%'";
                DataTable dt = Request(query);
                if (dt != null)
                {
                    dgvNCC.DataSource = dt;
                    clear();
                }
                return;
            }
        }

        // Tra cuu thong tin theo id
        private void btTracuu_Click(object sender, EventArgs e)
        {
            string nccId = cbTraCuuNCC.Text.Trim();
            if (nccId == "")
            {
                MessageBox.Show("Mã nhà cung cấp không được để trống!");
                return;
            }
            else
            {
                string query = $"select NhaCungCap.MaNCC, NhaCungCap.TenNCC, NhaCungCap.SDT from NhaCungCap where NhaCungCap.MaNCC = '{nccId}'";
                DataTable dt = Request(query);
                if (dt != null)
                {
                    dgvNCC.DataSource = dt;
                    clear();
                    cbTraCuuNCC.Text = nccId;
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy nhà cung cấp với id = {nccId}");
                }
                return;
            }
        }

        // them 1 nha cung cap moi
        private void btthem_Click(object sender, EventArgs e)
        {
            string nccId = txbMNCC.Text.Trim();
            string nccname = txbTNCC.Text.Trim();
            string nccphone = txbSDTNCC.Text.Trim();

            List<string> inputcase = new List<string>()
            {
                nccId, nccname, nccphone
            };
            // bắt các case trường hợp không hợp lệ
            if (inputcase.Contains(""))
            {
                int index = inputcase.IndexOf("");
                switch (index)
                {
                    case 0:
                        MessageBox.Show("Mã nhà cung cấp không được để trống");
                        break;
                    case 1:
                        MessageBox.Show("Tên nhà cung cấp không được để trống");
                        break;
                    case 2:
                        MessageBox.Show("Số điện thoại nhà cung cấp không được để trống");
                        break;
                }
            }
            else
            {
                DataTable dt = new DataTable();
                // Kiem tra xem id da ton tai hay chua
                string querycheck = $"select MaNCC from NhaCungCap where NhaCungCap.MaNCC = '{nccId}'";
                string query = $"Insert into NhaCungCap values ('{nccId}', N'{nccname}', '{nccphone}')";
                dt = Request(querycheck);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Id người nhận đã tồn tại");
                    txbMNCC.Text = string.Empty;
                    txbMNCC.Enabled = true;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        MessageBox.Show($"Thêm mới id = {nccId} thành công!");
                        // Thực hiện thành công
                        LoadData();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhà cung cấp mới không thành công!");
                        return;
                    }
                }
            }
        }

        // Xóa 1 nhà cung cấp
        private void btxoa_Click(object sender, EventArgs e)
        {
            string nccId = txbMNCC.Text.Trim();
            DataTable dt = new DataTable();
            // Kiem tra xem id da ton tai hay chua
            string query = $"delete from NhaCungCap where NhaCungCap.MaNCC = '{nccId}'";
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {
                string countquerry = $"select MaNCC from NhaCungCap where NhaCungCap.MaNCC = '{nccId}'";
                dt = Request(countquerry);
                if (dt.Rows.Count == 0 || dt == null)
                {
                    MessageBox.Show("Mã nhà cung cấp không tồn tại!");
                    return;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        // Thực hiện thành công
                        LoadData();
                        txbMNCC.Enabled = true;
                        clear();
                        return;
                    }
                }
            }
            return;
        }

        // Sua thong tin nha cung cap
        private void btSua_Click(object sender, EventArgs e)
        {
            string nccId = txbMNCC.Text.Trim();
            string nccname = txbTNCC.Text.Trim();
            string nccphone = txbSDTNCC.Text.Trim();

            List<string> inputcase = new List<string>()
            {
                nccId, nccname, nccphone
            };
            // bắt các case trường hợp không hợp lệ
            if (inputcase.Contains(""))
            {
                int index = inputcase.IndexOf("");
                switch (index)
                {
                    case 0:
                        MessageBox.Show("Mã nhà cung cấp không được để trống");
                        break;
                    case 1:
                        MessageBox.Show("Tên nhà cung cấp không được để trống");
                        break;
                    case 2:
                        MessageBox.Show("Số điện thoại nhà cung cấp không được để trống");
                        break;
                }
            }
            else
            {
                DataTable dt = new DataTable();
                string query = $"Update NhaCungCap set TenNCC = N'{nccname}', SDT = '{nccphone}' where MaNCC = '{nccId}'";
                dt = Request(query);
                if (dt != null)
                {
                    MessageBox.Show($"Sửa thông tin nhà cung cấp {nccId} thành công");
                    LoadData();
                    clear();
                    txbMNCC.Enabled = true;
                    return;
                }
            }
        }

        // Dong form hien tai
        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNCC.CurrentRow.Index;
            txbMNCC.Text = dgvNCC.Rows[i].Cells[0].Value.ToString();
            txbTNCC.Text = dgvNCC.Rows[i].Cells[1].Value.ToString();
            txbSDTNCC.Text = dgvNCC.Rows[i].Cells[2].Value.ToString();
            txbMNCC.Enabled = false;
        }

        // Load data
        private void frmNCC_Load(object sender, EventArgs e)
        {
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
