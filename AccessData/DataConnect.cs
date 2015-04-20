using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AccessData
{
    public class DataConnect
    {
        public SqlConnection getConnect()
        {
           // return new SqlConnection(@"Data Source=.;Initial Catalog=DeMoQLSV;Integrated Security=True");
            return new SqlConnection(@"Data Source=.;Initial Catalog=DeMoQLSV;Persist Security Info=True;User ID=sa;Password=123456");

        }

        // thuc hien cau lenh tra ve 1 bang . vd nhu lay thong tin 1 bang len
        public DataTable GetTable(string sql)
        {

            SqlConnection con = getConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
           
         
            return dt;
        }
        public int ExcuteNonQuery1(string sql)
        {

            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return 0;
        }
        // thuc hien cau lenh inser , update , delete k tra ve bang
        public void ExcuteNonQuery(string sql)
        {
           
                SqlConnection con = getConnect();
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
          

        }

        // thuc hien cau lenh doc kiem tra dl voi phuong thuc DataReader so sanh voi doi tuong nhap vao
        public bool CheckRead(string sql)
        {
            bool result = false;
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand command = new SqlCommand(sql,con );
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == true)
                result = true;
            else
                result = false;
            con.Close();
            return result;
        }
            
    }
}
