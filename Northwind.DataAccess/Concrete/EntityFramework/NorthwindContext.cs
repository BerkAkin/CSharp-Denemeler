using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//context dosyan veritabanındaki hangi tabloya bağlanacağının bir örndeğidir aslında burada DbSet özelliği Product tablosuna atanmış durumda
//o dbset nesnesi product listesi gibi aslında.

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    internal class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
