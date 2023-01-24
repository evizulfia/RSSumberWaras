using RSSumberWaras.Model.Entity;
using RSSumberWaras.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSumberWaras.Controller
{
    public class TransaksiController
    {
       
        private TransaksiRestApiRepository _repository;

        public TransaksiController()
        {
            _repository = new TransaksiRestApiRepository();
        }
        public List<Transaksi> ReadAll()
        {
            // membuat objek collection
            List<Transaksi> list = new List<Transaksi>();
            var repo = new TransaksiRestApiRepository();
            list = repo.ReadAll();
            return list;
        }

        public List<Transaksi> Search(string keyword)
        {

            List<Transaksi> list = new List<Transaksi>();
            try
            {
                list = _repository.Search(keyword);
            }
            catch { }
            return list;
        }

        public Transaksi SearchById(string transID)
        {
            Transaksi trans = new Transaksi();
            try
            {
                trans = _repository.SearchById(transID);
            }
            catch { }
            return trans;
        }

        public List<Transaksi> SearchByNama(string nama)
        {

            List<Transaksi> name = new List<Transaksi>();
            try
            {
                name = _repository.SearchByNama(nama);
            }
            catch { }
            return name;
        }

    }
}
