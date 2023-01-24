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

        private TransaksiController transaksiObatController = new TransaksiController();



        public FormLaporanTransaksi()
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
            listViewLaporan.View = System.Windows.Forms.View.Details;
            listViewLaporan.FullRowSelect = true;
            listViewLaporan.GridLines = true;
            //listViewObat.Columns.Add("No Urut", 50, HorizontalAlignment.Center);
            listViewLaporan.Columns.Add("ID Transaksi", 40, HorizontalAlignment.Center);
            listViewLaporan.Columns.Add("ID Pasien", 250, HorizontalAlignment.Center);
            listViewLaporan.Columns.Add("Nama Pasien", 150, HorizontalAlignment.Left);
            listViewLaporan.Columns.Add("Invoice", 150, HorizontalAlignment.Center);
            listViewLaporan.Columns.Add("Tanggal Transaksi", 150, HorizontalAlignment.Center);
            listViewLaporan.Columns.Add("Harga", 150, HorizontalAlignment.Center);
            listViewLaporan.Columns.Add("Diskon", 150, HorizontalAlignment.Center);
            listViewLaporan.Columns.Add("Total", 150, HorizontalAlignment.Center);
            listViewLaporan.Columns.Add("Status", 150, HorizontalAlignment.Center);

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
                //var noUrut = listViewObat.Items.Count + 1;
                var item = new ListViewItem(trans.IdTransaksi.toString());
                item.SubItems.Add(obt.NamaObat);
                item.SubItems.Add(obt.Harga.ToString());
                item.SubItems.Add(obt.Satuan);

                // tampilkan data dok ke listview
                listViewLaporan.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(Obat obt)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            listOfObat.Add(obt);

            int noUrut = listViewObat.Items.Count + 1;

            // tampilkan data mhs yg baru ke list view
            var item = new ListViewItem(obt.IdObat.ToString());
            item.SubItems.Add(obt.NamaObat);
            item.SubItems.Add(obt.Harga.ToString());
            item.SubItems.Add(obt.Satuan);

            // tampilkan data dok ke listview
            listViewObat.Items.Add(item);

        }

        private void OnUpdateEventHandler(Obat obt)
        {
            // ambil index data mhs yang edit
            int index = listViewObat.SelectedIndices[0];

            // update informasi mhs di listview
            ListViewItem itemRow = listViewObat.Items[index];
            itemRow.SubItems[1].Text = obt.IdObat.ToString();
            itemRow.SubItems[2].Text = obt.NamaObat;
            itemRow.SubItems[3].Text = obt.Harga.ToString();

        }

        private void selesaiLaporanBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm form = new MenuForm();
            form.ShowDialog();
            
        }
    }
}
