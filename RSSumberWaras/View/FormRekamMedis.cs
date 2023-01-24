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
    public partial class FormRekamMedis : Form
    {
        //deklarasi objek colection untuk menamoung objek mahasiswa
        private List<RekamMedis> listOfRekamMedis = new List<RekamMedis>();

        //deklarasi objek controller
        private RekamMedisController controller;

        private RekamMedisController rekamMedisController = new RekamMedisController();

        public FormRekamMedis()
        {
            InitializeComponent();

            //membuat objek controller
            controller = new RekamMedisController();
            InisialisasiListView();

            // fungsi untuk load table dokter
            LoadDataRekamMedis();
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            listViewRekamMedis.View = System.Windows.Forms.View.Details;
            listViewRekamMedis.FullRowSelect = true;
            listViewRekamMedis.GridLines = true;

            listViewRekamMedis.Columns.Add("ID Rekam Medis", 100, HorizontalAlignment.Center);
            listViewRekamMedis.Columns.Add("ID Pasien ", 600, HorizontalAlignment.Center);
            listViewRekamMedis.Columns.Add("ID Dokter", 300, HorizontalAlignment.Center);
            listViewRekamMedis.Columns.Add("Tanggal Periksa", 300, HorizontalAlignment.Center);
            listViewRekamMedis.Columns.Add("Diagnosa", 300, HorizontalAlignment.Center);
            listViewRekamMedis.Columns.Add("Tindakan", 100, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataRekamMedis()
        {
            // kosongkan listview
            listViewRekamMedis.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfRekamMedis = controller.ReadAll();
            // ekstrak objek dok dari collection
            foreach (var rm in listOfRekamMedis)
            {

                var item = new ListViewItem(rm.IdRekamMedis.ToString());
                item.SubItems.Add(rm.IdPasien.ToString());
                item.SubItems.Add(rm.IdDokter.ToString());
                item.SubItems.Add(rm.TanggalPeriksa.ToShortDateString());
                item.SubItems.Add(rm.Diagnosa);
                item.SubItems.Add(rm.Tindakan);
                // tampilkan data rm ke listview
                listViewRekamMedis.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(RekamMedis rm)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            listOfRekamMedis.Add(rm);

            var item = new ListViewItem(rm.IdRekamMedis.ToString());
            item.SubItems.Add(rm.IdPasien.ToString());
            item.SubItems.Add(rm.IdDokter.ToString());
            item.SubItems.Add(rm.TanggalPeriksa.ToShortDateString());
            item.SubItems.Add(rm.Diagnosa);
            item.SubItems.Add(rm.Tindakan);
            // tampilkan data rm ke listview
            listViewRekamMedis.Items.Add(item);
        }

        private void OnUpdateEventHandler(RekamMedis rm)
        {
            // ambil index data mhs yang edit
            int index = listViewRekamMedis.SelectedIndices[0];

            // update informasi mhs di listview
            ListViewItem itemRow = listViewRekamMedis.Items[index];
            itemRow.SubItems[1].Text = rm.IdRekamMedis.ToString();
            itemRow.SubItems[2].Text = rm.IdPasien.ToString();
            itemRow.SubItems[3].Text = rm.IdDokter.ToString();
            itemRow.SubItems[4].Text = rm.TanggalPeriksa.ToShortDateString();
            itemRow.SubItems[5].Text = rm.Diagnosa;
            itemRow.SubItems[6].Text = rm.Tindakan;
        }


        private void tmbhRekamMedisBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEntryRekamMedis form = new FormEntryRekamMedis("Tambah Data Rekam Medis", controller);
            form.OnCreate += OnCreateEventHandler;
            form.Show();
        }

        private void selesaiRekamMedisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm form = new MenuForm();
            form.ShowDialog();

        }

        private void editRekamMedisBtn_Click(object sender, EventArgs e)
        {
            if (listViewRekamMedis.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                RekamMedis rm = listOfRekamMedis[listViewRekamMedis.SelectedIndices[0]];

                // buat objek form entry data mahasiswa
                FormEntryRekamMedis formEntry = new FormEntryRekamMedis("Edit Data Rekam Medis", rm, controller);

                // mendaftarkan method event handler untuk merespon event OnUpdate
                formEntry.OnUpdate += OnUpdateEventHandler;

                // tampilkan form entry mahasiswa
                formEntry.ShowDialog();
                this.Close();
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                this.Hide();
                FormEntryRekamMedis form = new FormEntryRekamMedis();
                form.ShowDialog();
            }

        }

        private void cariRekamMedisBtn_Click(object sender, EventArgs e)
        {
            listViewRekamMedis.Items.Clear();
            List<RekamMedis> listOfRekamMedis = new List<RekamMedis>();
            if (cariRekamMedisBox.Text == "")
            {
                listOfRekamMedis = rekamMedisController.ReadAll();
            }
            else
            {
                listOfRekamMedis = rekamMedisController.Search(cariRekamMedisBox.Text);
            }

            foreach (var rm in listOfRekamMedis)
            {
                var item = new ListViewItem(rm.IdRekamMedis.ToString());
                item.SubItems.Add(rm.IdPasien.ToString());
                item.SubItems.Add(rm.IdDokter.ToString());
                item.SubItems.Add(rm.TanggalPeriksa.ToShortDateString());
                item.SubItems.Add(rm.Diagnosa);
                item.SubItems.Add(rm.Tindakan);
                // tampilkan data rm ke listview
                listViewRekamMedis.Items.Add(item);
            }
        }

        private void hapusRekamMedisBtn_Click(object sender, EventArgs e)
        {
            if (listViewRekamMedis.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                RekamMedis rm = listOfRekamMedis[listViewRekamMedis.SelectedIndices[0]];


                string baseUrl = "http://rssumberwaras.evizulfia.com/";
                string endpoint = "api/rekammedis-destroy/" + rm.IdRekamMedis;

                Console.WriteLine(endpoint);

                //membuat objek rest client
                var client = new RestClient(baseUrl);

                var request = new RestRequest(endpoint, Method.DELETE);


                var response = client.Execute(request);
                Console.WriteLine(response.Content);

                dynamic result = JObject.Parse(response.Content);

                if (result.status == "200")
                {
                    string message = result.message;
                    string title = "Delete Success";
                    MessageBox.Show(message, title);
                    FormRekamMedis form = new FormRekamMedis();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    string message = result.message;
                    string title = "Delete Failed";
                    MessageBox.Show(message, title);
                }

            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }
    }
}
  