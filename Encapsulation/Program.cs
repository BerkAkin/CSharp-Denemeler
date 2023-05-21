using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

    }
    class Customer
    {
        string _firstname;
        public int Id { get; set; }
        public string FirstName
        {
            get
            {
                return "Mr. " + _firstname;
            }
            set
            {
                _firstname = value;

            }
        }
        public string LastName { get; set; }
    }
}
