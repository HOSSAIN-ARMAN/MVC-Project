using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jespar.Repository.Repository;
using Jespar.Model.Model;

namespace Jespar.BLL.BLL
{
    public class SupplierManager
    {
        SupplierRepository _supplierRepository = new SupplierRepository();
        public bool Add(Supplier supplier)
        {
            return _supplierRepository.Add(supplier);
        }
    }
}
