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

        public ObatController()
        {
            _repository = new ObatRestApiRepository();
        }
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

            List<Obat> list = new List<Obat>();
            try
            {
                list = _repository.Search(keyword);
            }
            catch { }
            return list;
        }

    }
}
