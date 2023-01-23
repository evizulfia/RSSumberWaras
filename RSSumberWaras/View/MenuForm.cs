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

        private void RekamMedisBtn_MouseEnter(object sender, EventArgs e)
        {
            RekamMedisBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            RekamMedisBtn.Cursor = Cursors.Hand;
        }

        private void RekamMedisBtn_MouseLeave(object sender, EventArgs e)
        {
            RekamMedisBtn.SizeMode = PictureBoxSizeMode.Zoom;
            RekamMedisBtn.Cursor = Cursors.Default;
        }

        private void RekamMedisBtn_Click(object sender, EventArgs e)
        {
            FormRekamMedis rekamMedisForm = new FormRekamMedis();
            rekamMedisForm.Show();
            this.Hide();
        }

        private void ObatBtn_MouseEnter(object sender, EventArgs e)
        {
            ObatBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            ObatBtn.Cursor = Cursors.Hand;
        }

        private void ObatBtn_MouseLeave(object sender, EventArgs e)
        {
            ObatBtn.SizeMode = PictureBoxSizeMode.Zoom;
            ObatBtn.Cursor = Cursors.Default;
        }

        private void ObatBtn_Click(object sender, EventArgs e)
        {
            FormObat obatForm = new FormObat();
            obatForm.Show();
            this.Hide();
        }

        private void PenjualanMenuBtn_MouseEnter(object sender, EventArgs e)
        {
            PenjualanMenuBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            PenjualanMenuBtn.Cursor = Cursors.Hand;
        }

        private void PenjualanMenuBtn_MouseLeave(object sender, EventArgs e)
        {
            PenjualanMenuBtn.SizeMode = PictureBoxSizeMode.Zoom;
            PenjualanMenuBtn.Cursor = Cursors.Default;
        }

        private void PenjualanMenuBtn_Click(object sender, EventArgs e)
        {
            FormPenjualanObat form = new FormPenjualanObat();
            form.Show();
            this.Hide();
        }

        private void LaporanMenuBtn_MouseEnter(object sender, EventArgs e)
        {
            LaporanMenuBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LaporanMenuBtn.Cursor = Cursors.Hand;
        }

        private void LaporanMenuBtn_MouseLeave(object sender, EventArgs e)
        {
            LaporanMenuBtn.SizeMode = PictureBoxSizeMode.Zoom;
            LaporanMenuBtn.Cursor = Cursors.Default;
        }
        private void LaporanMenuBtn_Click(object sender, EventArgs e)
        {
            FormLaporanTransaksi form = new FormLaporanTransaksi();
            form.Show();
            this.Hide();
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
