using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RSSumberWaras.Model.Entity;
using RSSumberWaras.Controller;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace RSSumberWaras.View
{
    public partial class FormDokter : Form
    {
        //deklarasi objek colection untuk menamoung objek mahasiswa
        private List<Dokter> listOfDokter = new List<Dokter>();

        //deklarasi objek controller
        private DokterController controller;

        public FormDokter()
        {
            InitializeComponent();

            //membuat objek controller
            controller = new DokterController();
            InisialisasiListView();

            // fungsi untuk load table dokter
            LoadDataDokter();
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            listViewDokter.View = System.Windows.Forms.View.Details;
            listViewDokter.FullRowSelect = true;
            listViewDokter.GridLines = true;
            //listViewDokter.Columns.Add("No Urut", 50, HorizontalAlignment.Center);
            listViewDokter.Columns.Add("ID", 100, HorizontalAlignment.Center);
            listViewDokter.Columns.Add("Nama", 600, HorizontalAlignment.Center);
            listViewDokter.Columns.Add("Spesialisasi", 300, HorizontalAlignment.Left);
            listViewDokter.Columns.Add("No. HP", 300, HorizontalAlignment.Center);
            listViewDokter.Columns.Add("Status", 100, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataDokter()
        {
            // kosongkan listview
            listViewDokter.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfDokter = controller.ReadAll();
            // ekstrak objek dok dari collection
            foreach (var dok in listOfDokter)
            {
                var noUrut = listViewDokter.Items.Count + 1;
                var item = new ListViewItem(dok.IdDokter.ToString());
                //item.SubItems.Add(noUrut.ToString());
                //item.SubItems.Add(dok.IdDokter.ToString());
                item.SubItems.Add(dok.NamaDokter);
                item.SubItems.Add(dok.Spesialisasi);
                item.SubItems.Add(dok.NoTelepon);
                item.SubItems.Add(dok.status.ToString());
                // tampilkan data dok ke listview
                listViewDokter.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(Dokter dok)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            listOfDokter.Add(dok);

            int noUrut = listViewDokter.Items.Count + 1;

            // tampilkan data mhs yg baru ke list view
            var item = new ListViewItem(dok.IdDokter.ToString());
            item.SubItems.Add(dok.NamaDokter);
            item.SubItems.Add(dok.Spesialisasi);
            item.SubItems.Add(dok.NoTelepon);
            item.SubItems.Add(dok.status.ToString());

            listViewDokter.Items.Add(item);
        }

        private void OnUpdateEventHandler(Dokter dok)
        {
            // ambil index data mhs yang edit
            int index = listViewDokter.SelectedIndices[0];

            // update informasi mhs di listview
            ListViewItem itemRow = listViewDokter.Items[index];
            itemRow.SubItems[1].Text = dok.IdDokter.ToString();
            itemRow.SubItems[2].Text = dok.Spesialisasi;
            itemRow.SubItems[3].Text = dok.NoTelepon;
            itemRow.SubItems[4].Text = dok.status.ToString();
        }

        private void selesaiDokterBtn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void tmbhDokterBtn_Click(object sender, EventArgs e)
        {
         
            FormEntryDokter formEntry = new FormEntryDokter("Tambah Data Dokter", controller);
            formEntry.OnCreate += OnCreateEventHandler;
            formEntry.ShowDialog();
            this.Hide();
        }

        private void editDokterBtn_Click(object sender, EventArgs e)
        {
            if (listViewDokter.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Dokter dok = listOfDokter[listViewDokter.SelectedIndices[0]];

                // buat objek form entry data mahasiswa
                FormEntryDokter formEntry = new FormEntryDokter("Edit Data Mahasiswa", dok, controller);

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
                FormDokter formDokter = new FormDokter();
                formDokter.Show();
                this.Hide();
            }

            //FormEntryDokter formEntryDokter = new FormEntryDokter();
            //formEntryDokter.Show();
            //this.Hide();
        }

        private void hapusDokterBtn_Click(object sender, EventArgs e)
        {

            if (listViewDokter.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Dokter dok = listOfDokter[listViewDokter.SelectedIndices[0]];


                string baseUrl = "http://rssumberwaras.evizulfia.com/";
                string endpoint = "api/dokter-destroy/"+dok.IdDokter;

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

        private void cariDokterBtn_Click(object sender, EventArgs e)
        {
            ListView findListView = new ListView();
            /*
            // kosongkan listview
            listViewDokter.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfDokter = controller.Read();
            // ekstrak objek dok dari collection
            foreach (var dok in listOfDokter)
            {
                var noUrut = listViewDokter.Items.Count + 1;
                var item = new ListViewItem(dok.IdDokter.ToString());
                //item.SubItems.Add(noUrut.ToString());
                //item.SubItems.Add(dok.IdDokter.ToString());
                item.SubItems.Add(dok.NamaDokter);
                item.SubItems.Add(dok.Spesialisasi);
                item.SubItems.Add(dok.NoTelepon);
                item.SubItems.Add(dok.status.ToString());
                // tampilkan data dok ke listview
                listViewDokter.Items.Add(item);
            }
            */
            ListViewItem foundItem = findListView.FindItemWithText(cariDokterBox.Text.ToLower());
            if (foundItem != null)
            {
                foundItem.BackColor = Color.Yellow;
                foundItem.Selected = true;
            }
        }

        private void listViewDokter_SelectedIndexChanged(object sender, EventArgs e)
        {

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
