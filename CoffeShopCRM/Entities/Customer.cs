using CoffeShopCRM.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopCRM.Entities
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }
        public int NationalityId { get; set; }

    }

}
