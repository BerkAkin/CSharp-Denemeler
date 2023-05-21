using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{

    //REFLECTION YAPISI ÇALIŞMA ANINDA NESNE HAKKINDA BİLGİ ALMAYA VE BU BİLGİLERİ KULLANMAYA
    //YARAR
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortislem = new DortIslem(2, 3);
            //Console.WriteLine(dortislem.Topla2());
            //Console.WriteLine(dortislem.Topla(3, 4));

            var tip = typeof(DortIslem);
            //çalışma anında instance üretmek için kullanılıyor
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip, 6, 7);

            //Console.WriteLine(dortIslem.Topla(4, 5));
            //Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(tip, 6, 7);

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

            Console.WriteLine(methodInfo.Invoke(instance, null));


            var metodlar = tip.GetMethods();

            foreach (var item in metodlar)
            {
                Console.WriteLine("Method Adı: " + item.Name);
                foreach (var item2 in item.GetParameters())
                {
                    Console.WriteLine("Parametreleri: " + item2);
                }
                foreach (var item3 in item.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Adı: " + item3);
                }
                Console.WriteLine("----------------------------");
            }

            Console.ReadLine();
        }
    }

    class DortIslem
    {
        int _sayi1, _sayi2;

        public DortIslem()
        {

        }

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }


        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MetodNameBerkAttribute("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }


    }

    public class MetodNameBerkAttribute : Attribute
    {
   
        public MetodNameBerkAttribute(string v)
        {

        }
    }
}
