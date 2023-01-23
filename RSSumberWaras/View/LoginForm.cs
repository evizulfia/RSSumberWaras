using MySql.Data.MySqlClient;
using RestSharp;
using RSSumberWaras.Controller;
using RSSumberWaras.Model.Repository;
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
using ServiceStack.Text;
using Newtonsoft.Json.Linq;

namespace RSSumberWaras
{
    public partial class LoginForm : Form
    {
        //private UserController controller;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            
            string username = unameBox.Text;
            string password = passBox.Text;

            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/auth-login";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.POST);

            request.AddParameter("username", username);
            request.AddParameter("password", password);

            var response = client.Execute(request);
            Console.WriteLine(response.Content);

            dynamic result = JObject.Parse(response.Content);

            if (result.status == "200")
            {

                MenuForm menuForm = new MenuForm();
                menuForm.Show();
                this.Close();
            }
            else
            {
                string message = result.message;
                string title = "Login Failed";
                MessageBox.Show(message, title);
            }



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
        private void passBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                string username = unameBox.Text;
                string password = passBox.Text;

                string baseUrl = "http://rssumberwaras.evizulfia.com/";
                string endpoint = "api/auth-login";

                //membuat objek rest client
                var client = new RestClient(baseUrl);

                var request = new RestRequest(endpoint, Method.POST);

                request.AddParameter("username", username);
                request.AddParameter("password", password);

                var response = client.Execute(request);
                Console.WriteLine(response.Content);

                dynamic result = JObject.Parse(response.Content);

                if (result.status == "200")
                {

                    MenuForm menuForm = new MenuForm();
                    menuForm.Show();
                    this.Hide();
                }
                else
                {
                    string message = result.message;
                    string title = "Login Failed";
                    MessageBox.Show(message, title);
                }

            }
        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {
            passBox.PasswordChar = '*';
        }
    }
    
}
