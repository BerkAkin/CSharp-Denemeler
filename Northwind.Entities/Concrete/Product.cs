﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// veri tabanındaki öge ne bunun bi yansımasını oluşturan dosya aslında burası yani model dosyası gibi tbalo ççoğul nesne tekil isimli

namespace Northwind.Entities.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public Int16 UnitsInStock { get; set; }
    }
}
