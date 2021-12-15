using CoffeShopCRM.Abstract;
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
            BaseCustomerManager customerManager = new NerdCustomerManager();
            customerManager.Save(new Customer)



        }


    }
}
