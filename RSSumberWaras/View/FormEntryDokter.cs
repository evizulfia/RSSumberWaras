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
    public partial class FormEntryDokter : Form
    {
        public FormEntryDokter()
        {
            InitializeComponent();
        }

        private void doktSimpanBtn_Click(object sender, EventArgs e)
        {
            FormDokter formDokter = new FormDokter();
            formDokter.Show();
            this.Hide();
        }
    }
    
}
