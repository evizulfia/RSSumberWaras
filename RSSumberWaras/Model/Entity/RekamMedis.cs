using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSumberWaras.Model.Entity
{
    public class RekamMedis
    {
        public int IdRekamMedis { get; set; }
        public int IdPasien { get; set; }
        public int IdDokter{ get; set; }
        public DateTime TanggalPeriksa { get; set; }
        public string Diagnosa { get; set; }
        public string Tindakan { get; set; }
    }
}
