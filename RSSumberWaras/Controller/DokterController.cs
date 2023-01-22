using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RSSumberWaras.Model.Entity;
using RSSumberWaras.Model.Repository;
using RSSumberWaras.Model.Context;
using System.Windows.Forms;

namespace RSSumberWaras.Controller
{
    public class DokterController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private DokterRestApiRepository _repository;

        /// <summary>
        /// Method untuk menampilkan semua data Dokter
        /// </summary>
        /// <returns></returns>
        public List<Dokter> ReadAll()
        {
            // membuat objek collection
            List<Dokter> list = new List<Dokter>();
            var repo = new DokterRestApiRepository();
            list = repo.ReadAll();
            return list;
        }

       // public List<Dokter> Read()
       // {
       //     // membuat objek collection
       //     List<Dokter> list = new List<Dokter>();
       //     var repo = new DokterRestApiRepository();
       //     list = repo.Read();
       //     return list;
       // }

       // public int Create(Dokter dok)
       // {
       //     int result = 0;

       //     // cek ID Dokter yang diinputkan tidak boleh kosong
       //     if (string.IsNullOrEmpty(dok.IdDokter.ToString()))
       //     {
       //         MessageBox.Show("ID Dokter harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
       //         return 0;
       //     }

       //     // cek nama yang diinputkan tidak boleh kosong
       //     if (string.IsNullOrEmpty(dok.NamaDokter))
       //     {
       //         MessageBox.Show("Nama harus diisi !!!", "Peringatan",
       //                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
       //         return 0;
       //     }

       //     // cek spesialisasi yang diinputkan tidak boleh kosong
       //     if (string.IsNullOrEmpty(dok.Spesialisasi))
       //     {
       //         MessageBox.Show("Spesialisasi harus diisi !!!", "Peringatan",
       //                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
       //         return 0;
       //     }

       //     if (string.IsNullOrEmpty(dok.NoTelepon))
       //     {
       //         MessageBox.Show("No. HP harus diisi !!!", "Peringatan",
       //                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
       //         return 0;
       //     }

       //     var _repository = new DokterRestApiRepository();

       //     // panggil method Update class repository untuk mengupdate data
       //     result = _repository.Create(dok);
       //// }
            

       //     if (result > 0)
       //     {
       //         MessageBox.Show("Data dokter berhasil disimpan !", "Informasi",
       //                 MessageBoxButtons.OK, MessageBoxIcon.Information);
       //     }
       //     else
       //         MessageBox.Show("Data dokter gagal disimpan !!!", "Peringatan",
       //                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

       //     return result;
       // }

       // public int Update(Dokter dok)
       // {
       //     int result = 0;

       //     // cek ID Dokter yang diinputkan tidak boleh kosong
       //     if (string.IsNullOrEmpty(dok.IdDokter.ToString()))
       //     {
       //         MessageBox.Show("ID Dokter harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
       //         return 0;
       //     }

       //     // cek nama yang diinputkan tidak boleh kosong
       //     if (string.IsNullOrEmpty(dok.NamaDokter))
       //     {
       //         MessageBox.Show("Nama harus diisi !!!", "Peringatan",
       //                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
       //         return 0;
       //     }

       //     // cek spesialisasi yang diinputkan tidak boleh kosong
       //     if (string.IsNullOrEmpty(dok.Spesialisasi))
       //     {
       //         MessageBox.Show("Spesialisasi harus diisi !!!", "Peringatan",
       //                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
       //         return 0;
       //     }

       //     if (string.IsNullOrEmpty(dok.NoTelepon))
       //     {
       //         MessageBox.Show("No. HP harus diisi !!!", "Peringatan",
       //                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
       //         return 0;
       //     }

       //     var _repository = new DokterRestApiRepository();

       //     // panggil method Update class repository untuk mengupdate data
       //     result = _repository.Update(dok);
       //     // }


       //     if (result > 0)
       //     {
       //         MessageBox.Show("Data dokter berhasil diupdate !", "Informasi",
       //                 MessageBoxButtons.OK, MessageBoxIcon.Information);
       //     }
       //     else
       //         MessageBox.Show("Data dokter gagal diupdate !!!", "Peringatan",
       //                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

       //     return result;
       // }

       // public int Delete(Dokter dok)
       // {
       //     int result = 0;

       //     // cek nilai ID Dokter yang diinputkan tidak boleh kosong
       //     if (string.IsNullOrEmpty(dok.IdDokter.ToString()))
       //     {
       //         MessageBox.Show("ID Dokter harus diisi !!!", "Peringatan",
       //                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
       //         return 0;
       //     }

          
           
       //         // membuat objek dari class repository
       //         _repository = new DokterRestApiRepository();

       //         // panggil method Delete class repository untuk menghapus data
       //         result = _repository.Delete(dok);
            

       //     if (result > 0)
       //     {
       //         MessageBox.Show("Data Dokter berhasil dihapus !", "Informasi",
       //                 MessageBoxButtons.OK, MessageBoxIcon.Information);
       //     }
       //     else
       //         MessageBox.Show("Data Dokter gagal dihapus !!!", "Peringatan",
       //                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

       //     return result;
       // }
    }
}
