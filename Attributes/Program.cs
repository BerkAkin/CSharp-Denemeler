using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Berk",
                LastName = "Akın",
                Age = 23
            };
            CustomerDal customer1 = new CustomerDal();
            customer1.Add(customer);
            Console.ReadLine();
        }
    }


    class CustomerDal
    {
        //hazır attribute obsolete(eski demek)
        [Obsolete("Do not use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0}" + " " + "{1}" + " " + "{2}" + " " + "{3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);

        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0}" + " " + "{1}" + " " + "{2}" + " " + "{3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);

        }

    }

    [ToTable("Customers")]
    [ToTable("TBLCustomers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    //ek yere eklemek istersen |AttributeTargets.Field şeklllimde ekleyebilrisin
    [AttributeUsage(AttributeTargets.Property)]
    class RequiredPropertyAttribute : Attribute
    {

    }

    //multiple ın olayı yukarıda mevcut
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        private string v;
        public ToTableAttribute(string v)
        {
            this.v = v;
        }

    }
}
