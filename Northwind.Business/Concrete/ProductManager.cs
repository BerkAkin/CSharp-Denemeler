using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    //Business koldarı yazılır bu katmanda mesela kişinin datayı çekmeye izni var mı gibi kurallar
    //form nesnesi ile DAL nesnesi arasında bağlantı kurmaya yarayan iş katmanıdır burası. Fromun doğrudan DAL'a erişimi engellenir ve arada bazı,
    //değerlerde filtreleme işlemleri vb yapılabilir middleware gibi
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}
