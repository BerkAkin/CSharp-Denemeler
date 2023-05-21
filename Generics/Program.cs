using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");
            foreach(var item in result)
            {
                Console.WriteLine(item);
               
            } 


            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName= "Name1"},new Customer { FirstName = "Name2" });

            foreach (var item in result2)
            {
                Console.WriteLine(item.FirstName);

            }

            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product:IEntity
    {
        
    }

    class Customer:IEntity
    {
        public string FirstName  { get; set; }
    }

    interface IProductDal:IRepository<Product>
    {}

    interface ICustomerDal:IRepository<Customer>
    {}

    interface IStudentDal : IRepository<Student>
    {

    }
    class Student:IEntity
    {

    }

    interface IEntity
    {

    }

    interface IRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    // class ve referans tipi olmasını istersen böyle tanımlanambiliyor
    // sadece değer tipleri istersen struct ile tanımlanıyor where T:struct 
    //interface IRepository<T> where T : class, IEntity, new()
    //{
    //    List<T> GetAll();
    //    T Get(int id);
    //    void Add(T entity);
    //    void Delete(T entity);
    //    void Update(T entity);
    //}
    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }


    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
