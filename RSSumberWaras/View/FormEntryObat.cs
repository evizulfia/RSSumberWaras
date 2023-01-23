using Newtonsoft.Json.Linq;
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
    public partial class FormEntryObat : Form
    {
        public delegate void CreateUpdateEventHandler(Obat obt);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private ObatController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek mahasiswa
        private Obat obt;
        public FormEntryObat()
        {
            InitializeComponent();
        }

        public FormEntryObat(string title, ObatController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }

        public FormEntryObat(string title, Obat obj, ObatController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;

            isNewData = false; // set status edit data
            obt = obj; // set objek mhs yang akan diedit

            // untuk edit data, tampilkan data lama
            idObatBox.Text = obt.IdObat.ToString();
            namaObatBox.Text = obt.NamaObat;
            hargaObatBox.Text = obt.Harga.ToString();
            satuanObatBox.Text = obt.Satuan;
        }

        private void obatSimpanBtn_Click(object sender, EventArgs e)
        {
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/dokter-store";

            int result = 0;

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.POST);


            request.AddParameter("id_dokter", idObatBox.Text);
            request.AddParameter("nama_dokter", namaObatBox.Text);
            request.AddParameter("spesialisasi", hargaObatBox.Text);
            request.AddParameter("no_telepon", satuanObatBox.Text);

            var response = client.Execute(request);

            Console.WriteLine(response.Content);
            Console.WriteLine(response.Content);

            dynamic resp = JObject.Parse(response.Content);

            if (resp.status == "200")
            {



                string message = resp.message;
                string title = "Proses berhasil";
                MessageBox.Show(message, title);
                this.Hide();
                FormObat formObt = new FormObat();
                formObt.Show();

            }
            else
            {
                string message = resp.message;
                string title = "process Failed";
                MessageBox.Show(message, title);
            }

        }

        private void EntryFormObatSelesaiBtn_Click(object sender, EventArgs e)
        {
            FormObat form = new FormObat();
            form.ShowDialog();
            this.Close();

        }
    }
}
