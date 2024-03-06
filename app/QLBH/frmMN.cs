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
    public partial class frmMN : Form
    {

        private ConnectSql connectSql;

        public frmMN()
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
            txbMM.Clear();
            txbNhapTMN.Clear();
            txbTMN.Clear();
            txbMM.Enabled = true;
        }

        // Load toan bo khi vao form
        private void LoadData()
        {
            string query = "select MonNuoc.MaMon, MonNuoc.TenMon, MonNuoc.DonGia from MonNuoc";
            DataTable dt = Request(query);
            if (dt != null)
            {
                dgvMN.DataSource = dt;
            }
        }

        private void frmMN_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string foodname = txbNhapTMN.Text.Trim();
            if (foodname == "")
            {
                MessageBox.Show("Bạn cần nhập tên để tìm kiếm");
                return;
            }
            else
            {
                // query lay danh sach ten nguoi dung
                string query = $"select MaMon, TenMon, DonGia from MonNuoc where TenMon collate Latin1_General_CI_AI like N'%{foodname}%'";
                DataTable dt = Request(query);
                if (dt != null)
                {
                    dgvMN.DataSource = dt;
                    clear();
                    txbNhapTMN.Text = foodname;
                }
                return;
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            decimal dg;
            string monId = txbMM.Text.Trim();
            string monName = txbTMN.Text.Trim();
            if (decimal.TryParse(txbDG.Text.Trim(), out dg) && dg > 0) 
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
            if (monId == "" || monName == "" || dg == 0)
            {
                MessageBox.Show("Các trường không hợp lệ! Yêu cầu nhập lại!");
                return;
            }
            else
            {
                DataTable dt = new DataTable();
                // Kiem tra xem id da ton tai hay chua
                string querycheck = $"select MaMon from MonNuoc where MaMon = '{monId}'";
                string query = $"Insert into MonNuoc values ('{monId}', N'{monName}', {dg} )";
                dt = Request(querycheck);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Id Hàng đã tồn tại");
                    txbMM.Text = string.Empty;
                    txbMM.Enabled = true;
                    return;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        MessageBox.Show($"Thêm mới id = {monId} thành công!");
                        // Thực hiện thành công
                        LoadData();
                        clear();

                    }
                    else
                    {
                        MessageBox.Show("Thêm đồ uống mới không thành công!");
                        return;
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            decimal dg;
            string drinkId = txbMM.Text.Trim();
            string drinkName = txbTMN.Text.Trim();
            if (decimal.TryParse(txbDG.Text, out dg))
            {
                dg = decimal.Parse(txbDG.Text.Trim());
            }
            else
            {
                MessageBox.Show("Đơn giá phải là định đạng tiền");
                txbDG.Text = string.Empty;
                return;
            }

            if (drinkId == "" || drinkName == "" || dg == 0)
            {
                MessageBox.Show("Các trường không hợp lệ! Yêu cầu nhập lại!");
                return;
            }
            else
            {
                DataTable dt = new DataTable();
                string query = $"Update MonNuoc set TenMon = N'{drinkName}', Dongia = {dg} where MaMon = '{drinkId}'";
                string countquerry = $"select MaMon from MonNuoc where MaMon  = '{drinkId}'";
                dt = Request(countquerry);
                if (dt.Rows.Count == 0 || dt == null)
                {
                    MessageBox.Show("Mã đồ uống không tồn tại!");
                    clear();
                    return;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        MessageBox.Show($"Sửa thông tin đồ uống {drinkId} thành công");
                        LoadData();
                        clear();
                        txbMM.Enabled = true;
                        return;
                    }
                }
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string monId = txbMM.Text.Trim();
            DataTable dt = new DataTable();
            // Kiem tra xem id da ton tai hay chua
            string query = $"delete from MonNuoc where MonNuoc.MaMon = '{monId}'";
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa đồ uống này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {
                string countquerry = $"select MaMon from MonNuoc where MonNuoc.MaMon = '{monId}'";
                dt = Request(countquerry);
                if (dt.Rows.Count == 0 || dt == null)
                {
                    MessageBox.Show("Mã đồ uống không tồn tại!");
                    return;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        // Thực hiện thành công
                        LoadData();
                        txbMM.Enabled = true;
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
            clear();
            LoadData();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clear();
            LoadData();
        }

        private void btTracuu_Click(object sender, EventArgs e)
        {
            string monId = cbTraCuuMM.Text.Trim();
            if (monId == "")
            {
                MessageBox.Show("Mã hàng hóa không được để trống!");
                return;
            }
            else
            {
                string query = $"select MaMon, TenMon, Dongia from MonNuoc where MaMon = '{monId}'";
                DataTable dt = Request(query);
                if (dt != null)
                {
                    dgvMN.DataSource = dt;
                    clear();
                    cbTraCuuMM.Text = monId;
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy đồ uống với id = {monId}");
                }
                return;
            }
        }

        private void dgvMN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvMN.CurrentRow.Index;
            txbMM.Text = dgvMN.Rows[i].Cells[0].Value.ToString();
            txbTMN.Text = dgvMN.Rows[i].Cells[1].Value.ToString();
            txbDG.Text = dgvMN.Rows[i].Cells[2].Value.ToString();
            txbMM.Enabled = false;
        }

        private void btQL_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
