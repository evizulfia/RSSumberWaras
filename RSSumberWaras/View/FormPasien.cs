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
    public partial class FormPasien : Form
    {
        //deklarasi objek colection untuk menamoung objek mahasiswa
        private List<Pasien> listOfPasien = new List<Pasien>();

        //deklarasi objek controller
        private PasienController controller;

        public FormPasien()
        {
            InitializeComponent();

            //membuat objek controller
            controller = new PasienController();
            InisialisasiListView();

            // fungsi untuk load table dokter
            LoadDataDokter();
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            listViewPasien.View = System.Windows.Forms.View.Details;
            listViewPasien.FullRowSelect = true;
            listViewPasien.GridLines = true;
            //listViewPasien.Columns.Add("No Urut", 50, HorizontalAlignment.Center);
            listViewPasien.Columns.Add("ID", 100, HorizontalAlignment.Center);
            listViewPasien.Columns.Add("Nama", 600, HorizontalAlignment.Center);
            listViewPasien.Columns.Add("Spesialisasi", 300, HorizontalAlignment.Left);
            listViewPasien.Columns.Add("No. HP", 300, HorizontalAlignment.Center);
            listViewPasien.Columns.Add("Status", 100, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataDokter()
        {
            // kosongkan listview
            listViewPasien.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfPasien = controller.ReadAll();
            // ekstrak objek dok dari collection
            foreach (var pasien in listOfPasien)
            {
                var noUrut = listViewPasien.Items.Count + 1;
                var item = new ListViewItem(pasien.IdPasien.ToString());
                //item.SubItems.Add(noUrut.ToString());
                //item.SubItems.Add(dok.IdDokter.ToString());
                item.SubItems.Add(pasien.NamaPasien);
                item.SubItems.Add(pasien.Alamat);
                item.SubItems.Add(pasien.TglLahir.ToString());
                item.SubItems.Add(pasien.JenisKelamin);
                item.SubItems.Add(pasien.NoTelepon);
                // tampilkan data dok ke listview
                listViewPasien.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(Pasien pasien)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            listOfPasien.Add(pasien);

            var noUrut = listViewPasien.Items.Count + 1;
            var item = new ListViewItem(pasien.IdPasien.ToString());
            //item.SubItems.Add(noUrut.ToString());
            //item.SubItems.Add(dok.IdDokter.ToString());
            item.SubItems.Add(pasien.NamaPasien);
            item.SubItems.Add(pasien.Alamat);
            item.SubItems.Add(pasien.TglLahir.ToString());
            item.SubItems.Add(pasien.JenisKelamin);
            item.SubItems.Add(pasien.NoTelepon);
            // tampilkan data dok ke listview
            listViewPasien.Items.Add(item);
        }

        private void OnUpdateEventHandler(Pasien pasien)
        {
            // ambil index data mhs yang edit
            int index = listViewPasien.SelectedIndices[0];

            // update informasi mhs di listview
            ListViewItem itemRow = listViewPasien.Items[index];
            itemRow.SubItems[1].Text = pasien.IdPasien.ToString();
            itemRow.SubItems[2].Text = pasien.NamaPasien;
            itemRow.SubItems[3].Text = pasien.Alamat;
            itemRow.SubItems[4].Text = pasien.TglLahir.ToString();
            itemRow.SubItems[5].Text = pasien.JenisKelamin.ToString();
            itemRow.SubItems[6].Text = pasien.NoTelepon.ToString();
        }

        private void selesaiPasienBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm form = new MenuForm();
            form.Show();
            
        }

        private void tmbhPasienBtn_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            FormEntryPasien form = new FormEntryPasien("Tambah Data Pasien", controller);
            form.OnCreate += OnCreateEventHandler;
            form.ShowDialog();
        }

        private void editPasienBtn_Click(object sender, EventArgs e)
        {
            if (listViewPasien.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Pasien pasien = listOfPasien[listViewPasien.SelectedIndices[0]];

                // buat objek form entry data mahasiswa
                FormEntryPasien formEntry = new FormEntryPasien("Edit Data Mahasiswa", pasien, controller);

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
                FormEntryPasien form = new FormEntryPasien();
                form.ShowDialog();
            }
            
        }

        private void hapusPasienBtn_Click(object sender, EventArgs e)
        {
            if (listViewPasien.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Pasien pasien = listOfPasien[listViewPasien.SelectedIndices[0]];


                string baseUrl = "http://rssumberwaras.evizulfia.com/";
                string endpoint = "api/dokter-destroy/" + pasien.IdPasien;

                Console.WriteLine(endpoint);

                //membuat objek rest client
                var client = new RestClient(baseUrl);

                var request = new RestRequest(endpoint, Method.DELETE);


                var response = client.Execute(request);
                Console.WriteLine(response.Content);

                dynamic result = JObject.Parse(response.Content);

                if (result.status == "200")
                {

                    MenuForm menuForm = new MenuForm();
                    menuForm.Show();
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

        private void cariPasienBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
