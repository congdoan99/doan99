using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLBanHang.Object;

namespace QL_BanHang.Model
{
    class NhanVienMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select MaNV, TenNV, GioiTinh, NamSinh, DiaChi, SDT  from tb_NhanVien";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        public bool AddData(NhanVienObj nvObj)
        {
            cmd.CommandText = "Insert into tb_NhanVien values ('" + nvObj.Ma + "',N'" + nvObj.Ten + "',N'" + nvObj.Gioitinh + "',CONVERT(DATE,'" + nvObj.Namsinh + "',103),N'" + nvObj.Diachi + "','" + nvObj.Sdt + "','" + nvObj.Matkhau + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool UpdData(NhanVienObj nvObj)
        {
            cmd.CommandText = "Update tb_NhanVien set TenNV =  N'" + nvObj.Ten + "', GioiTinh = N'" + nvObj.Gioitinh + "', NamSinh = CONVERT(DATE,'" + nvObj.Namsinh + "',103), DiaChi = N'" + nvObj.Diachi + "',SDT = '" + nvObj.Sdt + "' Where MaNV = '" + nvObj.Ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool UpdMK(NhanVienObj nvObj)
        {
            cmd.CommandText = "Update tb_NhanVien set MatKhau ='" + nvObj.Matkhau + "' Where MaNV = '" + nvObj.Ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool DelData(string ma)
        {
            cmd.CommandText = "Delete tb_NhanVien Where MaNV = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
    }
}
