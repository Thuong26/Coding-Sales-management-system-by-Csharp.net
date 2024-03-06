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
    public partial class frmXuatChiTiet : Form
    {
        public string dataId { get; set; }
        public decimal dongia { set; get; }
        private ConnectSql connectSql;
        public frmXuatChiTiet()
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
            string query = "SELECT MonNuoc.MaMon from MonNuoc";
            DataTable dt = new DataTable();
            dt = Request(query);
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txbMM.Items.Add(dt.Rows[i]["MaMon"].ToString());
                }
            }
        }

        private void clear()
        {
            txbMM.ResetText();
            txbMXCT.Clear();
            numSL.Value = 0;
            txbMXCT.Enabled = true;
            txbTT.Clear();
        }

        private void LoadData()
        {
            string query;
            if (!string.IsNullOrEmpty(dataId))
            {
                query = $"select * from XuatChiTiet WHERE XuatChiTiet.MDTT = '{dataId}'";
            }
            else
            {
                query = "select * from XuatChiTiet";
            }
            DataTable dt = Request(query);
            if (dt != null)
            {
                dgvNCC.DataSource = dt;
            }
            txbMXCT.Text = dataId;
            txbMXCT.Enabled = false;
        }
        private void frmXuatChiTiet_Load(object sender, EventArgs e)
        {
            LoadHang();
            LoadData();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            decimal thanhtiennum;
            string xcttId = txbMXCT.Text;

            string monID = txbMM.SelectedItem.ToString();
            int numquanlity = int.Parse(numSL.Value.ToString());
            if (!decimal.TryParse(txbTT.Text, out thanhtiennum))
            {
                MessageBox.Show("Thành tiền không đúng kiểu dạng");
                txbTT.Text = "0";
                return;
            }
            else
            {
                DataTable dt = new DataTable();
                thanhtiennum = numquanlity * dongia;
                string query = $"Insert into XuatChiTiet values ('{xcttId}', '{monID}', {numquanlity}, {thanhtiennum})";

                dt = Request(query);
                if (dt != null)
                {
                    MessageBox.Show($"Thêm mới id = {xcttId} thành công!");
                    //Thực hiện thành công
                    LoadData();
                    clear();
                }
                else
                {
                    MessageBox.Show("Thêm phiếu xuất chi tiết mới không thành công!");
                    clear();
                    return;
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            decimal thanhtiennum;
            string bnId = txbMXCT.Text;
            string hangId = txbMM.SelectedItem.ToString();
            int num = int.Parse(numSL.Value.ToString());

            if (string.IsNullOrEmpty(bnId))
            {
                MessageBox.Show("Mã phiếu nhập chi tiết không được trống");
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
                thanhtiennum = dongia * num;
                string subquerry = $"select MDTT,MaMon from XuatChiTiet where MDTT = '{txbMXCT.Text}' and MaMon = '{txbMM.Text}'";
                dt = Request(subquerry);
                if (dt.Rows.Count == 0 || dt == null)
                {
                    MessageBox.Show($"Không tồn tại biên xuất id = {txbMXCT.Text} và mã món = {txbMM.Text}");
                    clear();
                    return;
                }
                else
                {
                    string query = $"Update XuatChiTiet Set MaMon = '{hangId}', SoLuong = {num}, ThanhTien = {thanhtiennum} WHERE XuatChiTiet.MDTT = '{bnId}' and MaMon = '{hangId}'";
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
            string bnId = txbMXCT.Text.Trim();
            string hangId = txbMM.SelectedItem.ToString();
            DataTable dt = new DataTable();
            //Kiem tra xem id da ton tai hay chua
            string query = $"delete from XuatChiTiet where XuatChiTiet.MDTT = '{bnId}' and MaMon = '{hangId}'";
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {
                string countquerry = $"select MDTT,MaMon from XuatChiTiet where XuatChiTiet.MDTT = '{bnId}' and MaMon = '{hangId}'";
                dt = Request(countquerry);
                if (dt.Rows.Count == 0 || dt == null)
                {
                    MessageBox.Show("Mã phiếu xuất chi tiết không tồn tại!");
                    return;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        //Thực hiện thành công
                        LoadData();
                        txbMXCT.Enabled = true;
                        clear();
                        return;
                    }
                }
            }
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hangID = txbMM.SelectedItem.ToString();
            string query = $"Select Dongia from MonNuoc where MaMon = '{hangID}'";
            DataTable dt = new DataTable();
            dt = Request(query);
            if (dt.Rows.Count >= 0 && dt.Rows[0]["Dongia"] != null)
            {
                dongia = decimal.Parse(dt.Rows[0]["Dongia"].ToString());
            }
            else
            {
                dongia = 0;
            }
            int num = int.Parse(numSL.Value.ToString());
            txbTT.Text = $"{dongia * num}";
        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNCC.CurrentRow.Index;
            txbMXCT.Text = dgvNCC.Rows[i].Cells[0].Value.ToString();
            txbMM.SelectedItem = dgvNCC.Rows[i].Cells[1].Value.ToString();
            numSL.Value = decimal.Parse(dgvNCC.Rows[i].Cells[2].Value.ToString());
            txbTT.Text = dgvNCC.Rows[i].Cells[3].Value.ToString();

        }
        private void numSL_ValueChanged(object sender, EventArgs e)
        {
            int num = int.Parse(numSL.Value.ToString());
            txbTT.Text = $"{num * dongia}";
        }
    }
}
