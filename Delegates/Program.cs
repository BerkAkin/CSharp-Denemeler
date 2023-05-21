using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //void ve parametresiz olanlara için tanımlama
    public delegate void MyDelegate();

    public delegate void MyDelegate2(string text);

    public delegate int MyDelegate3(int number1, int number2);

    internal class Program
    {
        static void Main(string[] args)
        {

            //temel mantık olarak fonskiyonun işlevini başka bir fonksiyona vermek için veya 
            //üstü kapalı şlekilde fonksiyonu farklı isimle çağırmak için
            //delegeler yapılacak işleri belirli şartlarda ark arakya sıralayıp eylemlemeye
            //yarar aslında.
            //reutrn type ı olan bir delege için en son verilen + delegenin returnü döner

            CustomerManager customerManager = new CustomerManager();
            Matematik matematik = new Matematik();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate();
            //myDelegate -= customerManager.ShowAlert;

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("Delegate2 Hello");

            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;
            var sonuc = myDelegate3(2, 3);
            Console.WriteLine(sonuc);


            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void SendMessage2(string text)
        {
            Console.WriteLine(text);
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!");
        }

        public void ShowAlert2(string text)
        {
            Console.WriteLine(text);
        }
    }
    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
