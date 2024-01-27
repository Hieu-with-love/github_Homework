using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace StMana_Nhap
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=StudentsManagerment;Integrated Security=True");
        SqlCommand cmd;
        DataTable dt;

        public DataTable LoadData(string sqlConn)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmd = new SqlCommand(sqlConn, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tải dữ liệu thất bại !\n" + ex.Message);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public bool ExecuteQuery(string sql)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi thất bại !\n" + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
    }
}
