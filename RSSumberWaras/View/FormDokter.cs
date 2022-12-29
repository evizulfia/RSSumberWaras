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
        }

        // atur kolom listview
        private void InisialisasiListView()
        {
            listViewDokter.View = System.Windows.Forms.View.Details;
            listViewDokter.FullRowSelect = true;
            listViewDokter.GridLines = true;
            listViewDokter.Columns.Add("ID", 35, HorizontalAlignment.Center);
            listViewDokter.Columns.Add("Nama", 400, HorizontalAlignment.Center);
            listViewDokter.Columns.Add("Spesialisasi", 150, HorizontalAlignment.Left);
            listViewDokter.Columns.Add("No. HP", 150, HorizontalAlignment.Center);
        }

        // method untuk menampilkan semua data mahasiswa
        private void LoadDataDokter()
        {
            // kosongkan listview
            listViewDokter.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listViewDokter = controller.ReadAll();
            // ekstrak objek dok dari collection
            foreach (var dok in listOfDokter)
            {
                var noUrut = listViewDokter.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(dok.IdDokter.ToString());
                item.SubItems.Add(dok.NamaDokter);
                item.SubItems.Add(dok.Spesialisasi);
                item.SubItems.Add(dok.NoHP);
                // tampilkan data dok ke listview
                listViewDokter.Items.Add(item);
            }
        }

        private void selesaiDokterBtn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void tmbhDokterBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
