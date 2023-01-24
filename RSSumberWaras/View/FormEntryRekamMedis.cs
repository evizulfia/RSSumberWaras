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
    public partial class FormEntryRekamMedis : Form
    {
        public delegate void CreateUpdateEventHandler(RekamMedis rm);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private RekamMedisController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek mahasiswa
        private RekamMedis rm;
        public FormEntryRekamMedis()
        {
            InitializeComponent();
        }

        public FormEntryRekamMedis(string title, RekamMedisController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }

        public FormEntryRekamMedis(string title, RekamMedis obj, RekamMedisController controller)
           : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;

            isNewData = false; // set status edit data
            rm = obj; // set objek pas yang akan diedit

            // untuk edit data, tampilkan data lama
            idRekamMedisBox.Text = obj.IdRekamMedis.ToString();
            idPasienBox.Text = obj.IdPasien.ToString();
            idDokterBox.Text = obj.IdDokter.ToString();
            // tglLahirPasienPicker.Value.Date = pas.TglLahir;
            tglPeriksaRekamMedisPicker.Format = DateTimePickerFormat.Short;
            diagnosaBox.Text = obj.Diagnosa;
            tindakanBox.Text = obj.Tindakan;
        }

        private void EntryFormObatSelesaiBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormRekamMedis form = new FormRekamMedis();
            form.ShowDialog();
            
        }

        private void rekamMedisSimpanBtn_Click(object sender, EventArgs e)
        {
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/rekammedis-store";

            //int result = 0;

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.POST);

            request.AddParameter("id_rekam_medis", idRekamMedisBox.Text.ToString());
            request.AddParameter("id_pasien", idPasienBox.Text);
            request.AddParameter("id_dokter", idDokterBox.Text);
            request.AddParameter("tanggal_periksa", tglPeriksaRekamMedisPicker.Value.Date.ToString("yyyy-MM-dd"));
            request.AddParameter("diagnosa", diagnosaBox.Text);
            request.AddParameter("tindakan", tindakanBox.Text);

            var response = client.Execute(request);

            dynamic resp = JObject.Parse(response.Content);

            if (resp.status == "200")
            {
                string message = resp.message;
                string title = "Proses berhasil";
                MessageBox.Show(message, title);
                this.Hide();
                FormRekamMedis form = new FormRekamMedis();
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
