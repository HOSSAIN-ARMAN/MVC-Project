using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jespar.BLL.BLL;
using Jespar.Model.Model;

namespace JesparConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SupplierManager _supplierManager = new SupplierManager();
            Supplier _supplier = new Supplier()
            {
                Code = "001",
                Name = "Rakib",
                Address = "Dhaka",
                Email = "aa@gmail.com",
                Person = "Ibrahimn",
                PersonContact = "0147852368"
            };
            if (_supplierManager.Add(_supplier))
            {
                Console.WriteLine("Save!!");
            }
            else
            {
                Console.WriteLine("Not Save!!");
            }
            Console.ReadKey();
        }
    }
}
