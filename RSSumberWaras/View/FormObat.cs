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
    public partial class FormObat : Form
    {
        private List<Obat> listOfObat = new List<Obat>();

        //deklarasi objek controller
        private ObatController controller;

        private ObatController obatController = new ObatController();



        public FormObat()
        {
            InitializeComponent();
            //membuat objek controller
            controller = new ObatController();
            InisialisasiListView();

            // fungsi untuk load table obtter
            LoadDataObat();
        }

        private void InisialisasiListView()
        {
            listViewObat.View = System.Windows.Forms.View.Details;
            listViewObat.FullRowSelect = true;
            listViewObat.GridLines = true;
            //listViewObat.Columns.Add("No Urut", 50, HorizontalAlignment.Center);
            listViewObat.Columns.Add("ID", 40, HorizontalAlignment.Center);
            listViewObat.Columns.Add("Nama Obat", 250, HorizontalAlignment.Center);
            listViewObat.Columns.Add("Harga", 150, HorizontalAlignment.Left);
            listViewObat.Columns.Add("Satuan", 150, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataObat()
        {
            // kosongkan listview
            listViewObat.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfObat = controller.ReadAll();
            // ekstrak objek obt dari collection
            foreach (var obt in listOfObat)
            {
                //var noUrut = listViewObat.Items.Count + 1;
                var item = new ListViewItem(obt.IdObat.ToString());
                item.SubItems.Add(obt.NamaObat);
                item.SubItems.Add(obt.Harga.ToString());
                item.SubItems.Add(obt.Satuan);
                
                // tampilkan data dok ke listview
                listViewObat.Items.Add(item);
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


        private void tmbhObatBtn_Click(object sender, EventArgs e)
        {
            FormEntryObat formEntry = new FormEntryObat("Tambah Data Dokter", controller);
            formEntry.OnCreate += OnCreateEventHandler;
            formEntry.ShowDialog();
            this.Hide();

        }

        private void editObatBtn_Click(object sender, EventArgs e)
        {
            if (listViewObat.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Obat obt = listOfObat[listViewObat.SelectedIndices[0]];
                this.Close();
                // buat objek form entry data mahasiswa
                FormEntryObat formEntry = new FormEntryObat("Edit Data Mahasiswa", obt, controller);

                // mendaftarkan method event handler untuk merespon event OnUpdate
                formEntry.OnUpdate += OnUpdateEventHandler;

                // tampilkan form entry mahasiswa
                formEntry.ShowDialog();
                
            }
            else // data belum dipilih
            {
                this.Hide();
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                FormObat form = new FormObat();
                form.Show();
                
            }
        }

        private void hapusObatBtn_Click(object sender, EventArgs e)
        {
            if (listViewObat.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Obat obt = listOfObat[listViewObat.SelectedIndices[0]];


                string baseUrl = "http://rssumberwaras.evizulfia.com/";
                string endpoint = "api/obat-destroy/" + obt.IdObat;

                Console.WriteLine(endpoint);

                //membuat objek rest client
                var client = new RestClient(baseUrl);

                var request = new RestRequest(endpoint, Method.DELETE);


                var response = client.Execute(request);
                Console.WriteLine(response.Content);

                dynamic result = JObject.Parse(response.Content);

                if (result.status == "200")
                {
                    this.Hide();
                    MenuForm menuForm = new MenuForm();
                    menuForm.Show();
                    
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

        private void cariObatBtn_Click(object sender, EventArgs e)
        {
            listViewObat.Items.Clear();
            List<Obat> listOfObat = new List<Obat>();
            if (cariObatBox.Text == "")
            {
                listOfObat = obatController.ReadAll();
            }
            else
            {
                listOfObat = obatController.Search(cariObatBox.Text);
            }

            foreach (var obj in listOfObat)
            {
                var item = new ListViewItem(obj.IdObat.ToString());
                item.SubItems.Add(obj.NamaObat);
                item.SubItems.Add(obj.Harga.ToString());
                item.SubItems.Add(obj.Satuan);

                // tampilkan data dok ke listview
                listViewObat.Items.Add(item);
            }
        }

        private void selesaiObatBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            
        }
    }
}
