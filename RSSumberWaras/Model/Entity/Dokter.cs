using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSumberWaras.Model.Entity
{
    public class Dokter
    {
        public int IdDokter { get; set; }
        public string NamaDokter { get; set; }
        public string Spesialisasi { get; set; }
        public string NoTelepon { get; set; }
        public int status { get; set; }
    }
}
