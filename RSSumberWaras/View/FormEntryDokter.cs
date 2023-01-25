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
using RestSharp;
using Newtonsoft.Json.Linq;


namespace RSSumberWaras.View
{
    public partial class FormEntryDokter : Form
    {
        public delegate void CreateUpdateEventHandler(Dokter dok);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private DokterController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek mahasiswa
        private Dokter dok;


        // constructor untuk inisialisasi data ketika entri data baru
        public FormEntryDokter(string title, DokterController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }

        public FormEntryDokter()
        {
            InitializeComponent();
        }

        public FormEntryDokter(string title, Dokter obj, DokterController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;

            isNewData = false; // set status edit data
            dok = obj; // set objek dok yang akan diedit

            // untuk edit data, tampilkan data lama
            idDokterBox.Text = dok.IdDokter.ToString();
            namaDokterBox.Text = dok.NamaDokter;
            spesialisasiBox.Text = dok.Spesialisasi;
            noHpDokBox.Text = dok.NoTelepon;
        }

        private void doktSimpanBtn_Click(object sender, EventArgs e)
        {

            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/dokter-store";

            //int result = 0;

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.POST);


            request.AddParameter("id_dokter", idDokterBox.Text);
            request.AddParameter("nama_dokter", namaDokterBox.Text);
            request.AddParameter("spesialisasi", spesialisasiBox.Text);
            request.AddParameter("no_telepon", noHpDokBox.Text);

            var response = client.Execute(request);

            dynamic resp = JObject.Parse(response.Content);

            if (resp.status == "200")
            {

                string message = resp.message;
                string title = "Proses berhasil";
                MessageBox.Show(message, title);
                this.Close();
                

            }
            else
            {
                string message = resp.message;
                string title = "process Failed";
                MessageBox.Show(message, title);
            }
            this.Hide();
            FormDokter formDokter = new FormDokter();
            formDokter.ShowDialog();

        }

        private void EntryFormDokterSelesaiBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDokter formDokter = new FormDokter();
            formDokter.ShowDialog();
            
        }
    }
    
}
