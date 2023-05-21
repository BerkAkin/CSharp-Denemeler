using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TEK TEK EKLEMEK İÇİN
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new Sql());
            //customerManager.Add(new Oracle());

            //FOREACH İLE EKLEMEK İSTENİRSE
            ICustomerDal[] customers = new ICustomerDal[2]{
                new Sql(),
                new Oracle()
            };
            foreach (var item in customers)
            {
                item.Add();
            }

            Console.ReadLine();
        }
    }
}
