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
            FormPasien form = new FormPasien();
            form.ShowDialog();
            this.Close();
        }
    }
}
