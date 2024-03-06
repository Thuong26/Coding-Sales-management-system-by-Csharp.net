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
    public partial class fmsDVVC : Form
    {

        private ConnectSql connectSql;
        public fmsDVVC()
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
            txbMDVVC.Clear();
            txbTenDVVC.Clear();
            txbNhapDVVC.Clear();
            txbTracuuMVC.Clear();
            txbMDVVC.Enabled = true;
        }
        //Load toan bo khi vao form
        private void LoadData()
        {
            string query = "select DonViVanChuyen.MaVC,DonViVanChuyen.DVGH from DonViVanChuyen";
            DataTable dt = Request(query);
            if (dt != null)
            {
                dgvDVVC.DataSource = dt;
            }
        }

        private void fmsDVVC_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string transfername = txbNhapDVVC.Text.Trim().ToLower();
            if (transfername == "")
            {
                MessageBox.Show("Bạn cần nhập tên để tìm kiếm");
                return;
            }
            else
            {
                // query lay danh sach ten nguoi dung
                string query = $"select DonViVanChuyen.MaVC,DonViVanChuyen.DVGH from DonViVanChuyen where DVGH collate Latin1_General_CI_AI like N'%{transfername}%'";
                DataTable dt = Request(query);
                if (dt != null)
                {
                    dgvDVVC.DataSource = dt;
                    clear();
                    txbNhapDVVC.Text = transfername;
                }
                return;
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clear();
            LoadData();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            string transgerId = txbMDVVC.Text.Trim();
            string transferName = txbTenDVVC.Text.Trim();

            List<string> inputcase = new List<string>()
            {
                transgerId,transferName
            };
            // bắt các case trường hợp không hợp lệ

            if (inputcase.Contains(""))
            {
                int index = inputcase.IndexOf("");
                switch (index)
                {
                    case 0:
                        MessageBox.Show("Mã đơn vị vẩn chuyển không được để trống");
                        break;
                    case 1:
                        MessageBox.Show("Tên đơn vị vận chuyển không được để trống");
                        break;
                }
            }
            else
            {
                DataTable dt = new DataTable();
                //Kiem tra xem id da ton tai hay chua
                string querycheck = $"select MaVC from DonViVanChuyen where DonViVanChuyen.MaVC = '{transgerId}'";
                string query = $"Insert into DonViVanChuyen values ('{transgerId}', N'{transferName}')";
                dt = Request(querycheck);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Id đơn vị đã tồn tại");
                    txbMDVVC.Text = string.Empty;
                    txbMDVVC.Enabled = true;
                    txbTenDVVC.Text = string.Empty;
                    return;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        MessageBox.Show($"Thêm mới id = {transgerId} thành công!");
                        //Thực hiện thành công
                        LoadData();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm đơn vị vận chuyển mới không thành công!");
                        return;
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string transferId =  txbMDVVC.Text.Trim();
            string transferName = txbTenDVVC.Text.Trim();

            List<string> inputcase = new List<string>()
            {
                transferId,transferName
            };
            // bắt các case trường hợp không hợp lệ

            if (inputcase.Contains(""))
            {
                int index = inputcase.IndexOf("");
                switch (index)
                {
                    case 0:
                        MessageBox.Show("Mã đơn vị giao hàng không được để trống");
                        break;
                    case 1:
                        MessageBox.Show("Tên đơn vị giao hàng không được để trống");
                        break;
                }
            }
            else
            {
                DataTable dt = new DataTable();
                string query = $"Update DonViVanChuyen set DVGH = N'{transferName}' where MaVC = '{transferId}'";
                string countquerry = $"select MaVC from DonViVanChuyen where DonViVanChuyen.MaVC = '{transferId}'";
                dt = Request(countquerry);
                if (dt.Rows.Count == 0 || dt == null)
                {
                    MessageBox.Show("Mã đơn vị không tồn tại!");
                    return;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        MessageBox.Show($"Sửa thông tin đơn vị {transferId} thành công");
                        LoadData();
                        clear();
                        txbMDVVC.Enabled = true;
                        return;
                    }
                }
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string transferId = txbMDVVC.Text.Trim();
            DataTable dt = new DataTable();
            //Kiem tra xem id da ton tai hay chua
            string query = $"delete from DonViVanChuyen where DonViVanChuyen.MaVC = '{transferId}'";
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn vị này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (res == DialogResult.Yes)
            {

                string countquerry = $"select MaVC from DonViVanChuyen where DonViVanChuyen.MaVC = '{transferId}'";
                dt = Request(countquerry);
                if (dt.Rows.Count == 0 || dt == null)
                {
                    MessageBox.Show("Mã đơn vị không tồn tại!");
                    return;
                }
                else
                {
                    dt = Request(query);
                    if (dt != null)
                    {
                        //Thực hiện thành công
                        LoadData();
                        txbMDVVC.Enabled = true;
                        clear();
                        return;
                    }
                }
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btTracuu_Click(object sender, EventArgs e)
        {
            string transferID = txbTracuuMVC.Text.Trim();
            if (transferID == "")
            {
                MessageBox.Show("Mã đơn vị giao hàng không được để trống!");
                return;
            }
            else
            {
                string query = $"select DonViVanChuyen.MaVC, DonViVanChuyen.DVGH from DonViVanChuyen where DonViVanChuyen.MaVC = '{transferID}'";
                DataTable dt = Request(query);
                if (dt != null)
                {
                    dgvDVVC.DataSource = dt;
                    clear();
                    txbTracuuMVC.Text = transferID;
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy dơn vị giao hàng với id = {transferID}");
                }
                return;
            }
        }

        private void dgvDVVC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDVVC.CurrentRow.Index;
            txbMDVVC.Text = dgvDVVC.Rows[i].Cells[0].Value.ToString();
            txbTenDVVC.Text = dgvDVVC.Rows[i].Cells[1].Value.ToString();
            txbMDVVC.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btQL_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clear();
        }
    }
}
