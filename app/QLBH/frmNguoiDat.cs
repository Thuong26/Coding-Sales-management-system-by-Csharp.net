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
    public partial class frmNguoiDat : Form
    {
        private ConnectSql connectSql;
        public frmNguoiDat()
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
        // thuc hien request
        private DataTable Request(string cmd)
        {
            return connectSql.Request(cmd);
        }
        // regex kiem tra chuoi
        private bool isString(string checkstring)
        {
            string pattern = "^([\\p{L}]{2,}\\s?)+([\\p{L}]{1,}\\s?)*[\\p{L}]{2,}$";

            return Regex.IsMatch(checkstring, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
        }
        private void frmNguoiDat_Load(object sender, EventArgs e)
        {
            LoadData();
        }
       

        //dong form hien tai
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        
        // tim kiem nguoi dat hang theo ten
        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string customerName = txbNhapNDH.Text.Trim().ToLower();
            if (customerName == "")
            {
                MessageBox.Show("Bạn cần nhập tên để tìm kiếm");
                return;
            } else if (!isString(customerName))
            {
                MessageBox.Show("Tên không phù hợp! Tên phải là chuỗi kí tự");
                return;
            } else
            {
                // query lay danh sach ten nguoi dung
                string query = $"select * from NguoiDatHang where NguoiDatHang.TenNDH collate Latin1_General_CI_AI like N'%{customerName}%'";
                DataTable dt = Request(query);
                if (dt != null)
                {
                    dgvNDH.DataSource = dt;
                    maNDH.Enabled = true;
                    maNDH.Text = string.Empty;
                    txbTNDH.Text = string.Empty;
                    txbTracuu.Text = string.Empty;
                }
                return;
            }
        }
        //Load toan bo khi vao form
        private void LoadData()
        {
            string query = "select * from NguoiDatHang";
            DataTable dt = Request(query);
            if (dt != null)
            {
                dgvNDH.DataSource = dt;
            }
        }
        //tra cuu nguoi dung
        private void btTracuu_Click(object sender, EventArgs e)
        {
            string customerId = txbTracuu.Text.Trim();
            if (customerId == "")
            {
                MessageBox.Show("Mã người đặt không được để trống!");
                return;
            }
            else
            {
                string query = $"select * from NguoiDatHang where NguoiDatHang.MaNDH = '{customerId}'";
                DataTable dt = Request(query);
                if (dt != null)
                {
                    dgvNDH.DataSource = dt;
                    maNDH.Text = string.Empty;
                    txbTNDH.Text = string.Empty;
                    txbNhapNDH.Text = string.Empty;
                    maNDH.Enabled = true;
                } else
                {
                    MessageBox.Show($"Không tìm thấy người đặt với id = {customerId}");
                }
                return;
            }
        }
        //them 1 nguoi moi
        private void btthem_Click(object sender, EventArgs e)
        {
            string customerId = maNDH.Text.Trim();
            string customerName = txbTNDH.Text.Trim();
            // bắt các case trường hợp không hợp lệ
            if (customerId == "" || customerName == "")
            {
                MessageBox.Show("Mã người đặt và Tên người đặt không được trống!");
                return;
            } else if (!isString(customerName))
            {
                MessageBox.Show("Tên người đặt không hợp lệ");
                return;
            } else
            {

                DataTable dt = new DataTable();
                //Kiem tra xem id da ton tai hay chua
                string querycheck = $"select MaNDH from NguoiDatHang where NguoiDatHang.MaNDH = '{customerId}'";
                string query = $"Insert into NguoiDatHang values ('{customerId}', N'{customerName}')";
                dt = Request(querycheck);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Id người đặt đã tồn tại");
                    maNDH.Text = string.Empty;
                    txbTNDH.Text = string.Empty;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        MessageBox.Show($"Thêm mới id = {customerId} thành công!");
                        //Thực hiện thành công
                        LoadData();
                        maNDH.Enabled = true;
                        maNDH.Text = string.Empty;
                        txbTNDH.Text = string.Empty;
                        
                    }
                    else
                    {
                        MessageBox.Show("Thêm người đặt mới không thành công!");
                        return;
                    }
                }
            }
        }
        private void dgvNDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNDH.CurrentRow.Index;
            maNDH.Text = dgvNDH.Rows[i].Cells[0].Value.ToString();
            txbTNDH.Text = dgvNDH.Rows[i].Cells[1].Value.ToString();
            maNDH.Enabled = false;
        }
        //Xoa 1 ban ghi
        private void btxoa_Click(object sender, EventArgs e)
        {
            string customerId = maNDH.Text.Trim();
            DataTable dt = new DataTable();
            //Kiem tra xem id da ton tai hay chua
            string query = $"delete from NguoiDatHang where NguoiDatHang.MaNDH = '{customerId}'";
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(res == DialogResult.Yes)
            {
                dt = Request(query);
                if (dt.Rows.Count > 0 || dt != null)
                {
                    MessageBox.Show("Id người đặt không tồn tại");
                    maNDH.Text = string.Empty;
                    txbTNDH.Text = string.Empty;
                }
                else
                {
                    //Thực hiện thành công
                    LoadData();
                    maNDH.Enabled = true;
                    maNDH.Text = string.Empty;
                    txbTNDH.Text = string.Empty;
                }
            }
            return;
        }
        //Sua thông tin 1 bản ghi
        private void btSua_Click(object sender, EventArgs e)
        {
            string customerId = maNDH.Text.Trim();
            string customerName = txbTNDH.Text.Trim();

            DataTable dt = new DataTable();

            if (customerId == "" || customerName == "")
            {
                MessageBox.Show("Mã người đặt và tên người đặt không được trống");
                return;
            }
            else if (!isString(customerName))
            {
                MessageBox.Show("Tên không hợp lệ");
                return;
            }
            else
            {
                string query = $"Update NguoiDatHang set TenNDH = N'{customerName}' where NguoiDatHang.MaNDH = '{customerId}'";
                dt = Request(query);
                if (dt != null)
                {

                    MessageBox.Show($"Sửa thông tin người đặt hàng {customerId} thành công");
                    LoadData();
                    maNDH.Text = string.Empty;
                    txbTNDH.Text = string.Empty;
                    maNDH.Enabled = true;

                }
            }
        }
        //Tim toàn bộ
        private void btLuu_Click(object sender, EventArgs e)
        {
            LoadData();
            maNDH.Enabled = true;
            maNDH.Text = string.Empty;
            txbNhapNDH.Text = string.Empty;
            txbTNDH.Text = string.Empty;
            txbTracuu.Text = string.Empty;
        }

        private void btQL_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
