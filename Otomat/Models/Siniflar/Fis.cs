using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Otomat.Models.Siniflar
{
    public class Fis
    {
        public IEnumerable<Product> Deger1 { get; set; }
        public IEnumerable<Satis> Deger2 { get; set; }
        public IEnumerable<Odeme> Deger3 { get; set; }
    }
}