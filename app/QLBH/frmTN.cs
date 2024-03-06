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
    public partial class frmTN : Form
    {

        private ConnectSql connectSql;
        public frmTN()
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
            txbMTN.Clear();
            txbTTN.Clear();
            txbNhapTTN.Clear();
            txbTracuuMTN.Clear();
            txbMTN.Enabled = true;
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
            string query = "select ThuNgan.MaTN, ThuNgan.TenThuNgan from ThuNgan";
            DataTable dt = Request(query);
            if (dt != null)
            {
                dgvTN.DataSource = dt;
            }
        }
        //tim kiem nha cung cap ten
        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string tnname = txbNhapTTN.Text.Trim().ToLower();
            if (tnname == "")
            {
                MessageBox.Show("Bạn cần nhập tên để tìm kiếm");
                return;
            }
            else
            {
                // query lay danh sach ten nguoi dung
                string query = $"select ThuNgan.MaTN, ThuNgan.TenThuNgan from ThuNgan where ThuNgan.TenThuNgan collate Latin1_General_CI_AI like N'%{tnname}%'";
                DataTable dt = Request(query);
                if (dt != null)
                {
                    dgvTN.DataSource = dt;
                    clear();
                    txbNhapTTN.Text = tnname;
                }
                return;
            }
        }
        //Tra cuu thong tin theo id
        private void btTracuu_Click(object sender, EventArgs e)
        {
            string tnId = txbTracuuMTN.Text.Trim();
            if (tnId == "")
            {
                MessageBox.Show("Mã thu ngân không được để trống!");
                return;
            }
            else
            {
                string query = $"select ThuNgan.MaTN, ThuNgan.TenThuNgan from ThuNgan where ThuNgan.MaTN = '{tnId}'";
                DataTable dt = Request(query);
                if (dt != null)
                {
                    dgvTN.DataSource = dt;
                    clear();
                    txbTracuuMTN.Text = tnId;
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy nhà cung cấp với id = {tnId}");
                }
                return;
            }
        }
        //them 1 nha cung cap moi
        private void btthem_Click(object sender, EventArgs e)
        {
            string tnId = txbMTN.Text.Trim();
            string tnname = txbTTN.Text.Trim();

            List<string> inputcase = new List<string>()
            {
                tnId,tnname
            };
            // bắt các case trường hợp không hợp lệ

            if (inputcase.Contains(""))
            {
                int index = inputcase.IndexOf("");
                switch (index)
                {
                    case 0:
                        MessageBox.Show("Mã thu ngân không được để trống");
                        break;
                    case 1:
                        MessageBox.Show("Tên người thu ngân không được để trống");
                        break;
                }
            }
            else
            {
                DataTable dt = new DataTable();
                //Kiem tra xem id da ton tai hay chua
                string querycheck = $"select MaTN from ThuNgan where ThuNgan.MaTN = '{tnId}'";
                string query = $"Insert into ThuNgan values ('{tnId}', N'{tnname}')";
                dt = Request(querycheck);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Id thu ngân đã tồn tại");
                    txbTTN.Text = string.Empty;
                    txbMTN.Enabled = true;
                    txbMTN.Text = string.Empty;
                    return;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        MessageBox.Show($"Thêm mới id = {tnId} thành công!");
                        //Thực hiện thành công
                        LoadData();
                        clear();

                    }
                    else
                    {
                        MessageBox.Show("Thêm người thu ngân mới không thành công!");
                        return;
                    }
                }
            }
        }
        //Xóa 1 nhà cung cấp
        private void btxoa_Click(object sender, EventArgs e)
        {
            string tnId = txbMTN.Text.Trim();
            DataTable dt = new DataTable();
            //Kiem tra xem id da ton tai hay chua
            string query = $"delete from ThuNgan where ThuNgan.MaTN = '{tnId}'";
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa người thu nhân này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {

                string countquerry = $"select MaTN from ThuNgan where ThuNgan.MaTN = '{tnId}'";
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
                        txbMTN.Enabled = true;
                        clear();
                        return;
                    }
                }
            }
            return;
        }
        //Sua thong tin nha cung cap
        private void btSua_Click(object sender, EventArgs e)
        {
            string tnid = txbMTN.Text.Trim();
            string tnname = txbTTN.Text.Trim();

            List<string> inputcase = new List<string>()
            {
                tnid,tnname
            };
            // bắt các case trường hợp không hợp lệ

            if (inputcase.Contains(""))
            {
                int index = inputcase.IndexOf("");
                switch (index)
                {
                    case 0:
                        MessageBox.Show("Mã người thu ngân không được để trống");
                        break;
                    case 1:
                        MessageBox.Show("Tên người thu ngân không được để trống");
                        break;
                }
            }
            else
            {
                DataTable dt = new DataTable();
                string query = $"Update ThuNgan set TenThuNgan = N'{tnname}' where MaTN = '{tnid}'";
                dt = Request(query);
                if (dt != null)
                {
                    MessageBox.Show($"Sửa thông tin người thu ngân {tnid} thành công");
                    LoadData();
                    clear();
                    txbMTN.Enabled = true;
                    return;
                }
            }
        }
        //dong form hien tai
        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }
       
        private void dgvTN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvTN.CurrentRow.Index;
            txbMTN.Text = dgvTN.Rows[i].Cells[0].Value.ToString();
            txbTTN.Text = dgvTN.Rows[i].Cells[1].Value.ToString();
            txbMTN.Enabled = false;
        }
        private void frmTN_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btLuu_Click(object sender, EventArgs e)
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
