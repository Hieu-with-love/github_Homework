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
    public class StudentsDAO : PersonsDAO
    {
        string sql;
        public DataTable LoadDataForSt()
        {
            sql = "SELECT * FROM SinhVien";
            return base.LoadData(sql);
        }
        public void AddSt(Students st)
        {
            sql = $"INSERT INTO SinhVien(hoten,email,gioitinh,diachi,sdt,cccd,ngaysinh) VALUES(N'{st.Name}','{st.Email}',{st.Sex},N'{st.Address}','{st.Phone}','{st.Cccd}','{st.Birthday.ToString()}')";
            base.Add(sql);
        }
        public void RemoveSt(Students st)
        {
            sql = $"DELETE FROM SinhVien WHERE id = '{st.Id}'";
            base.Remove(sql);
        }
    }
}
