using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSumberWaras.Model.Entity
{
    public class Obat
    {
        public int IdObat { get; set; }
        public string NamaObat { get; set; }
        public long Harga { get; set; }
        public string Satuan { get; set; }
    }
}
