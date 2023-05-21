using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exceptions
{



    //Action<T> ve Func<TParam, TReturn> sınıfları delegate method gibi davranır.
    //Yani Action<T> veya Func<TParam, TReturn> sınıfından yeni bir değişken oluşturup, değer olarak bir method’un kendisini atayabiliriz.
    //Böylece değişkeni her tetiklediğimizde aslında değer olarak atadığımız method‘u tetiklemiş oluruz. yabi func ve action aslında pythondaki gibi değişkenlere method ayarlamaya yarar bi nevi

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] students = new string[3] { "Berk", "Berk1", "Berk2" };
                students[3] = "Berk3";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Dizi Sınırları Aşıldı");
                Console.WriteLine(exception);
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.InnerException);
            }

            try
            {
                Find();
            }
            catch (RecordNotFound except)
            {
                Console.WriteLine(except.Message);
            }


            //ACTION TANIMI
            //tıpkı js deki gibi action delegate ile metohda method gönderdik. Parametresiz 
            HandleException(() =>
            {
                Find();
            });


            //FUNC TANIMI
            //param1 param2 returntype bu şekilde tanımlanıyor funclar
            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3,4));

            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber());

            //bu şekilde de yazılabilir tıpkı action delegeate gibi
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Thread.Sleep(1500);
            Console.WriteLine(getRandomNumber2());






            Console.ReadKey();
        }

        static int Topla(int sayi1 , int sayi2)
        {
            return sayi1 + sayi2;
        }

        private static void Find()
        {
            List<string> students2 = new List<string> { "berk", "akın" };
            if (!students2.Contains("ahmet"))
            {
                throw new RecordNotFound("Kayıt yok");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        //içerisine parametresiz method aldığı için parametre olarak action alıyor 
        private static void HandleException(Action action)
        {

            try
            {
                //action invoke etmek demek actionu yani gönderilen methodu çalıştırmak demek 
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
