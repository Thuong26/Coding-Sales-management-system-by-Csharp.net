using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QLBH
{
    public partial class frmNguoiNhanHang : Form
    {

        private ConnectSql connectSql;
        public frmNguoiNhanHang()
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
        //Regex kiem tra ten
        private bool isString(string checkstring)
        {
            string pattern = "^([\\p{L}]{2,}\\s?)+([\\p{L}]{1,}\\s?)*[\\p{L}]{2,}$";

            return Regex.IsMatch(checkstring, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
        }
        private void frmNguoiNhanHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        //click row lay thong tin
        private void dgvNN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNN.CurrentRow.Index;
            txbMNN.Text = dgvNN.Rows[i].Cells[0].Value.ToString();
            txbTNN.Text = dgvNN.Rows[i].Cells[1].Value.ToString();
            txbMNN.Enabled = false;
        }
        //Load toan bo khi vao form
        private void LoadData()
        {
            string query = "select NguoiNhanHang.MaNN,NguoiNhanHang.TenNNH from NguoiNhanHang";
            DataTable dt = Request(query);
            if (dt != null)
            {
                dgvNN.DataSource = dt;
            }
        }
        //tim kiem nguoi nhan hang theo ten
        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string customerName = txbNhapNN.Text.Trim().ToLower();
            if (customerName == "")
            {
                MessageBox.Show("Bạn cần nhập tên để tìm kiếm");
                return;
            }
            else if (!isString(customerName))
            {
                MessageBox.Show("Tên không phù hợp! Tên phải là chuỗi kí tự");
                return;
            }
            else
            {
                // query lay danh sach ten nguoi dung
                string query = $"select * from NguoiNhanHang where NguoiNhanHang.TenNNH collate Latin1_General_CI_AI like N'%{customerName}%'";
                DataTable dt = Request(query);
                if (dt != null)
                {
                    dgvNN.DataSource = dt;
                    txbMNN.Enabled = true;
                    txbMNN.Text = string.Empty;
                    txbTNN.Text = string.Empty;
                    txbTracuuNN.Text = string.Empty;
                }
                return;
            }
        }
        // tra cuu nguoi nhan hang theo id
        private void btTracuu_Click(object sender, EventArgs e)
        {
            string customerId = txbTracuuNN.Text.Trim();
            if (customerId == "")
            {
                MessageBox.Show("Mã người đặt không được để trống!");
                return;
            }
            else
            {
                string query = $" select * from NguoiNhanHang where NguoiNhanHang.MaNN = '{customerId}'";
                DataTable dt = Request(query);
                if (dt != null)
                {
                    dgvNN.DataSource = dt;
                    txbMNN.Text = string.Empty;
                    txbTNN.Text = string.Empty;
                    txbNhapNN.Text = string.Empty;
                    txbMNN.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy người đặt với id = {customerId}");
                }
                return;
            }
        }
        //them 1 nguoi nhan hang moi

        private void btthem_Click(object sender, EventArgs e)
        {
            string customerId = txbMNN.Text.Trim();
            string customerName = txbTNN.Text.Trim();
            // bắt các case trường hợp không hợp lệ
            if (customerId == "" || customerName == "")
            {
                MessageBox.Show("Mã người nhận và Tên người nhận không được trống!");
                return;
            }
            else if (!isString(customerName))
            {
                MessageBox.Show("Tên người nhận không hợp lệ");
                return;
            }
            else
            {
                DataTable dt = new DataTable();
                //Kiem tra xem id da ton tai hay chua
                string querycheck = $"select MaNN from NguoiNhanHang where NguoiNhanHang.MaNN = '{customerId}'";
                string query = $"Insert into NguoiNhanHang values ('{customerId}', N'{customerName}')";
                dt = Request(querycheck);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Id người nhận đã tồn tại");
                    txbMNN.Text = string.Empty;
                    txbTNN.Text = string.Empty;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        MessageBox.Show($"Thêm mới id = {customerId} thành công!");
                        //Thực hiện thành công
                        LoadData();
                        txbMNN.Enabled = true;
                        txbMNN.Text = string.Empty;
                        txbTracuuNN.Text = string.Empty;
                        txbNhapNN.Text = string.Empty; 

                    }
                    else
                    {
                        MessageBox.Show("Thêm người nhận mới không thành công!");
                        return;
                    }
                }
            }
        }
        //Sửa thông tin của 1 người
        private void btSua_Click(object sender, EventArgs e)
        {
            string customerId = txbMNN.Text.Trim();
            string customerName = txbTNN.Text.Trim();
            DataTable dt = new DataTable();
            if(customerId == "" || customerName == "")
            {
                MessageBox.Show("Mã người nhận và tên người nhận không được trống");
                return;
            } else if(!isString(customerName))
            {
                MessageBox.Show("Tên không hợp lệ");
                return;
            } else
            {
                string query = $"Update NguoiNhanHang set TenNNH = N'{customerName}' where MaNN = '{customerId}'";
                dt = Request(query);
                if (dt != null)
                {
                    MessageBox.Show($"Sửa thông tin người nhận hàng {customerId} thành công");
                    LoadData();
                    txbMNN.Text = string.Empty;
                    txbTNN.Text = string.Empty;
                    txbTracuuNN.Text= string.Empty;
                    txbNhapNN.Text= string.Empty;
                    txbMNN.Enabled = true;
                }
            }
        }
        //Xoa thòng tin 1 bản ghi
        private void btxoa_Click(object sender, EventArgs e)
        {
            string customerId = txbMNN.Text.Trim();
            DataTable dt = new DataTable();
            //Kiem tra xem id da ton tai hay chua
            string query = $"delete from NguoiNhanHang where NguoiNhanHang.MaNN = '{customerId}'";
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {
                dt = Request(query);
                if (dt.Rows.Count > 0 || dt != null)
                {
                    MessageBox.Show("Id người nhận không tồn tại");
                    txbMNN.Text = string.Empty;
                    txbTNN.Text = string.Empty;
                }
                else
                {
                    //Thực hiện thành công
                    LoadData();
                    txbMNN.Enabled = true;
                    txbMNN.Text = string.Empty;
                    txbTNN.Text = string.Empty;
                }
            }
            return;
        }
        //quay lại
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
       
        // tìm kiếm toàn bộ thông tin 
        private void btLuu_Click(object sender, EventArgs e)
        {
            LoadData();
            txbMNN.Enabled = true;
            txbMNN.Text = string.Empty;
            txbNhapNN.Text = string.Empty;
            txbTracuuNN.Text = string.Empty;
            txbTNN.Text = string.Empty;
        }

        private void btQL_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
