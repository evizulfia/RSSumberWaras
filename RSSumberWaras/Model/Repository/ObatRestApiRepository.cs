﻿using RestSharp;
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
        public int Create(Obat obt)
        {
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/dokter-insert";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.POST);


            request.AddParameter("id_obat", obt.IdObat);
            request.AddParameter("nama_obat", obt.NamaObat);
            request.AddParameter("harga", obt.Harga);
            request.AddParameter("satuan", obt.Satuan);

            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;
            return result;
            //throw new NotImplementedException();
        }
        public int Update(Obat obt)
        {
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/dokter-insert";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.POST);


            request.AddParameter("id_obat", obt.IdObat);
            request.AddParameter("nama_obat", obt.NamaObat);
            request.AddParameter("harga", obt.Harga);
            request.AddParameter("satuan", obt.Satuan);

            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;
            return result;
        }
        public int Delete(Obat dok)
        {
            throw new NotImplementedException();
        }
        public List<Obat> ReadAll()
        {
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/dokter";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Obat>>(request);
            Console.WriteLine(response.Data);
            return response.Data;


            throw new NotImplementedException();
        }
        public List<Obat> Read()
        {
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/dokter-search";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.GET);

            var response = client.Execute<List<Obat>>(request);
            Console.WriteLine(response.Data);
            return response.Data;


            throw new NotImplementedException();
        }
    }
}