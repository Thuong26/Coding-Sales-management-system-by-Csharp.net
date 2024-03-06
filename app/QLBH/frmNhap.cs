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
    public partial class frmNhap : Form
    {
        private ConnectSql connectSql;
        public frmNhap()
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
        private void LoadNCC()
        {
            string query = "SELECT NhaCungCap.MaNCC from NhaCungCap";
            DataTable dt = new DataTable();
            dt = Request(query);

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    maNCC.Items.Add(dt.Rows[i]["MaNCC"].ToString());
                }
            }
        }
        private void LoadNDH()
        {
            string query = "SELECT NguoiDatHang.MaNDH from NguoiDatHang";
            DataTable dt = new DataTable();
            dt = Request(query);

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    maNDH.Items.Add(dt.Rows[i]["MaNDH"].ToString());
                }
            }
        }

        private void LoadNNH()
        {
            string query = "SELECT NguoiNhanHang.MaNN from NguoiNhanHang";
            DataTable dt = new DataTable();
            dt = Request(query);

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    maNN.Items.Add(dt.Rows[i]["MaNN"].ToString());
                }
            }
        }

        private void LoadNQL()
        {
            string query = "SELECT QuanLy.MaQL from QuanLy";
            DataTable dt = new DataTable();
            dt = Request(query);

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    maQL.Items.Add(dt.Rows[i]["MaQL"].ToString());
                }
            }
        }

        private void LoadDVVC()
        {
            string query = "SELECT DonViVanChuyen.MaVC from DonViVanChuyen";
            DataTable dt = new DataTable();
            dt = Request(query);

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    maDVCC.Items.Add(dt.Rows[i]["MaVC"].ToString());
                }
            }
        }

        private void clear()
        {
            txbMBN.Clear();
            maNDH.ResetText();
            maNN.ResetText();
            maDVCC.ResetText();
            maQL.ResetText();
            maDVCC.ResetText();
            maNCC.ResetText();
            thanhtien.Clear();
            txbMBN.Enabled = true;
        }


        private void LoadData()
        {
            string query = "select * from Nhap";
            DataTable dt = Request(query);
            if (dt != null)
            {
                dgvNCC.DataSource = dt;
            }
        }
        private void frmNhap_Load(object sender, EventArgs e)
        {
            LoadNCC();
            LoadDVVC();
            LoadNDH();
            LoadNNH();
            LoadNQL();
            LoadData();
            dgvNCC.CellClick += dgvNCC_CellClick;
        }
        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvNCC.Columns["MBN"].Index)
            {
                txbMBN.Text = dgvNCC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }
        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNCC.CurrentRow.Index;
            txbMBN.Text = dgvNCC.Rows[i].Cells[0].Value.ToString();
            maNDH.SelectedItem = dgvNCC.Rows[i].Cells[1].Value.ToString();
            maNN.SelectedItem = dgvNCC.Rows[i].Cells[2].Value.ToString();
            maQL.SelectedItem = dgvNCC.Rows[i].Cells[3].Value.ToString();
            maNCC.SelectedItem = dgvNCC.Rows[i].Cells[4].Value.ToString();
            maDVCC.SelectedItem = dgvNCC.Rows[i].Cells[5].Value.ToString();
            thanhtien.Text = dgvNCC.Rows[i].Cells[7].Value.ToString(); 
            txbMBN.Enabled = false;
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            //decimal vatnum, thanhtiennum, tongthanhtiennum;
            string bnId = txbMBN.Text;
            string ndhId = maNDH.SelectedItem.ToString();
            string nnId = maNN.SelectedItem.ToString();
            string qlId = maQL.SelectedItem.ToString();
            string nccId = maNCC.SelectedItem.ToString();
            string dvvcId = maDVCC.SelectedItem.ToString();
            thanhtien.Text = "0";
            List<string> inputcase = new List<string>()
            {
                bnId,ndhId,nnId,qlId,nccId,dvvcId
            };
            // bắt các case trường hợp không hợp lệ

            if (inputcase.Contains(""))
            {
                int index = inputcase.IndexOf("");
                switch (index)
                {
                    case 0:
                        MessageBox.Show("Mã phiếu không được để trống");
                        break;
                    case 1:
                        MessageBox.Show("Mã người đặt không được để trống");
                        break;
                    case 2:
                        MessageBox.Show("Mã người nhận không được để trống");
                        break;
                    case 3:
                        MessageBox.Show("Mã quản lý không được để trống");
                        break;
                    case 4:
                        MessageBox.Show("Mã nhà cung cấp không được để trống");
                        break;
                    case 5:
                        MessageBox.Show("Mã đơn vị vận chuyển không đc để trống");
                        break;
                }
            }
            else
            {
                DataTable dt = new DataTable();
                //Kiem tra xem id da ton tai hay chua
                string querycheck = $"select MBN from Nhap where Nhap.MBN = '{bnId}'";
                string query = $"Insert into Nhap values ('{bnId}', 0,'{ndhId}', '{nnId}', '{qlId}', '{nccId}', '{dvvcId}')";
                dt = Request(querycheck);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Id biên nhập đã tồn tại");
                    clear();
                    return;
                }
                else
                {
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
                        MessageBox.Show("Thêm biên nhập mới không thành công!");
                        clear();
                        return;
                    }
                }
            }

        }
                
        private void btSua_Click(object sender, EventArgs e)
        {
            decimal thanhtiennum;
            string bnId = txbMBN.Text;
            string ndhId = maNDH.SelectedItem.ToString();
            string nnId = maNN.SelectedItem.ToString();
            string qlId = maQL.SelectedItem.ToString();
            string nccId = maNCC.SelectedItem.ToString();
            string dvvcId = maDVCC.SelectedItem.ToString();
            List<string> inputcase = new List<string>()
            {
                bnId,ndhId,nnId,qlId,nccId,dvvcId
            };
            if (!decimal.TryParse(thanhtien.Text, out thanhtiennum))
            {
                MessageBox.Show("Thành tiền không đúng định dạng");
                thanhtien.Text = string.Empty;
                return;
            }
            // bắt các case trường hợp không hợp lệ

            else if (inputcase.Contains(""))
            {
                int index = inputcase.IndexOf("");
                switch (index)
                {
                    case 0:
                        MessageBox.Show("Mã phiếu không được để trống");
                        break;
                    case 1:
                        MessageBox.Show("Mã người đặt không được để trống");
                        break;
                    case 2:
                        MessageBox.Show("Mã người nhận không được để trống");
                        break;
                    case 3:
                        MessageBox.Show("Mã quản lý không được để trống");
                        break;
                    case 4:
                        MessageBox.Show("Mã nhà cung cấp không được để trống");
                        break;
                    case 5:
                        MessageBox.Show("Mã đơn vị vận chuyển không đc để trống");
                        break;
                }
            }
            else
            {
                DataTable dt = new DataTable();
                string query = $"Update Nhap set ThanhTien = {thanhtiennum}, MaNDH = '{ndhId}',MaNN = '{nnId}', MaQL='{qlId}', MaNCC = '{nccId}', MaVC ='{dvvcId}' where MBN = '{bnId}'";
                string countquerry = $"select MBN from Nhap where Nhap.MBN = '{bnId}'";
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
                        MessageBox.Show($"Sửa thông tin biên nhập thành công");
                        LoadData();
                        clear();
                        txbMBN.Enabled = true;
                        return;
                    }
                }
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string bnId = txbMBN.Text.Trim();
            DataTable dt = new DataTable();
            //Kiem tra xem id da ton tai hay chua
            string query = $"delete from Nhap where Nhap.MBN = '{bnId}'";
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa biên nhân này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {
                string countquerry = $"select MBN from Nhap where Nhap.MBN = '{bnId}'";
                dt = Request(countquerry);
                if (dt.Rows.Count == 0 || dt == null)
                {
                    MessageBox.Show("Mã biên nhận không tồn tại!");
                    return;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        //Thực hiện thành công
                        LoadData();
                        txbMBN.Enabled = true;
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
        private void btn_NCT_Click(object sender, EventArgs e)
        {
            frmNhapChiTiet fromn = new frmNhapChiTiet();
            fromn.dataid = txbMBN.Text;
            fromn.Show();
        }
        private void btn_refresh_Click(object sender, EventArgs e)
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
