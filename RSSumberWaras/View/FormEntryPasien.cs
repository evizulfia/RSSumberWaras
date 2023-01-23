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
    public partial class FormEntryPasien : Form
    {
       

        public delegate void CreateUpdateEventHandler(Pasien pas);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private PasienController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek mahasiswa
        private Pasien pas;

        public FormEntryPasien()
        {
            InitializeComponent();
        }

        // constructor untuk inisialisasi data ketika entri data baru
        public FormEntryPasien(string title, PasienController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }

        public FormEntryPasien(string title, Pasien obj, PasienController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;

            isNewData = false; // set status edit data
            pas = obj; // set objek pas yang akan diedit

            // untuk edit data, tampilkan data lama
            idPasienBox.Text = pas.IdPasien.ToString();
            namaPasienBox.Text = pas.NamaPasien;
            alamatPasienBox.Text = pas.Alamat;
            tglLahirPasien.Text = pas.TglLahir.ToString();
            genderPasienDropDown.Text = pas.JenisKelamin;
            noHpPasienBox.Text = pas.NoTelepon;
        }


        private void EntryFormPasienSelesaiBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPasien form = new FormPasien();
            form.Show();
            
        }

        private void pasienSimpanBtn_Click(object sender, EventArgs e)
        {
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/dokter-store";

            //int result = 0;

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.POST);


            request.AddParameter("id_pasienr", idPasienBox.Text);
            request.AddParameter("nama_pasien", namaPasienBox.Text);
            request.AddParameter("alamat", alamatPasienBox.Text);
            request.AddParameter("tanggal_lahir", tglLahirPasien.Text);
            request.AddParameter("jenis_kelamin", genderPasienDropDown.Text);
            request.AddParameter("no_telepon", noHpPasienBox.Text);

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
                FormPasien form = new FormPasien();
                form.Show();
            }
            else
            {
                string message = resp.message;
                string title = "process Failed";
                MessageBox.Show(message, title);
            }
        }
    }
}
