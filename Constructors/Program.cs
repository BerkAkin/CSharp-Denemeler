using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager(23);
            manager.List();
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count=15;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }
}
