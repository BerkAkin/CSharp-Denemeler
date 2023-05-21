using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    //bir işleme ek olarak bir hareket varsa bunu event ile yapabilirim
    //örneğin bir ürün nesnesi için ürün türüne göre eventa abone olursam o event o nesne çalışır
    internal class Program
    {
        static void Main(string[] args)
        {

            Product harddisk = new Product(50);
            harddisk.ProductName = "Hard Disk";

            Product gsm = new Product(50);
            gsm.ProductName = "GSM";
            gsm.StockControlEvent += Gsm_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                harddisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("GSM is about to out of stock");
        }
    }
}
