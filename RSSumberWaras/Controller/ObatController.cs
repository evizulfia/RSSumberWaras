﻿using RSSumberWaras.Model.Entity;
using RSSumberWaras.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSumberWaras.Controller
{
    public class ObatController
    {
        public List<Obat> ReadAll()
        {
            // membuat objek collection
            List<Obat> list = new List<Obat>();
            var repo = new ObatRestApiRepository();
            list = repo.ReadAll();
            return list;
        }
    }
}
