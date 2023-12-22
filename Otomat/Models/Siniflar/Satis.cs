using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Otomat.Models.Siniflar
{
    public class Satis
    {
        [Key]
        public int Satisid { get; set; }
        public int SatisAdet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal Tutar { get; set; }
        public int SekerMiktari { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}