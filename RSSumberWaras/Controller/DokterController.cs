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
        private DokterRepository _repository;

        /// <summary>
        /// Method untuk menampilkan data Dokter berdasarkan nama
        /// </summary>
        /// <param name="nama"></param>
        /// <returns></returns>
        public List<Dokter> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Dokter> list = new List<Dokter>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new DokterRepository(context);

                // panggil method ReadByNama yang ada di dalam class repository
                list = _repository.ReadByNama(nama);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan semua data Dokter
        /// </summary>
        /// <returns></returns>
        public List<Dokter> ReadAll()
        {
            // membuat objek collection
            List<Dokter> list = new List<Dokter>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new DokterRepository(context);

                // panggil method ReadAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }

            return list;
        }

        public int Create(Dokter dok)
        {
            int result = 0;

            // cek ID Dokter yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(dok.IdDokter.ToString()))
            {
                MessageBox.Show("ID Dokter harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(dok.NamaDokter))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek spesialisasi yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(dok.Spesialisasi))
            {
                MessageBox.Show("Spesialisasi harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(dok.NoHP))
            {
                MessageBox.Show("No. HP harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new DokterRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(dok);
            }

            if (result > 0)
            {
                MessageBox.Show("Data dokter berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data dokter gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Dokter dok)
        {
            int result = 0;

            // cek ID Dokter yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(dok.IdDokter.ToString()))
            {
                MessageBox.Show("ID Dokter harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(dok.NamaDokter))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek Spesialisasi yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(dok.Spesialisasi))
            {
                MessageBox.Show("Spesialisasi harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(dok.NoHP))
            {
                MessageBox.Show("No. HP harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new DokterRepository(context);

                // panggil method Update class repository untuk mengupdate data
                result = _repository.Update(dok);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Dokter berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Dokter gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Dokter dok)
        {
            int result = 0;

            // cek nilai ID Dokter yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(dok.IdDokter.ToString()))
            {
                MessageBox.Show("ID Dokter harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new DokterRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.Delete(dok);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Dokter berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Dokter gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
