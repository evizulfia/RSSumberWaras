using RestSharp;
using RSSumberWaras.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSumberWaras.Model.Repository
{
    public class UserRestApiRepository
    {
        public int Create(User user)
        {
            string baseUrl = "http://rssumberwaras.evizulfia.com/";
            string endpoint = "api/auth-login";

            //membuat objek rest client
            var client = new RestClient(baseUrl);

            var request = new RestRequest(endpoint, Method.POST);

            request.AddJsonBody(user);

            var response = client.Execute(request);
            var result = response.Content.IndexOf("1") > 0 ? 1 : 0;
            return result;
            //throw new NotImplementedException();
        }
    }
}
