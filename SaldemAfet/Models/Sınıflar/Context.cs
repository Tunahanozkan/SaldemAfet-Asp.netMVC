using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SaldemAfet.Models.Sınıflar
{
    public class Context:DbContext
    {
        public DbSet<AfetBilgisi> afetBilgisis { get; set; }
    }
}