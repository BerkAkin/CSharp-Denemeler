using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//dal dosyan data access layer ına karşılık geliyor. Bu katmanda veri tabanındaki kayıtlar üzerinde işlem
//yapmak için yazdığın kodlar bulunuyor. Controller dosyası gibi görev görüyor aslında. fonksiyonların bazıları context dosyasından nesne türetip
//bu nesneyi kullanarak işlemler yapıyor.

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();
            }
        }


        public Product Get(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.SingleOrDefault(p => p.ProductId == id);
            }
        }

        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                // context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}
