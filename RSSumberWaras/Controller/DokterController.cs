using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RSSumberWaras.Model.Entity;
using RSSumberWaras.Model.Repository;
using RSSumberWaras.Model.Context;
using System.Windows.Forms;

namespace RSSumberWaras.Controller
{
    public class DokterController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
       private DokterRestApiRepository _repository;

        public DokterController()
        {
            _repository = new DokterRestApiRepository();
        }

        public List<Dokter> ReadAll()
        {
            List<Dokter> list = new List<Dokter>();
            try
            {
                list = _repository.ReadAll();
            }
            catch { }
            return list;
        }

        public List<Dokter> Search(string keyword)
        {

            List<Dokter> list = new List<Dokter>();
            try
            {
                list = _repository.Search(keyword);
            }
            catch { }
            return list;
        }
        
    }
}
