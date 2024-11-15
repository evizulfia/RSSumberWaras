﻿using MySql.Data.MySqlClient;
using RSSumberWaras.View;
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
        //private readonly string Username = "admin";
        //private readonly string Password = "12345";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
            string username = unameBox.Text;
            string password = passBox.Text;
            // Buat koneksi ke database MySQL
            string connectionString = "server=localhost;user=root;database=rssumberwaras;port=8111;password=";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Buat perintah SQL untuk mengambil data pengguna dengan username yang dimasukkan
            string sql = "SELECT * FROM users WHERE username = @username";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@username", username);

            // Eksekusi perintah SQL dan simpan hasilnya di dalam objek reader
            MySqlDataReader reader = command.ExecuteReader();

            // Cek apakah ada data yang ditemukan
            if (reader.Read())
            {
                // Jika ada, cek apakah password yang dimasukkan sesuai dengan password yang tersimpan di database
                string dbPassword = reader["password"].ToString();
                if (dbPassword == password)
                {
                    // Jika sesuai, tampilkan pesan dan tutup form login
                    MenuForm menuForm = new MenuForm();
                    MessageBox.Show("Login Berhasil!");
                    menuForm.Show();
                    this.Hide();
                }
                else
                {
                    // Jika password tidak sesuai, tampilkan pesan kesalahan
                    MessageBox.Show("Password salah. Silakan coba lagi.");
                }
            }
            else
            {
                // Jika tidak ada data yang ditemukan, tampilkan pesan kesalahan
                MessageBox.Show("Username tidak ditemukan. Silakan coba lagi.");
            }

            // Tutup koneksi ke database
            connection.Close();
        }

        private void passBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                string username = unameBox.Text;
                string password = passBox.Text;
                // Buat koneksi ke database MySQL
                string connectionString = "server=localhost;user=root;database=rssumberwaras;port=8111;password=";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                // Buat perintah SQL untuk mengambil data pengguna dengan username yang dimasukkan
                string sql = "SELECT * FROM users WHERE username = @username";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@username", username);

                // Eksekusi perintah SQL dan simpan hasilnya di dalam objek reader
                MySqlDataReader reader = command.ExecuteReader();

                // Cek apakah ada data yang ditemukan
                if (reader.Read())
                {
                    // Jika ada, cek apakah password yang dimasukkan sesuai dengan password yang tersimpan di database
                    string dbPassword = reader["password"].ToString();
                    if (dbPassword == password)
                    {
                        // Jika sesuai, tampilkan pesan dan tutup form login
                        MessageBox.Show("Login Berhasil!");
                        MenuForm menuForm = new MenuForm();
                        MessageBox.Show("Login Berhasil!");
                        menuForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Jika password tidak sesuai, tampilkan pesan kesalahan
                        MessageBox.Show("Password salah. Silakan coba lagi.");
                    }
                }
                else
                {
                    // Jika tidak ada data yang ditemukan, tampilkan pesan kesalahan
                    MessageBox.Show("Username tidak ditemukan. Silakan coba lagi.");
                }

                // Tutup koneksi ke database
                connection.Close();
            }
        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {
            passBox.PasswordChar = '*';
        }
    }
    
}
