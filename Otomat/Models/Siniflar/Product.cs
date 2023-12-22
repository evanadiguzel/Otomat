using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Otomat.Models.Siniflar
{
    public class Product
    {
        [Key]
        public int Productid { get; set; }
        public string UrunAdi { get; set; }
        public string UrunAciklama { get; set; }
        public string UrunGorsel { get; set; }
        public decimal SatisFiyat { get; set; }
        public bool SicakUrun { get; set; }
        public  ICollection<Satis> Satis { get; set; }   
    }
}