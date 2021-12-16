using CoffeShopCRM.Abstract;
using CoffeShopCRM.Adapters;
using CoffeShopCRM.Concrete;
using CoffeShopCRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopCRM
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbuckdCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = 1982, FisrtName = "Umit", LastName = "Akbas", NationalityId = 12345, Id = 5 });
            Console.ReadLine();
        }

       
    }
}
