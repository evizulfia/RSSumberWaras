using RSSumberWaras.Model.Entity;
using RSSumberWaras.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSumberWaras.Controller
{
    public class PasienController
    {
        private PasienRestApiRepository _repository;

        public PasienController()
        {
            _repository = new PasienRestApiRepository();
        }
        public List<Pasien> ReadAll()
        {
            // membuat objek collection
            List<Pasien> list = new List<Pasien>();
            var repo = new PasienRestApiRepository();
            list = repo.ReadAll();
            return list;
        }

        public List<Pasien> Search(string keyword)
        {

            List<Pasien> list = new List<Pasien>();
            try
            {
                list = _repository.Search(keyword);
            }
            catch { }
            return list;
        }
    }
}
