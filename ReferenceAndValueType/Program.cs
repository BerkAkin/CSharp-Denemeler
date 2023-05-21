using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

            string[] cities1 = { "Ankara", "Adana", "Afyon" }; //101 ref no örneğin
            string[] cities2 = { "Bursa", "Bolu", "Balıkesir" }; //102 olabilir bu seferki referans değerin ama değiştirince 101'i gösterir

            cities2 = cities1;
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]); // bu kısımda artık istanbul yazar çünkü cities2 cities1 iin adresini gösteriyor. Değiştiği için öyle olur

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            string[] dizi; //Belleğin stack alanında null değerli bi dizi nesnesi oluşuyor ancak heap kısmında bi yere referans olmuyor.
            string[] dizi2 = new string[5]; //Belleğin stack alanında dizi2 kısmında nesne oluştu ve hesap alanında 5 string boyutlu alanı refere ediyor.
            //new anahtarı bellekte yer işgal eder o yüzden doğru kullanımı önemlidir.


            Console.ReadLine();
        }
    }
}
