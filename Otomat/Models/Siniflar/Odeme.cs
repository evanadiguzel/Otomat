using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Otomat.Models.Siniflar
{
    public class Odeme
    {
        [Key]
        public int Id { get; set; }
        public decimal OdenenTutar { get; set; }
        public decimal Bakiye { get; set; }
        public bool KagitOdeme { get; set; }
        public bool MadeniOdeme { get; set; }
        public bool TemasliOdeme { get; set; }
        public bool TemassizOdeme { get; set; }
        //public int ProductId { get; set; }
        public int Satisid { get; set; }    
        //public virtual Product Product { get; set; }
        public virtual Satis Satis { get; set; }
    }
}