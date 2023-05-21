using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Work[] workers = new Work[3]{
            new Manager(),
            new Worker(),
            new Robot(),
            };

            foreach (var worker in workers) {
                worker.Work();
            }
            Console.ReadLine();
        }

    }


    interface Work
    {
        void Work();
    }
    interface Eat
    {
        void Eat();
    }
    interface GetSalary
    {
        void GetSalary();
    }

    class Manager : Work, Eat, GetSalary
    {
        public void Eat()
        {
        }

        public void GetSalary()
        {
        }

        public void Work()
        {
            Console.WriteLine("Yönetici Çalıştı");

        }
    }
    class Worker : Work, Eat, GetSalary
    {
        public void Eat()
        {
        }

        public void GetSalary()
        {
        }

        public void Work()
        {
            Console.WriteLine("İşçi Çalıştı");
        }
    }
    class Robot : Work
    {
        public void Work()
        {
            Console.WriteLine("Robot Çalıştı");
        }
    }
}
