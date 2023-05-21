using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DÜZ ARRAYLİST
            ArrayList cities2 = new ArrayList();
            cities2.Add("Ankara");
            cities2.Add("Adana");
            cities2.Add(2);
            foreach (var item in cities2)
            {
                Console.WriteLine(item);
            }



            //Generic tür korumalı arraylist 
            List<string> cities = new List<string>();
            cities.Add("2");
            cities.Add("İstanbul");
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Berk" });
            customers.Add(new Customer { Id = 2, FirstName = "Akın" });
            foreach (var item in customers)
            {
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.Id);
            }
            var count = customers.Count();
            //count, add, addRange(dizi veriyorsun direkt ekliyor), clear, contains, find, foreach, indexof, lastindexof, insert(başa ekler), remove
            //, removeall(c=>c.FirstName=="Berk"); (ismi berk olanları bul ve sil) 



            //DICTIONARY YAPISI büyüktür küçüktür arası değerler key value olarak
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Book","Kitap");
            dictionary.Add("Table","Masa");
            dictionary.Add("Computer","Bilgisayar");

            Console.WriteLine(dictionary["Table"]);
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            //bazı dict komutları ContainsKey, ContainsValue
            Console.ReadLine();
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
