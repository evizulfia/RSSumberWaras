﻿using RSSumberWaras.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSumberWaras
{
    public partial class LoginForm : Form
    {
        private readonly string Username = "admin";
        private readonly string Password = "12345";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (unameBox.Text == Username && passBox.Text == Password)
            {
                MenuForm menuForm = new MenuForm();
                menuForm.Show();
                this.Hide();
                // MessageBox.Show("Kamu berhasil login");
            }
            else if (unameBox.Text == "" || passBox.Text == "")
            {
                MessageBox.Show("Form masih kosong, silahkan isi form terlebih dahulu!");
            }
            else
            {
                MessageBox.Show("Username atau Password Salah ");
            }
        }
        private void passBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                if (unameBox.Text == Username && passBox.Text == Password)
                {
                    MenuForm menuForm = new MenuForm();
                    menuForm.Show();
                    this.Hide();
                    // MessageBox.Show("Kamu berhasil login");
                }
                else if (unameBox.Text == "" || passBox.Text == "")
                {
                    MessageBox.Show("Form masih kosong, silahkan isi form terlebih dahulu!");
                }
                else
                {
                    MessageBox.Show("Username atau Password Salah ");
                }
            }
        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {
            passBox.PasswordChar = '*';
        }
    }
}
