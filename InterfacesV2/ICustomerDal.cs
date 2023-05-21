using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesV2
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }

    class Oracle : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }
        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }
    }

    class Sql : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }
        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
