using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Otomat.Models.Siniflar
{
    public class Context:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Satis> Satises { get; set; }
        public DbSet<Odeme> Odemes { get; set; }
    }
}