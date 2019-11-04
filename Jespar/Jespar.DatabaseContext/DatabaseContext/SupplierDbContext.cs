using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Jespar.Model.Model;

namespace Jespar.DatabaseContext.DatabaseContext
{
    public class SupplierDbContext: DbContext
    {
        public DbSet<Supplier> Suppliers { set; get; }
    }
}
