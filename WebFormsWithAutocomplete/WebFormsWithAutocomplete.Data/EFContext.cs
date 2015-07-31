using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFormsWithAutocomplete.SQLServer
{
    public class EFContext : DbContext
    {
        public EFContext() : base("name=EFC") { }

        public virtual DbSet<Product> Products { get; set; }

    }
}
