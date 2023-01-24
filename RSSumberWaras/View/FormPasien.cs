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

        private PasienController pasienController = new PasienController();

        public FormPasien()
        {
            InitializeComponent();

            //membuat objek controller
            controller = new PasienController();
            InisialisasiListView();

            // fungsi untuk load table dokter
            LoadDataPasien();
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            listViewPasien.View = System.Windows.Forms.View.Details;
            listViewPasien.FullRowSelect = true;
            listViewPasien.GridLines = true;
            //listViewPasien.Columns.Add("No Urut", 50, HorizontalAlignment.Center);
            listViewPasien.Columns.Add("ID", 100, HorizontalAlignment.Center);
            listViewPasien.Columns.Add("Nama", 300, HorizontalAlignment.Center);
            listViewPasien.Columns.Add("Alamat", 300, HorizontalAlignment.Left);
            listViewPasien.Columns.Add("Tanggal Lahir", 200, HorizontalAlignment.Center);
            listViewPasien.Columns.Add("Jenis Kelamin", 200, HorizontalAlignment.Center);
            listViewPasien.Columns.Add("No HP", 100, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataPasien()
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
                item.SubItems.Add(pasien.TanggalLahir.ToShortDateString());
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
           
            var item = new ListViewItem(pasien.IdPasien.ToString());
            item.SubItems.Add(pasien.NamaPasien);
            item.SubItems.Add(pasien.Alamat);
            item.SubItems.Add(pasien.TanggalLahir.ToShortDateString());
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
            itemRow.SubItems[4].Text = pasien.TanggalLahir.ToShortDateString();
            itemRow.SubItems[5].Text = pasien.JenisKelamin;
            itemRow.SubItems[6].Text = pasien.NoTelepon;
        }

        private void selesaiPasienBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm form = new MenuForm();
            form.Show();
            
        }

        private void tmbhPasienBtn_Click(object sender, EventArgs e)
        {
            
            FormEntryPasien form = new FormEntryPasien("Tambah Data Pasien", controller);
            form.OnCreate += OnCreateEventHandler;
            form.ShowDialog();
            this.Hide();
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
                FormPasien form = new FormPasien();
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
                string endpoint = "api/pasien-destroy/" + pasien.IdPasien;

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
                    FormPasien form = new FormPasien();
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

        private void cariPasienBtn_Click(object sender, EventArgs e)
        {
            listViewPasien.Items.Clear();
            List<Pasien> listOfPasien = new List<Pasien>();
            if (cariPasienBox.Text == "")
            {
                listOfPasien = pasienController.ReadAll();
            }
            else
            {
                listOfPasien = pasienController.Search(cariPasienBox.Text);
            }

            foreach (var pasien in listOfPasien)
            {
                var item = new ListViewItem(pasien.IdPasien.ToString());
                //item.SubItems.Add(noUrut.ToString());
                //item.SubItems.Add(dok.IdDokter.ToString());
                item.SubItems.Add(pasien.NamaPasien);
                item.SubItems.Add(pasien.Alamat);
                item.SubItems.Add(pasien.TanggalLahir.ToShortDateString());
                item.SubItems.Add(pasien.JenisKelamin);
                item.SubItems.Add(pasien.NoTelepon);
                // tampilkan data dok ke listview
                listViewPasien.Items.Add(item);
            }
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
    }
}
