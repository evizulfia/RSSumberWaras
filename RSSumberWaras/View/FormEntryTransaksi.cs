﻿using Newtonsoft.Json.Linq;
using RestSharp;
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
        private readonly string pasienId;

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
        /*
        public FormEntryTransaksi(string title, Transaksi obj, TransaksiController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;

            isNewData = false; // set status edit data
            trans = obj; // set objek pas yang akan diedit


            // untuk edit data, tampilkan data lama
            //idTransaksiBox.Text = trans.IdTransaction.ToString();
            //idDokterBox.Text = trans.IdDokter.ToString();
            idPasienBox.Text = trans.IdPasien.ToString();
            //namaPasienBox.Text = trans.namaPasien;
            //invoiceBox.Text = trans.invoice;
            tglTransaksiPicker.Format = DateTimePickerFormat.Short;
            //hargaBox.Text = trans.harga.ToString();
            totalBox.Text = trans.total.ToString();
            //StatusBox.Text = trans.status;
        }*/

      

        private void entryTransaksiSimpanBtn_Click(object sender, EventArgs e)
        {
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/transaction-store";

            //int result = 0;

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.POST);


           // request.AddParameter("id_transaction", idPasienBox.Text.ToString());
            request.AddParameter("id_pasien", idPasienBox.Text.ToString());
            //request.AddParameter("id_dokter", idDokterBox.Text.ToString());
            //request.AddParameter("nama_pasien", namaPasienBox.Text);
            //request.AddParameter("invoice", invoiceBox.Text);
            request.AddParameter("tanggal_transaksi", tglTransaksiPicker.Value.Date.ToString("yyyy-MM-dd"));
            //request.AddParameter("harga", hargaBox.Text.ToString());
            request.AddParameter("total", totalBox.Text.ToString());
            //request.AddParameter("status", StatusBox.Text);

            var response = client.Execute(request);

            dynamic resp = JObject.Parse(response.Content);

            if (resp.status == "200")
            {
                string message = resp.message;
                string title = "Proses berhasil";
                MessageBox.Show(message, title);
                this.Hide();
                FormTransaksi form = new FormTransaksi();
                form.Show();
            }
            else
            {
                string message = resp.message;
                string title = "process Failed";
                MessageBox.Show(message, title);
            }
        }

        private void SelesaiEntryTransBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTransaksi form = new FormTransaksi();
            form.Show();
        }

        
      
    }
}