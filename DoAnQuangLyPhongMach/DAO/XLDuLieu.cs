using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuangLyPhongMach.DAO
{
    class XLDuLieu
    {
        /*
        string duong_dan = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""D:\DTTX\Thiết Kế phần mền\DoAn\1881137_ThaiThienPhong\DoAnQuangLyPhongMach\DoAnQuangLyPhongMach\DataBasePhongKham.accdb"";Persist Security Info=True";

        public DataTable LayDuLieu(string sql)
        {
            OleDbConnection ket_noi = new OleDbConnection(duong_dan);

            OleDbDataAdapter bo_du_lieu = new OleDbDataAdapter(sql, ket_noi);

            DataTable bang = new DataTable();
            bo_du_lieu.Fill(bang);

            return bang;
        }

        public int ThucThi(string sql)
        {
            OleDbConnection ket_noi = new OleDbConnection(duong_dan);

            OleDbCommand lenh = new OleDbCommand(sql, ket_noi);
            ket_noi.Open();

            var kq = lenh.ExecuteNonQuery();

            ket_noi.Close();
            return kq;
        }
        public int TimMaSo(String tenBang, String tenCot  )
        {
            int maso;
            string strSQL = String.Format("Select Max({0}) as ma from {1}  ", tenCot, tenBang);
            DataTable dt = LayDuLieu(strSQL);
            maso = int.Parse(dt.Rows[0]["ma"].ToString());
           
            return maso;
        }
        */
        string duong_dan = @"Data Source=admin;Initial Catalog=DB_PhongKham_1881137;Integrated Security=True";

        public DataTable LayDuLieu(string sql)
        {
            SqlConnection ket_noi = new SqlConnection(duong_dan);

            SqlDataAdapter bo_du_lieu = new SqlDataAdapter(sql, ket_noi);

            DataTable bang = new DataTable();
            bo_du_lieu.Fill(bang);

            return bang;
        }

        public int ThucThi(string sql)
        {
            SqlConnection ket_noi = new SqlConnection(duong_dan);

            SqlCommand lenh = new SqlCommand(sql, ket_noi);
            ket_noi.Open();

            var kq = lenh.ExecuteNonQuery();

            ket_noi.Close();
            return kq;
        }
        public int TimMaSo(String tenBang, String tenCot)
        {
            int maso;
            string strSQL = String.Format("Select Max({0}) as ma from {1}  ", tenCot, tenBang);
            DataTable dt = LayDuLieu(strSQL);
            maso = int.Parse(dt.Rows[0][tenCot].ToString());

            return maso;
        }


    }
}
