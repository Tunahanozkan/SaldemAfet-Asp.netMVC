using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SaldemAfet.Models.Sınıflar
{
    public class AfetBilgisi
    {
        [Key]
        public int afetId { get; set; }
        public string afetTürü { get; set; }
        public string afetIl { get; set; }
        public string afetIlce { get; set; }
        public string afetNeden { get; set; }
        public string etkilendigiAlan { get; set; }
        public DateTime afetbasTarih { get; set; }
        public DateTime afetbitTarih { get; set; }
    }
}