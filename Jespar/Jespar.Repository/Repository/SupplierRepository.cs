using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jespar.Model.Model;
using Jespar.DatabaseContext.DatabaseContext;

namespace Jespar.Repository.Repository
{
    public class SupplierRepository
    {
        SupplierDbContext _dbContext = new SupplierDbContext();
        public bool Add(Supplier supplier)
        {
            _dbContext.Suppliers.Add(supplier);
            return _dbContext.SaveChanges() > 0;
        }
        public bool Delete(Supplier supplier)
        {
            return true;
        }
    }
}
