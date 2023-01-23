using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSumberWaras.Model.Entity
{
    public class Pasien
    {
        public int IdPasien { get; set; }
        public string NamaPasien { get; set; }
        public string Alamat { get; set; }
        public DateTime TanggalLahir { get; set; }
        public string JenisKelamin { get; set; }
        public string NoTelepon { get; set; }
    }
}
