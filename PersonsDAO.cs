using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace StMana_Nhap
{
    public class PersonsDAO
    {
        DBConnection dbcn = new DBConnection();
        public DataTable LoadData(string sqlConn)
        {
            return dbcn.LoadData(sqlConn);
        }

        public void Add(string sql)
        {
            if (dbcn.ExecuteQuery(sql))
            {
                MessageBox.Show("Thêm thành công");
            }
        }

        public void Remove(string sql)
        {
            if (dbcn.ExecuteQuery(sql))
            {
                MessageBox.Show("Xóa thành công");
            }
        }

        public void Edit(string sql)
        {
            if (dbcn.ExecuteQuery(sql))
            {
                MessageBox.Show("Cập nhật thành công");
            }
        }
    }
}
