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
    public partial class FormPenjualanObat : Form
    {
    

        private List<Obat> listOfObat = new List<Obat>();

        //deklarasi objek controller
        private ObatController controller;

        public FormPenjualanObat()
        {
            InitializeComponent();
            //membuat objek controller
            controller = new ObatController();
            InisialisasiListView();

            // fungsi untuk load table obtter
            LoadDataObat();
        }

        private void LoadDataObat()
        {
            // kosongkan listview
            listViewPenjualan.Items.Clear();
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
                listViewPenjualan.Items.Add(item);
            }
        }

        private void InisialisasiListView()
        {
            listViewPenjualan.View = System.Windows.Forms.View.Details;
            listViewPenjualan.FullRowSelect = true;
            listViewPenjualan.GridLines = true;
            //listViewObat.Columns.Add("No Urut", 50, HorizontalAlignment.Center);
            listViewPenjualan.Columns.Add("ID", 40, HorizontalAlignment.Center);
            listViewPenjualan.Columns.Add("Nama Obat", 250, HorizontalAlignment.Center);
            listViewPenjualan.Columns.Add("Harga", 150, HorizontalAlignment.Left);
            listViewPenjualan.Columns.Add("Satuan", 150, HorizontalAlignment.Center);
        }



        private void tmbhPenjualanBtn_Click(object sender, EventArgs e)
        {

        }

        private void hapusPenjualanBtn_Click(object sender, EventArgs e)
        {

        }

        private void selesaiPenjualanBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm form = new MenuForm();
            form.ShowDialog();
        }
    }
}
