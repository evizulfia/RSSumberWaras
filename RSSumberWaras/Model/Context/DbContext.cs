﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace RSSumberWaras.Model.Context
{
    public class DbContext : IDisposable
    {
        // deklarasi private variabel / field
        private MySqlConnection _conn;
        // deklarasi property Conn (connection), untuk menyimpan objek koneksi
        public MySqlConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }
        // Method untuk melakukan koneksi ke database
        private MySqlConnection GetOpenConnection()
        {
            MySqlConnection conn = null; // deklarasi objek connection
            try // penggunaan blok try-catch untuk penanganan error
            {
                // atur ulang lokasi database yang disesuaikan dengan
                // lokasi database perpustakaan Anda
                string dbName = @"D:\Database\DbPerpustakaan.db";
            // deklarasi variabel connectionString, ref:
            //https://www.connectionstrings.com/
                string connectionString = string.Format("Data Source ={ 0}; FailIfMissing = True", dbName);
            conn = new MySqlConnection(connectionString); // buat objek connection
            conn.Open(); // buka koneksi ke database
            }
            // jika terjadi error di blok try, akan ditangani langsung oleh blok catch
        catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}",
                ex.Message);
            }
            return conn;
        }
        // Method ini digunakan untuk menghapus objek koneksi dari memory ketika sudah tidak digunakan
        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }
            GC.SuppressFinalize(this);
        }
    }

}

