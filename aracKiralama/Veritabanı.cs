using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aracKiralama
{

  
    internal class Veritabanı
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataAdapter da;
        static SqlDataReader dr;
        static DataSet ds;
        public static string sqlcon = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=202523011-VTDGP;Integrated Security=True";
        public static string selectSorgu = "select * from ";
        public static string kullanicimSession = "";

        public static bool BaglantiDurum()
        {
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch (SqlException ex)
                {
                    return false;
                }
            }
        }
        public static bool LoginKontrol(string kullanici, string sifre)
        {
            string sorgu = selectSorgu + "tbl_login where userName=@user and password=@pass";
            con = new SqlConnection(sqlcon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", kullanici);
            cmd.Parameters.AddWithValue("@pass", sifre);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read()) { con.Close(); return true; }
            else { con.Close(); return false; }

        }
        public static void kullaniciEkle(string kullanici, string sifre)
        {
            con = new SqlConnection(sqlcon);
            string sql = "insert into tbl_login(userName,password) values(@user,@pass)";
            cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@user", kullanici);
            cmd.Parameters.AddWithValue("@pass", sifre);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
