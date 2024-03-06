using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    internal class ConnectSql : IConnect
    {
        private static string connstr = @"Data Source=HUYEN-THUONG\SQLEXPRESS;Initial Catalog=BigHome;Persist Security Info=True;User ID=admin;Password=qtcsdl.2023;Encrypt=True;TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(connstr);
        public void openConnect()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnect()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
        // thuc hien request
        public DataTable Request(string cmd)
        {
            openConnect();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(sc);
                //gan data vao datatale
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                MessageBox.Show(ex.Message);
            }
            closeConnect();
            return dt;
        }



    }
}
