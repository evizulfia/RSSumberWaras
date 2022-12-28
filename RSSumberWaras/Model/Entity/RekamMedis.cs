using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSumberWaras.Model.Entity
{
    public class RekamMadis
    {
        public int IdRekamMedis { get; set; }
        public DateTime TglPeriksa { get; set; }
        public string Diagnosa { get; set; }
        public string Tindakan { get; set; }
    }
}
