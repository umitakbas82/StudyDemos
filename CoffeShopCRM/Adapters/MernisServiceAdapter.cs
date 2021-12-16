using CoffeShopCRM.Abstract;
using CoffeShopCRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeShopCRM.MernisServiceReference;

namespace CoffeShopCRM.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(customer.NationalityId, customer.FisrtName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth);
        }
    }
}
