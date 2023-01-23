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
        public FormPasien()
        {
            InitializeComponent();
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
            FormEntryPasien form = new FormEntryPasien();
            form.ShowDialog();
        }

        private void editPasienBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEntryPasien form = new FormEntryPasien();
            form.ShowDialog();
        }

        private void hapusPasienBtn_Click(object sender, EventArgs e)
        {

        }

        private void cariPasienBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
