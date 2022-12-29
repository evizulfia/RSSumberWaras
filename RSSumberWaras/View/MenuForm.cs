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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void logoutMenuBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void DokterBtn_MouseEnter(object sender, EventArgs e)
        {
            DokterBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            DokterBtn.Cursor = Cursors.Hand;
        }

        private void DokterBtn_MouseLeave(object sender, EventArgs e)
        {
            DokterBtn.SizeMode = PictureBoxSizeMode.Zoom;
            DokterBtn.Cursor = Cursors.Default;
        }
        private void DokterBtn_Click(object sender, EventArgs e)
        {
            FormDokter dokterForm = new FormDokter();
            dokterForm.Show();
            this.Hide();
        }

        private void PasienBtn_MouseEnter(object sender, EventArgs e)
        {
            PasienBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            PasienBtn.Cursor = Cursors.Hand;
        }

        private void PasienBtn_MouseLeave(object sender, EventArgs e)
        {
            PasienBtn.SizeMode = PictureBoxSizeMode.Zoom;
            PasienBtn.Cursor = Cursors.Default;
        }
        private void PasienBtn_Click(object sender, EventArgs e)
        {
            FormPasien pasienForm = new FormPasien();
            pasienForm.Show();
            this.Hide();
        }

        private void RekamMedisBtn_Click(object sender, EventArgs e)
        {
            FormRekamMedis rekamMedisForm = new FormRekamMedis();
            rekamMedisForm.Show();
            this.Hide();
        }

        private void ObatBtn_Click(object sender, EventArgs e)
        {
            FormObat obatForm = new FormObat();
            obatForm.Show();
            this.Hide();
        }

        private void ResepBtn_Click(object sender, EventArgs e)
        {
            FormResep resepForm = new FormResep();
            resepForm.Show();
            this.Hide();
        }
    }
}
