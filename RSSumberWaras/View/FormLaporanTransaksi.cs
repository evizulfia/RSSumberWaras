﻿using System;
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
    public partial class FormLaporanTransaksi : Form
    {
        public FormLaporanTransaksi()
        {
            InitializeComponent();
        }

        private void selesaiLaporanBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuForm form = new MenuForm();
            form.ShowDialog();
            
        }
    }
}
