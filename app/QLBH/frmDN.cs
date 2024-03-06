using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmDN : Form
    {
        private static string connstr = @"Data Source=HUYEN-THUONG\SQLEXPRESS;Initial Catalog=BigHome;Persist Security Info=True;User ID=admin;Password=qtcsdl.2023;Encrypt=True;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(connstr);
        DataTable dt = null;

        private void openConnect()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        private void closeConnect()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        private DataTable Request(string cmd, SqlParameter[] parameters)
        {
            openConnect();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, conn);
                sc.Parameters.AddRange(parameters);
                SqlDataAdapter adapter = new SqlDataAdapter(sc);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                MessageBox.Show(ex.Message);
                throw;
            }
            closeConnect();
            return dt;
        }

        public frmDN()
        {
            InitializeComponent();
        }

        public void ShowLoginForm()
        {
            this.Show();
        }

        public void HideLoginForm()
        {
            this.Hide();
        }

        private void frmDN_Load(object sender, EventArgs e)
        {
        }

        private void btDN_Click_1(object sender, EventArgs e)
        {
            string username = txtDN.Text.Trim();
            string password = txtMK.Text.Trim();
            // chưa phòng chống sql injection
            /*
            string query = $"select * from DANGNHAP where DANGNHAP.TAIKHOAN='"+txtTDN.Text+"'  and DANGNHAP.MATKHAU = '"+txtMK.Text+"'";
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Show();
            */
            // phòng chống sql injection
            string query = "SELECT * FROM DANGNHAP WHERE DANGNHAP.TAIKHOAN = @Username AND DANGNHAP.MATKHAU = @Password";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", SqlDbType.NVarChar) { Value = username },
                new SqlParameter("@Password", SqlDbType.NVarChar) { Value = password }
            };

            dt = Request(query, parameters);
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                return;
            }
            else
            {
                Form1 form1 = new Form1();
                form1.FormClosed += (s, args) => ShowLoginForm();
                this.Hide();
                form1.ShowDialog();
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
