using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmBan : Form
    {
        private string connectionString = @"Data Source=HUYEN-THUONG\SQLEXPRESS;Initial Catalog=cafebighome;Persist Security Info=True;User ID=admin;Password=qtcsdl.2023;Encrypt=True;TrustServerCertificate=True";

        public frmBan()
        {
            InitializeComponent();
        }

       

        DataSet LoadData()
        {
            DataSet dataTable = new DataSet();
            string query = "SELECT * FROM Ban";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                   
                adapter.Fill(dataTable);
                connection.Close();
                    
            }

             return dataTable;
        }

        void load_ban()
        {
            DataSet data = LoadData();
            flp_ban.Controls.Clear();
            foreach (DataRow row in data.Tables[0].Rows)
            {
                string tablenumber = row["SoBan"].ToString();
                string tablestatus = row["TrangThai"].ToString();

                // tạo button
                Button tablebutton = new Button()
                {
                    Width = 50,
                    Height = 50,
                    Text = tablenumber.ToString() + "\n" + tablestatus,
                    Tag = tablenumber // lưu trữ số bàn nằm trong thuộc tính tag
                };
                // thêm sự kiện click cho button
                tablebutton.Click += TableButton_Click;
                // thêm button vào flowlayoutpanel
                flp_ban.Controls.Add(tablebutton);
            }
        }
        private void TableButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Lấy số bàn từ thuộc tính Tag của button
                string selectedTableNumber = button.Tag.ToString();
                // Hiển thị số bàn trên thanh txtSoBan
                txtSoBan.Text = selectedTableNumber.ToString();
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string soBan = txtSoBan.Text.PadLeft(5);
                    string trangThai = txtTrangThai.Text;

                    string query = "INSERT INTO Ban (SoBan, TrangThai) VALUES (@SoBan, @TrangThai)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SoBan", soBan);
                    command.Parameters.AddWithValue("@TrangThai", trangThai);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công!");

                    LoadData();
                    load_ban(); // Làm mới FlowLayoutPanel sau khi thêm bản ghi mới
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string soBan = txtSoBan.Text.PadLeft(5);
                    string trangThai = txtTrangThai.Text;

                    string query = "UPDATE Ban SET TrangThai = @TrangThai WHERE SoBan = @SoBan";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SoBan", soBan);
                    command.Parameters.AddWithValue("@TrangThai", trangThai);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật trạng thái thành công!");
                        LoadData();
                        load_ban();
                    }
                    else
                    {
                        MessageBox.Show("Bàn không tồn tại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string soBan = txtSoBan.Text.PadLeft(5);
                    string trangThaiTrong = "Trống"; // Set the status to "Trống" when deleting

                    string query = "UPDATE Ban SET TrangThai = @TrangThaiTrong WHERE SoBan = @SoBan";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SoBan", soBan);
                    command.Parameters.AddWithValue("@TrangThaiTrong", trangThaiTrong);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa thành công! Trạng thái đã được cập nhật thành 'Trống'.");
                        LoadData();
                        load_ban(); // Làm mới FlowLayoutPanel sau khi cập nhật trạng thái
                    }
                    else
                    {
                        MessageBox.Show("Bàn không tồn tại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btTracuuBan_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Assuming your TextBox for searching is named txtTracuuBan
                    string searchTerm = txtTracuuBan.Text.Trim();

                    string query = "SELECT * FROM Ban WHERE SoBan LIKE @SearchTerm OR TrangThai LIKE @SearchTerm";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    flp_ban.Controls.Clear();  // Clear existing buttons in the FlowLayoutPanel

                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            int tablenumber = Convert.ToInt32(row["SoBan"]);
                            string tablestatus = row["TrangThai"].ToString();

                            // tạo button
                            Button tablebutton = new Button()
                            {
                                Width = 50,
                                Height = 50,
                                Text = "Bàn" + tablenumber.ToString() + "\n" + tablestatus,
                                Tag = tablenumber
                            };
                            flp_ban.Controls.Add(tablebutton);
                        }

                        MessageBox.Show("Tìm kiếm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btTroLai_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void frmBan_Load(object sender, EventArgs e)
        {
            LoadData();
            load_ban();
        }
    }
}