using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //Student student = new Student();

            Person[] persons = new Person[3]{
                new Customer{FirstName="Berk" }, new Student{FirstName="Mediha" }, new Person{FirstName="Cemil" }
            };
            foreach (Person person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}
