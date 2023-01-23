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
        public FormEntryPasien()
        {
            InitializeComponent();
        }

        private void EntryFormPasienSelesaiBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPasien form = new FormPasien();
            form.Show();
            
        }
    }
}
