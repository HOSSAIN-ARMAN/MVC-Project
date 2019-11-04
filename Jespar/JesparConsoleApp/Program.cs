using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
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
            Console.WriteLine("----------Supplier----------");
            Console.WriteLine("--Save=>Press(1)--Delete=>Press(2)--Update=>Press(3)--ShowAll=>Press(4)--ShowById=>Press(5)");
            int save = 1;
            int delete = 2;
            int update = 3;
            int showAll = 4;
            int showById = 5;
            int check = Convert.ToInt32(Console.ReadLine());

            Supplier _supplier = new Supplier()
            {

                //Code = Console.ReadLine(),
                //Name = Console.ReadLine(),
                //Address = Console.ReadLine(),
                //Email = Console.ReadLine(),
                //Person = Console.ReadLine(),
                //PersonContact = Console.ReadLine(),
                //Code = "001",
                //Name = "Rakib",
                //Address = "Dhaka",
                //Email = "aa@gmail.com",
                //Person = "Ibrahimn",
                //PersonContact = "0147852368"
            };
            if (save == check)
            {
                Console.WriteLine("---Enter Code---");
                _supplier.Code = Console.ReadLine();
                Console.WriteLine("---Enter Name---");
                _supplier.Name = Console.ReadLine();
                Console.WriteLine("---Enter Address---");
                _supplier.Address = Console.ReadLine();
                Console.WriteLine("---Enter Email---");
                _supplier.Email = Console.ReadLine();
                Console.WriteLine("---Enter Person---");
                _supplier.Person = Console.ReadLine();
                Console.WriteLine("---Enter Person Contact---");
                _supplier.PersonContact = Console.ReadLine();

                if (_supplierManager.Add(_supplier))
                {
                    Console.WriteLine("Supplier Data Save Successfully !!");
                }
                else
                {
                    Console.WriteLine("Not Save!!");
                }
                Console.ReadKey();
            }
            else if (delete == check)
            {
                Console.WriteLine("---Enter Id Which Row Do You Want To delete ---");
                int deleteById = Convert.ToInt32(Console.ReadLine());
                if (_supplierManager.Delete(deleteById))
                {
                    Console.WriteLine("Delete Successfully !!");
                }
                else
                {
                    Console.WriteLine("Not Delete!!");
                }
                Console.ReadKey();

            }
            else if(update == check)
            {
                Console.WriteLine("---Enter Id Which Row Do You Want To Update ---");
                int updateById = Convert.ToInt32(Console.ReadLine());
                _supplier.Id = updateById;
                Console.WriteLine("---Enter Code---");
                _supplier.Code = Console.ReadLine();
                Console.WriteLine("---Enter Name---");
                _supplier.Name = Console.ReadLine();
                Console.WriteLine("---Enter Address---");
                _supplier.Address = Console.ReadLine();
                Console.WriteLine("---Enter Email---");
                _supplier.Email = Console.ReadLine();
                Console.WriteLine("---Enter Person---");
                _supplier.Person = Console.ReadLine();
                Console.WriteLine("---Enter Person Contact---");
                _supplier.PersonContact = Console.ReadLine();

                if (_supplierManager.Update(_supplier))
                {
                    Console.WriteLine("Supplier Data Update Successfully !!");
                }
                else
                {
                    Console.WriteLine("Not Update!!");
                }
                Console.ReadKey();
            }
            else if(showAll == check)
            {
                var suppliers = _supplierManager.GetAll();
                
                foreach(Supplier supplier in suppliers)
                {
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine(supplier.Code +"  "+ supplier.Name +"  "+ supplier.Email +"   "+ supplier.Person +"   "+ supplier.PersonContact);
                }
                Console.ReadKey();
            }
            else if(showById == check)
            {
                Console.WriteLine("---Enter Id Which Row Do You Want To Show ---");
                int updateById = Convert.ToInt32(Console.ReadLine());
                var supplier = _supplierManager.GetById(updateById);
                Console.WriteLine(supplier.Code + "  " + supplier.Name + "  " + supplier.Address + "  " + supplier.Email + "  " + supplier.Person + "  " + supplier.PersonContact);
                Console.WriteLine();
                Console.ReadKey();
            }
            
        }
    }
}
