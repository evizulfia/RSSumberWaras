using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using RSSumberWaras.Model.Entity;
using RSSumberWaras.Model.Context;
 
namespace RSSumberWaras.Model.Repository
{
    public class DokterRepository
    {
        // deklarsi objek connection
        private MySqlConnection _conn;

        // constructor
        public DokterRepository(DbContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }

        public int Create(Dokter dok)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into dokter (id_dokter, nama_dokter, spesialisasi, no_telepon)
                           values (@id_dokter, @nama_dokter, @spesialisasi, @no_telepon)";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_dokter", dok.IdDokter);
                cmd.Parameters.AddWithValue("@nama_dokter", dok.NamaDokter);
                cmd.Parameters.AddWithValue("@spesialisasi", dok.Spesialisasi);
                cmd.Parameters.AddWithValue("@no_telepon", dok.NoHP);

                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Update(Dokter dok)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update mahasiswa set nama_dokter = @nama_dokter, spesialisasi = @spesialisasi, no_telepon = @no_telepon
                           where id_dokter = @id_dokter";
            
            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_dokter", dok.IdDokter);
                cmd.Parameters.AddWithValue("@nama_dokter", dok.NamaDokter);
                cmd.Parameters.AddWithValue("@spesialisasi", dok.Spesialisasi);
                cmd.Parameters.AddWithValue("@no_telepon", dok.NoHP);

                try
                {
                    // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Delete(Dokter dok)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from dokter
                           where id_dokter = @id_dokter";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@id_dokter", dok.IdDokter);

                try
                {
                    // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<Dokter> ReadAll()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Dokter> list = new List<Dokter>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select id_dokter, nama_dokter, Spesialisasi, no_telepon 
                               from dokter 
                               order by nama";

                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Dokter dok = new Dokter();
                            dok.IdDokter = (int)dtr["id_dokter"];
                            dok.NamaDokter = dtr["nama_dokter"].ToString();
                            dok.Spesialisasi = dtr["spesialisasi"].ToString();
                            dok.NoHP = dtr["no_telepon"].ToString();


                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(dok);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

        // Method untuk menampilkan data mahasiwa berdasarkan pencarian nama
        public List<Dokter> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Dokter> list = new List<Dokter>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select npm, nama, angkatan 
                               from mahasiswa 
                               where nama like @nama
                               order by nama";

                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@nama", string.Format("%{0}%", nama));

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Dokter dok = new Dokter();
                            dok.IdDokter = (int)dtr["id_dokter"];
                            dok.NamaDokter = dtr["nama_dokter"].ToString();
                            dok.Spesialisasi = dtr["spesialisasi"].ToString();
                            dok.NoHP = dtr["no_telepon"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(dok);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return list;
        }
    }
}
