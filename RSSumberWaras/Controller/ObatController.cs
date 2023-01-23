using RSSumberWaras.Model.Entity;
using RSSumberWaras.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSumberWaras.Controller
{
    public class ObatController
    {
        private ObatRestApiRepository _repository;
        public List<Obat> ReadAll()
        {
            // membuat objek collection
            List<Obat> list = new List<Obat>();
            var repo = new ObatRestApiRepository();
            list = repo.ReadAll();
            return list;
        }

        public List<Obat> Search(string keyword)
        {
            // membuat objek collection
            List<Obat> list = new List<Obat>();
            var repo = new ObatRestApiRepository();
            list = repo.Search(keyword);
            return list;
        }

        public List<Obat> ReadByProductName(string productName)
        {
            List<Obat> list = new List<Obat>();
            try
            {
                list = _repository.ReadByProductName(productName);
            }
            catch { }
            return list;
        }
    }
}
