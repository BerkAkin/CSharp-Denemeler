using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product product)
        {

        }

        public void Delete(Product product)
        {

        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>
            {
                new Product{CategoryId=1,ProductId=1,ProductName="Laptop",QuantityPerUnit="1 in a box",UnitPrice=3000,UnitsInStock=11}
            };
            return products;
        }

        public void Update(Product product)
        {

        }
    }
}
