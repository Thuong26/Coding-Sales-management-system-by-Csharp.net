using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace QLBH
{
    public partial class frmNhapChiTiet : Form
    {
        private ConnectSql connectSql;

        public string dataid { get; set; }

        public frmNhapChiTiet()
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

        private void LoadHang()
        {
            string query = "SELECT MaHang FROM Hang";
            string query1 = "SELECT DonGia FROM Hang";
            DataTable dt = Request(query);
            DataTable dt2 = Request(query1);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    txbMH.Items.Add(row["MaHang"].ToString());
                }

                if (dt2.Rows.Count > 0)
                {
                    txbDG.Text = dt2.Rows[0]["DonGia"].ToString();
                }
            }
        }


        private void LoadData()
        {
            string query = string.IsNullOrEmpty(dataid)
                ? "SELECT * FROM NhapChiTiet"
                : $"SELECT * FROM NhapChiTiet WHERE NhapChiTiet.MBN = '{dataid}'";

            DataTable dt = Request(query);

            if (dt != null)
            {
                dgvNCC.DataSource = dt;
            }

            txbMNCT.Text = dataid;
        }

        private void clear()
        {
            txbMH.ResetText();
            txbMNCT.Clear();
            numSl.Value = 0;
            txbDG.Clear();
            txbTT.Clear();
            txbGC.Clear();
            txbMNCT.Enabled = true;
        }

        private void frmNhapChiTiet_Load(object sender, EventArgs e)
        {
            LoadHang();
            LoadData();
        }


        private void btthem_Click(object sender, EventArgs e)
        {
            int numquanlity; decimal dongia, thanhtiennum;
            string bnId = txbMNCT.Text;
            string hangId = txbMH.SelectedItem.ToString();
            string num = numSl.Value.ToString();
            string dgNum = txbDG.Text;
            string gc = txbGC.Text;
            if (!int.TryParse(numSl.Value.ToString(), out numquanlity))
            {
                MessageBox.Show("Số lượng là kiểu nguyên");
                numSl.Value = 0;
                return;
            }
            else if (!decimal.TryParse(txbDG.Text.Trim().ToString(), out dongia))
            {
                MessageBox.Show("Đơn giá không hợp lệ");
                txbDG.Text = string.Empty;
                return;
            }
            else if (!decimal.TryParse(txbTT.Text, out thanhtiennum))
            {
                MessageBox.Show("Thành tiền không hợp lệ");
                return;
            }
            else
            {
                DataTable dt = new DataTable();
                numquanlity = int.Parse(num);
                dongia = decimal.Parse(dgNum);
                thanhtiennum = numquanlity * dongia;
                string query = $"Insert into NhapChiTiet values ('{bnId}', '{hangId}', {numquanlity}, {dongia}, {thanhtiennum}, N'{gc}')";

                dt = Request(query);
                if (dt != null)
                {
                    MessageBox.Show($"Thêm mới id = {bnId} thành công!");
                    //Thực hiện thành công
                    LoadData();
                    clear();
                }
                else
                {
                    MessageBox.Show("Thêm phiếu nhập chi tiết mới không thành công!");
                    clear();
                    return;
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            decimal numquanlity; decimal dongia, thanhtiennum;
            string bnId = txbMNCT.Text;
            string hangId = txbMH.SelectedItem.ToString();
            string num = numSl.Value.ToString();
            string dgNum = txbDG.Text;
            string gc = txbGC.Text;

            if (string.IsNullOrEmpty(bnId))
            {
                MessageBox.Show("Mã phiếu nhập chi tiết không được trống");
                return;
            }
            else if (!decimal.TryParse(numSl.Value.ToString(), out numquanlity))
            {
                MessageBox.Show("Số lượng là kiểu nguyên");
                numSl.Value = 0;
                return;
            }
            else if (!decimal.TryParse(txbDG.Text.Trim().ToString(), out dongia))
            {
                MessageBox.Show("Đơn giá không hợp lệ");
                txbDG.Text = string.Empty;
                return;
            }
            else if (!decimal.TryParse(txbTT.Text, out thanhtiennum))
            {
                MessageBox.Show("Thành tiền không hợp lệ");
                return;
            }
            else
            {
                DataTable dt = new DataTable();
                numquanlity = int.Parse(num);
                dongia = decimal.Parse(dgNum);
                thanhtiennum = numquanlity * dongia;
                string subquerry = $"select MBN from Nhap where MBN = '{txbMNCT.Text}'";
                dt = Request(subquerry);
                if (dt.Rows.Count == 0 || dt == null)
                {
                    MessageBox.Show($"Không tồn tại biên nhập = {txbMNCT.Text}");
                    clear();
                    return;
                }
                else
                {
                    string query = $"Update NhapChiTiet Set MaHang = '{hangId}', SoLuong = {numquanlity}, DonGia = {dongia}, ThanhTien = {thanhtiennum} WHERE NhapChiTiet.MBN = '{bnId}'";
                    MessageBox.Show(query);
                    dt = Request(query);
                    if (dt != null)
                    {
                        MessageBox.Show($"Sửa thông tin id = {bnId} thành công!");
                        //Thực hiện thành công
                        LoadData();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin không thành công!");
                        clear();
                        return;
                    }
                }

            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string bnId = txbMNCT.Text.Trim();
            string hangId = txbMH.SelectedItem.ToString();
            DataTable dt = new DataTable();
            //Kiem tra xem id da ton tai hay chua
            string query = $"delete from NhapChiTiet where NhapChiTiet.MBN = '{bnId}' and MaHang = '{hangId}'";
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {
                string countquerry = $"select MBN,MaHang from NhapChiTiet where NhapChiTiet.MBN = '{bnId}' and MaHang = '{hangId}'";
                dt = Request(countquerry);
                if (dt.Rows.Count == 0 || dt == null)
                {
                    MessageBox.Show("Mã phiếu nhập chi tiết không tồn tại!");
                    return;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        //Thực hiện thành công
                        LoadData();
                        txbMNCT.Enabled = true;
                        clear();
                        return;
                    }
                }
            }
            return;
        }

        private void txbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hangID = txbMH.SelectedItem.ToString();
            string query = $"Select Dongia from Hang where MaHang = '{hangID}'";
            DataTable dt = new DataTable();
            dt = Request(query);
            if (dt.Rows.Count >= 0 && dt.Rows[0]["Dongia"] != null)
            {
                txbDG.Text = dt.Rows[0]["Dongia"].ToString();
            }
            else
            {
                txbDG.Text = "0";
            }
        }
        private void numSl_ValueChanged(object sender, EventArgs e)
        {
            decimal dongia;
            if (txbDG.Text == "" || txbDG.Text == null || !decimal.TryParse(txbDG.Text, out dongia))
            {
                txbTT.Text = "0";
            }
            else
            {
                txbTT.Text = $"{numSl.Value * decimal.Parse(txbDG.Text)}";
            }
        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNCC.CurrentRow.Index;
            txbMNCT.Text = dgvNCC.Rows[i].Cells[0].Value.ToString();

            // Check if the item exists in the ComboBox before setting it
            string selectedMH = dgvNCC.Rows[i].Cells[1].Value.ToString();
            if (txbMH.Items.Contains(selectedMH))
            {
                txbMH.SelectedItem = selectedMH;
            }
            else
            {
                // Handle the case when the item doesn't exist in the ComboBox
                // You can display a message or handle it as appropriate for your application.
                MessageBox.Show("Selected item not found in the ComboBox.");
            }

            numSl.Value = decimal.Parse(dgvNCC.Rows[i].Cells[2].Value.ToString());
            txbDG.Text = dgvNCC.Rows[i].Cells[3].Value.ToString();
            txbTT.Text = dgvNCC.Rows[i].Cells[4].Value.ToString();
            txbGC.Text = dgvNCC.Rows[i].Cells[5].Value.ToString();
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void cancle_Click_1(object sender, EventArgs e)
        {
            clear();
        }
    }
}
