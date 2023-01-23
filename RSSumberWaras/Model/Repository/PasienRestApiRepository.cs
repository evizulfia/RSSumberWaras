using RestSharp;
using RSSumberWaras.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSumberWaras.Model.Repository
{
    public class PasienRestApiRepository
    {
        public List<Pasien> ReadAll()
        {
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/pasien";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Pasien>>(request);
            Console.WriteLine(response.Data);
            return response.Data;


            throw new NotImplementedException();
        }

        public List<Pasien> Search(string keyword)
        {
            //string keyword = cariObatBox.Text;
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/pasien-search?search=" + keyword;

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Pasien>>(request);
            return response.Data;


            throw new NotImplementedException();
        }
    }
}
