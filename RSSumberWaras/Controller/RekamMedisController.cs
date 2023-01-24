using RSSumberWaras.Model.Entity;
using RSSumberWaras.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSumberWaras.Controller
{
    public class RekamMedisController
    {
        private RekamMedisRestApiRepository _repository;

        public RekamMedisController()
        {
            _repository = new RekamMedisRestApiRepository();
        }
        public List<RekamMedis> ReadAll()
        {
            // membuat objek collection
            List<RekamMedis> list = new List<RekamMedis>();
            var repo = new RekamMedisRestApiRepository();
            list = repo.ReadAll();
            return list;
        }

        public List<RekamMedis> Search(string keyword)
        {

            List<RekamMedis> list = new List<RekamMedis>();
            try
            {
                list = _repository.Search(keyword);
            }
            catch { }
            return list;
        }
    }
}
