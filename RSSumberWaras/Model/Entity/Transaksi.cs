using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSumberWaras.Model.Entity
{
    public class Transaksi
    {
        int IdTransaction { set; get; }
        int IdDokter { set; get; }
        int IdPasien { set; get; }

        string namaPasien { set; get; }
        string invoice { set; get; }
        DateTime tanggalTransaksi { set; get; }
        double harga { set; get; }
        double total { set; get; }
        string status { set; get; }
    }

}
