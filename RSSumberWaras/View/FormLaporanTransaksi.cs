﻿using RSSumberWaras.Controller;
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
    public partial class FormLaporanTransaksi : Form
    {
        private List<Transaksi> listOfTransaksi = new List<Transaksi>();

        //deklarasi objek controller
        private TransaksiController controller;

        private TransaksiController transaksiController = new TransaksiController();



        public FormLaporanTransaksi()
        {
            InitializeComponent();
            //membuat objek controller
            controller = new TransaksiController();
            InisialisasiListView();
            LoadDataTransaksi();
            filterDropdown.SelectedIndex = 0;
        }

        private void InisialisasiListView()
        {
            listViewLaporan.View = System.Windows.Forms.View.Details;
            listViewLaporan.FullRowSelect = true;
            listViewLaporan.GridLines = true;
            //listViewObat.Columns.Add("No Urut", 50, HorizontalAlignment.Center);
            listViewLaporan.Columns.Add("ID Transaksi", 40, HorizontalAlignment.Center);
            listViewLaporan.Columns.Add("ID Pasien", 250, HorizontalAlignment.Center);
            listViewLaporan.Columns.Add("Nama Pasien", 150, HorizontalAlignment.Left);
            listViewLaporan.Columns.Add("Invoice", 150, HorizontalAlignment.Center);
            listViewLaporan.Columns.Add("Tanggal Transaksi", 150, HorizontalAlignment.Center);
            //listViewLaporan.Columns.Add("Harga", 150, HorizontalAlignment.Center);
            //listViewLaporan.Columns.Add("Diskon", 150, HorizontalAlignment.Center);
            listViewLaporan.Columns.Add("Total", 150, HorizontalAlignment.Center);
            //listViewLaporan.Columns.Add("Status", 150, HorizontalAlignment.Center);

        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataTransaksi()
        {
            // kosongkan listview
            listViewLaporan.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfTransaksi = controller.ReadAll();
            // ekstrak objek obt dari collection
            foreach (var trans in listOfTransaksi)
            {
                var item = new ListViewItem(trans.IdTransaction.ToString());
                item.SubItems.Add(trans.IdPasien.ToString());
                item.SubItems.Add(trans.namaPasien);
                item.SubItems.Add(trans.invoice);
                item.SubItems.Add(trans.tanggalTransaksi.ToShortDateString());
                //item.SubItems.Add(trans.harga.ToString());
                item.SubItems.Add(trans.total.ToString());
                //item.SubItems.Add(trans.status);

                // tampilkan data dok ke listview
                listViewLaporan.Items.Add(item);
            }
        }
       
        private void selesaiLaporanBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm form = new MenuForm();
            form.ShowDialog();
        }

        private void cariLaporanBtn_Click(object sender, EventArgs e)
        {
            listViewLaporan.Items.Clear();
            List<Transaksi> listOfTransaksi = new List<Transaksi>();

            switch (filterDropdown.SelectedIndex)
            {
                case 0:
                    listOfTransaksi = transaksiController.ReadAll();
                    break;
                case 1:
                    listOfTransaksi.Add(transaksiController.SearchById(laporanCariBox.Text));
                    //listOfTransaksi = transaksiController.Search(laporanCariBox.Text);
                    break;
                //case 2:
                //    listOfProduct = productController.ReadByProductName(txtKeyword.Text);
                //    break;
                
            }

            foreach (var trans in listOfTransaksi)
            {
                var item = new ListViewItem(trans.IdTransaction.ToString());
                item.SubItems.Add(trans.IdPasien.ToString());
                item.SubItems.Add(trans.namaPasien);
                item.SubItems.Add(trans.invoice);
                item.SubItems.Add(trans.tanggalTransaksi.ToShortDateString());
                //item.SubItems.Add(trans.harga.ToString());
                item.SubItems.Add(trans.total.ToString());
                //item.SubItems.Add(trans.status);

                // tampilkan data dok ke listview
                listViewLaporan.Items.Add(item);
            }
        }
    }
}
