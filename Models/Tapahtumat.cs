﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TapahtumaLib.Models
{
    public partial class Tapahtumat
    {
        public int TapahtumaId { get; set; }
        public string Nimi { get; set; }
        public string Sijainti { get; set; }
        [DataType(DataType.Date)]
        public DateTime Päivämäärä { get; set; }
        public string Kategoria { get; set; }
        public decimal? Hinta { get; set; }
        public string Kuvaus { get; set; }
        public string Linkki { get; set; }
        public bool? Ikäraja { get; set; }
        public byte[] Kuva { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
    }
}
