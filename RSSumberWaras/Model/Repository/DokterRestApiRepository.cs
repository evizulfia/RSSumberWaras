using RestSharp;
using RSSumberWaras.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSumberWaras.Model.Repository
{
    public class DokterRestApiRepository
    {
        public int Create(Dokter dok)
        {
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/dokter-insert";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.POST);


            request.AddParameter("id_dokter", dok.IdDokter);
            request.AddParameter("nama_dokter", dok.NamaDokter);
            request.AddParameter("spesialisasi", dok.Spesialisasi);
            request.AddParameter("no_telepon", dok.NoTelepon);

            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;
            return result;
            //throw new NotImplementedException();
        }
        public int Update(Dokter dok)
        {
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/dokter-insert";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.POST);


            request.AddParameter("id_dokter", dok.IdDokter);
            request.AddParameter("nama_dokter", dok.NamaDokter);
            request.AddParameter("spesialisasi", dok.Spesialisasi);
            request.AddParameter("no_telepon", dok.NoTelepon);

            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;
            return result;
        }
        public int Delete(Dokter dok)
        {
            throw new NotImplementedException();
        }
        public List<Dokter> ReadAll()
        {
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/dokter";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Dokter>>(request);
            Console.WriteLine(response.Data);
            return response.Data;
            
            
            throw new NotImplementedException();
        }
        public List<Dokter> Read()
        {
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/dokter-search";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Dokter>>(request);
            Console.WriteLine(response.Data);
            return response.Data;


            throw new NotImplementedException();
            throw new NotImplementedException();
        }

    }
}
