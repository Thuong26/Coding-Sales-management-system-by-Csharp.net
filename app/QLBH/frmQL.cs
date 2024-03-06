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

namespace QLBH
{
    public partial class frmQL : Form
    {
        private ConnectSql connectSql;

        public frmQL()
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
            txbNhapTQL.Clear();
            txbMQL.Clear();
            txbTracuuQL.Clear();
            txbTQL.Clear();
            txbMQL.Enabled = true;
        }
        //Regex kiem tra ten
        private bool isString(string checkstring)
        {
            string pattern = "^([\\p{L}]{2,}\\s?)+([\\p{L}]{1,}\\s?)*[\\p{L}]{2,}$";

            return Regex.IsMatch(checkstring, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
        }
        //Load toan bo khi vao form
        private void LoadData()
        {
            string query = "select QuanLy.MaQL,QuanLy.TenNQL from QuanLy";
            DataTable dt = Request(query);
            if (dt != null)
            {
                dgvQL.DataSource = dt;
            }
        }
        //tim kiem nguoi quan ly
        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string qnname = txbNhapTQL.Text.Trim().ToLower();
            if (qnname == "")
            {
                MessageBox.Show("Bạn cần nhập tên để tìm kiếm");
                return;
            }
            else
            {
                // query lay danh sach ten nguoi dung
                string query = $"select QuanLy.MaQL, QuanLy.TenNQL from QuanLy where QuanLy.TenNQL collate Latin1_General_CI_AI like N'%{qnname}%'";
                DataTable dt = Request(query);
                if (dt != null)
                {
                    dgvQL.DataSource = dt;
                    clear();
                    txbNhapTQL.Text = qnname;
                }
                return;
            }
        }
        //Tra cuu thong tin theo id
        private void btTracuu_Click(object sender, EventArgs e)
        {
            string qnId = txbTracuuQL.Text.Trim();
            if (qnId == "")
            {
                MessageBox.Show("Mã thu ngân không được để trống!");
                return;
            }
            else
            {
                string query = $"select QuanLy.MaQL, QuanLy.TenNQL from QuanLy where QuanLy.MaQL = '{qnId}'";
                DataTable dt = Request(query);
                if (dt != null)
                {
                    dgvQL.DataSource = dt;
                    clear();
                    txbTracuuQL.Text = qnId;
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy người quản lý với id = {qnId}");
                }
                return;
            }
        }
        // them 1 nguoi quan ly
        private void btthem_Click(object sender, EventArgs e)
        {
            string qnId = txbMQL.Text.Trim();
            string qnname = txbTQL.Text.Trim();

            List<string> inputcase = new List<string>()
            {
                qnId,qnname
            };
            // bắt các case trường hợp không hợp lệ

            if (inputcase.Contains(""))
            {
                int index = inputcase.IndexOf("");
                switch (index)
                {
                    case 0:
                        MessageBox.Show("Mã người quản lý không được để trống");
                        break;
                    case 1:
                        MessageBox.Show("Tên người quản lý không được để trống");
                        break;
                }
            }
            else
            {
                DataTable dt = new DataTable();
                //Kiem tra xem id da ton tai hay chua
                string querycheck = $"select MaQL from QuanLy where QuanLy.MaQL = '{qnId}'";
                string query = $"Insert into QuanLy values ('{qnId}', N'{qnname}')";
                dt = Request(querycheck);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Id quản lý đã tồn tại");
                    txbMQL.Text = string.Empty;
                    txbMQL.Enabled = true;
                    txbTQL.Text = string.Empty;
                    return;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        MessageBox.Show($"Thêm mới id = {qnId} thành công!");
                        //Thực hiện thành công
                        LoadData();
                        clear();

                    }
                    else
                    {
                        MessageBox.Show("Thêm người quản lý mới không thành công!");
                        return;
                    }
                }
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string qnId = txbMQL.Text.Trim();
            DataTable dt = new DataTable();
            //Kiem tra xem id da ton tai hay chua
            string query = $"delete from QuanLy where QuanLy.MaQL = '{qnId}'";
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa người quản lý này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {

                string countquerry = $"select MaQL from QuanLy where QuanLy.MaQL = '{qnId}'";
                dt = Request(countquerry);
                if (dt.Rows.Count == 0 || dt == null)
                {
                    MessageBox.Show("Mã người thu ngân không tồn tại!");
                    return;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        //Thực hiện thành công
                        LoadData();
                        txbMQL.Enabled = true;
                        clear();
                        return;
                    }
                }
            }
            return;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string qnid = txbMQL.Text.Trim();
            string qnname = txbTQL.Text.Trim();

            List<string> inputcase = new List<string>()
            {
                qnid,qnname
            };
            // bắt các case trường hợp không hợp lệ

            if (inputcase.Contains(""))
            {
                int index = inputcase.IndexOf("");
                switch (index)
                {
                    case 0:
                        MessageBox.Show("Mã người quản lý không được để trống");
                        break;
                    case 1:
                        MessageBox.Show("Tên người quản lý không được để trống");
                        break;
                }
            }
            else
            {
                DataTable dt = new DataTable();
                string query = $"Update QuanLy set TenNQL = N'{qnname}' where MaQL = '{qnid}'";
                string countquerry = $"select MaQL from QuanLy where QuanLy.MaQL = '{qnid}'";
                dt = Request(countquerry);
                if (dt.Rows.Count == 0 || dt == null)
                {
                    MessageBox.Show("Mã người thu ngân không tồn tại!");
                    return;
                } else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        MessageBox.Show($"Sửa thông tin người thu ngân {qnid} thành công");
                        LoadData();
                        clear();
                        txbMQL.Enabled = true;
                        return;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        
        private void frmQL_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvQL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvQL.CurrentRow.Index;
            txbMQL.Text = dgvQL.Rows[i].Cells[0].Value.ToString();
            txbTQL.Text = dgvQL.Rows[i].Cells[1].Value.ToString();
            txbMQL.Enabled = false;
        }

        private void btQL_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
