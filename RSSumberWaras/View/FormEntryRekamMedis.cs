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
        public FormEntryRekamMedis()
        {
            InitializeComponent();
        }

        private void EntryFormObatSelesaiBtn_Click(object sender, EventArgs e)
        {
            FormRekamMedis form = new FormRekamMedis();
            form.ShowDialog();
            this.Close();
        }
    }
}
