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
    public partial class FormTransaksi : Form
    {

        private List<Transaksi> listOfTransaksi = new List<Transaksi>();

        //deklarasi objek controller
        private TransaksiController controller;

        private TransaksiController transaksiController = new TransaksiController();


        public FormTransaksi()
        {
            InitializeComponent();
            //membuat objek controller
            controller = new TransaksiController();
            InisialisasiListView();

            // fungsi untuk load table obtter
            LoadDataTransaksi();
        }

        private void InisialisasiListView()
        {
            listViewTransaksi.View = System.Windows.Forms.View.Details;
            listViewTransaksi.FullRowSelect = true;
            listViewTransaksi.GridLines = true;

            listViewTransaksi.Columns.Add("ID Transaksi", 100, HorizontalAlignment.Center);
            listViewTransaksi.Columns.Add("ID Pasien", 150, HorizontalAlignment.Center);
            listViewTransaksi.Columns.Add("ID Obat", 150, HorizontalAlignment.Center);
            listViewTransaksi.Columns.Add("Nama Obat", 100, HorizontalAlignment.Center);
            listViewTransaksi.Columns.Add("Nama Pasien", 150, HorizontalAlignment.Left);
            //listViewTransaksi.Columns.Add("ID Dokter Yang Memeriksa", 100, HorizontalAlignment.Center);
            //listViewTransaksi.Columns.Add("Nama Dokter", 150, HorizontalAlignment.Left);
            listViewTransaksi.Columns.Add("Invoice", 150, HorizontalAlignment.Center);
            listViewTransaksi.Columns.Add("Tanggal Transaksi", 150, HorizontalAlignment.Left);
            listViewTransaksi.Columns.Add("Jumlah", 150, HorizontalAlignment.Center);
            listViewTransaksi.Columns.Add("Harga", 150, HorizontalAlignment.Center);
            listViewTransaksi.Columns.Add("Total", 150, HorizontalAlignment.Center);
            listViewTransaksi.Columns.Add("Status", 150, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataTransaksi()
        {
            // kosongkan listview
            listViewTransaksi.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfTransaksi = controller.ReadAll();
            // ekstrak objek obt dari collection
            foreach (var trans in listOfTransaksi)
            {
                var item = new ListViewItem(trans.IdTransaction.ToString());
                item.SubItems.Add(trans.IdPasien.ToString());
                item.SubItems.Add(trans.IdObat.ToString());
                item.SubItems.Add(trans.namaObat);
                item.SubItems.Add(trans.namaPasien);
                //item.SubItems.Add(trans.IdDokter.ToString());
                item.SubItems.Add(trans.invoice);
                item.SubItems.Add(trans.tanggalTransaksi.ToShortDateString());
                item.SubItems.Add(trans.qty.ToString());
                item.SubItems.Add(trans.harga.ToString());
                item.SubItems.Add(trans.total.ToString());
                item.SubItems.Add(trans.status);

                // tampilkan data dok ke listview
                listViewTransaksi.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(Transaksi trans)
        {
            // tambahkan objek trans yang baru ke dalam collection
            listOfTransaksi.Add(trans);

            var item = new ListViewItem(trans.IdTransaction.ToString());
            item.SubItems.Add(trans.IdPasien.ToString());
            item.SubItems.Add(trans.IdObat.ToString());
            item.SubItems.Add(trans.namaObat);
            item.SubItems.Add(trans.namaPasien);
            //item.SubItems.Add(trans.IdDokter.ToString());
            item.SubItems.Add(trans.invoice);
            item.SubItems.Add(trans.tanggalTransaksi.ToShortDateString());
            item.SubItems.Add(trans.qty.ToString());
            item.SubItems.Add(trans.harga.ToString());
            item.SubItems.Add(trans.total.ToString());
            item.SubItems.Add(trans.status);

            // tampilkan data trans ke listview
            listViewTransaksi.Items.Add(item);
        }

        private void tmbhTransaksiBtn_Click(object sender, EventArgs e)
        {
            FormEntryTransaksi formEntry = new FormEntryTransaksi("Tambah Data Transaksi", controller);
            formEntry.OnCreate += OnCreateEventHandler;
            formEntry.ShowDialog();
            this.Hide();
        }

        private void selesaiTransaksiBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm form = new MenuForm();
            form.ShowDialog();
            
        }
        private void maximise(object sender, EventArgs e)
        {

            //normalises window
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
            }

            //maximises window
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.CenterToScreen();
            }
        }

        private void cariTransaksiBtn_Click(object sender, EventArgs e)
        {
            listViewTransaksi.Items.Clear();
            List<Transaksi> listOfTransaksi = new List<Transaksi>();

            if (cariTransaksiBox.Text == "")
            {
                listOfTransaksi = transaksiController.ReadAll();
            }
            else
            {
                listOfTransaksi = transaksiController.Search(cariTransaksiBox.Text);
            }

            foreach (var trans in listOfTransaksi)
            {
                var item = new ListViewItem(trans.IdTransaction.ToString());
                item.SubItems.Add(trans.IdPasien.ToString());
                item.SubItems.Add(trans.IdObat.ToString());
                item.SubItems.Add(trans.namaObat);
                item.SubItems.Add(trans.namaPasien);
                //item.SubItems.Add(trans.IdDokter.ToString());
                item.SubItems.Add(trans.invoice);
                item.SubItems.Add(trans.tanggalTransaksi.ToShortDateString());
                item.SubItems.Add(trans.qty.ToString());
                item.SubItems.Add(trans.harga.ToString());
                item.SubItems.Add(trans.total.ToString());
                item.SubItems.Add(trans.status);

                // tampilkan data dok ke listview
                listViewTransaksi.Items.Add(item);
            }
        }
    }
}
