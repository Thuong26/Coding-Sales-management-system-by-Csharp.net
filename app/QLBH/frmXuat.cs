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
    public partial class frmXuat : Form
    {

        private ConnectSql connectSql;
       
        public frmXuat()
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
            string query = "SELECT ThuNgan.MaTN from ThuNgan";
            DataTable dt = new DataTable();
            dt = Request(query);

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txbMTN.Items.Add(dt.Rows[i]["MaTN"].ToString());
                }
            }
        }

        private void LoadBan()
        {
            string query = "SELECT Ban.SoBan from Ban";
            DataTable dt = new DataTable();
            dt = Request(query);

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    txbSB.Items.Add(dt.Rows[i]["SoBan"].ToString());
                }
            }
        }

        private void clear()
        {
            txbMDMX.Clear();
            txbMTN.ResetText();
            txbSB.ResetText();
            dateCash.Value = DateTimePicker.MinimumDateTime;
            txbTT.Clear();
            txbMaTT.ResetText();
            txbTKD.Clear();
            txbTL.Clear();
            txbMDMX.Enabled = true;
        }


        private void LoadData()
        {
            string query = "select * from Xuat";
            DataTable dt = Request(query);
            if (dt != null)
            {
                dgvNCC.DataSource = dt;
            }
        }
        private void frmXuat_Load(object sender, EventArgs e)
        {
            LoadNCC();
            LoadBan();
            LoadData();
            dgvNCC.CellClick += dgvNCC_CellClick;
        }
        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) 
            {
                txbMDMX.Text = dgvNCC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            decimal ttnum, kdnum, tralai;
            string xnId = txbMDMX.Text;
            string tnId = txbMTN.SelectedItem.ToString();
            string pttt = txbMaTT.SelectedItem.ToString();
            DateTime dateId = dateCash.Value;
            string sb = txbSB.SelectedItem.ToString();
            if (!decimal.TryParse(txbTT.Text, out ttnum))
            {
                MessageBox.Show("Không đúng định dạng tiền");
                txbTT.Text = string.Empty;
                return;
            }
            else if (!decimal.TryParse(txbTKD.Text, out kdnum))
            {
                MessageBox.Show("Không đúng định dạng tiền");
                txbTKD.Text = string.Empty;
                return;
            }
            else if (!decimal.TryParse(txbTL.Text, out tralai))
            {
                MessageBox.Show("Không đúng định dạng tiền");
                txbTL.Text = string.Empty;
                return;
            }
            // bắt các case trường hợp không hợp lệ
            else
            {
                DataTable dt = new DataTable();
                //Kiem tra xem id da ton tai hay chua
                string querycheck = $"select MDTT from Xuat where Xuat.MDTT = '{xnId}'";
                string query = $"Insert into Xuat values ('{xnId}','{dateId.ToString("yyyy-MM-dd")}','{tnId}', '{sb}', N'{pttt}',{ttnum}, {kdnum}, {tralai})";
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
                        MessageBox.Show($"Thêm mới id = {xnId} thành công!");
                        //Thực hiện thành công
                        LoadData();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm biên xuất mới không thành công!");
                        clear();
                        return;
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            decimal ttnum, kdnum, tralai;
            string xnId = txbMDMX.Text;
            string tnId = txbMTN.SelectedItem.ToString();
            string pttt = txbMaTT.SelectedItem.ToString();
            DateTime dateId = dateCash.Value;
            string sb = txbSB.SelectedItem.ToString();
            if (!decimal.TryParse(txbTKD.Text, out kdnum))
            {
                MessageBox.Show("Thành tiền không đúng định dạng");
                txbTKD.Text = string.Empty;
                return;
            }
            else if (!decimal.TryParse(txbTL.Text, out tralai))
            {
                MessageBox.Show("Tổng thành tiền không đúng định dạng");
                txbTL.Text = string.Empty;
                return;
            }
            else
            {
                ttnum = decimal.Parse(txbTT.Text);
                kdnum = decimal.Parse(txbTKD.Text);
                tralai = decimal.Parse(txbTL.Text);

                DataTable dt = new DataTable();
                string query = $"Update Xuat set NgayTT = '{dateId.ToString("yyyy-MM-dd")}',MaTN = '{tnId}', SoBan='{sb}', PhuongThucTT = N'{pttt}', TongTT = {ttnum}, TienKT = {kdnum}, TienTraLai = {tralai} where MDTT = '{xnId}'";
                string countquerry = $"select MDTT from Xuat where Xuat.MDTT = '{xnId}'";
                MessageBox.Show(query);
                dt = Request(countquerry);
                if (dt.Rows.Count == 0 || dt == null)
                {
                    MessageBox.Show("Mã biên xuất không tồn tại!");
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
                        txbMDMX.Enabled = true;
                        return;
                    }
                }
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string bnId = txbMDMX.Text.Trim();
            DataTable dt = new DataTable();
            //Kiem tra xem id da ton tai hay chua
            string query = $"delete from Xuat where Xuat.MDTT = '{bnId}'";
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa biên nhân này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {
                string countquerry = $"select MDTT from Xuat where Xuat.MDTT = '{bnId}'";
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
                        txbMDMX.Enabled = true;
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
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmXuatChiTiet frm = new frmXuatChiTiet();
            frm.dataId = txbMDMX.Text;
            frm.Show();
        }
    }
}
