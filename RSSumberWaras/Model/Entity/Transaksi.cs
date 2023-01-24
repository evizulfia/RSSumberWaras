using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSumberWaras.Model.Entity
{
    public class Transaksi
    {
        public int IdTransaction { get; set; }
        public int IdObat { set; get; }
        public int IdPasien { set; get; }

        public string namaPasien { set; get; }
        public string invoice { set; get; }
        public DateTime tanggalTransaksi { set; get; }
        public double harga { set; get; }
        public double total { set; get; }
        public string status { set; get; }
    }

}
