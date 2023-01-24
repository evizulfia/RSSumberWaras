using RSSumberWaras.Controller;
using RSSumberWaras.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSumberWaras.View
{
    public partial class FormEntryTransaksi : Form
    {
        public delegate void CreateUpdateEventHandler(Transaksi trans);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private TransaksiController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek mahasiswa
        private Transaksi trans;

        public FormEntryTransaksi()
        {
            InitializeComponent();
        }

        // constructor untuk inisialisasi data ketika entri data baru
        public FormEntryTransaksi(string title, TransaksiController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }

        public FormEntryTransaksi(string title, Transaksi obj, TransaksiController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;

            isNewData = false; // set status edit data
            trans = obj; // set objek pas yang akan diedit

            // untuk edit data, tampilkan data lama
            idTransaksiBox.Text = 
            namaPasienBox.Text = pas.NamaPasien;
            alamatPasienBox.Text = pas.Alamat;
            tglLahirPasienPicker.Format = DateTimePickerFormat.Short;
            genderPasienDropDown.Text = pas.JenisKelamin;
            noHpPasienBox.Text = pas.NoTelepon;
        }

      

        private void entryTransaksiSimpanBtn_Click(object sender, EventArgs e)
        {

        }

        private void SelesaiEntryTransBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
