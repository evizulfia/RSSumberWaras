using RestSharp;
using RSSumberWaras.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSumberWaras.Model.Repository
{
    public class TransaksiRestApiRepository
    {
        public List<Transaksi> ReadAll()
        {
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/laporan";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Transaksi>>(request);
            Console.WriteLine(response.Data);
            return response.Data;


            throw new NotImplementedException();
        }

        public List<Transaksi> Search(string keyword)
        {
            //string keyword = cariObatBox.Text;
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/laporan-search?search=" + keyword;

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Transaksi>>(request);
            return response.Data;


            throw new NotImplementedException();
        }

        public Transaksi SearchById(string pasienId)
        {
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/laporan-search?search=" + pasienId;

            // membuat objek rest client
            var client = new RestClient(baseUrl);

            // membuat objek request
            var request = new RestRequest(endpoint, Method.GET);

            // kirim request ke server
            var response = client.Execute<List<Transaksi>>(request);

            return response.Data[0];
        }
    }
}
