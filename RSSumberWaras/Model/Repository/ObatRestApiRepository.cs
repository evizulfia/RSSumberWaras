using RestSharp;
using RSSumberWaras.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSumberWaras.Model.Repository
{

    public class ObatRestApiRepository
    {
       
        public List<Obat> ReadAll()
        {
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/obat";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Obat>>(request);
            Console.WriteLine(response.Data);
            return response.Data;


            throw new NotImplementedException();
        }
        public List<Obat> Search(string keyword)
        {
            //string keyword = cariObatBox.Text;
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/obat-search?search=" + keyword;

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Obat>>(request);
            return response.Data;


            throw new NotImplementedException();
        }

    }
}
