using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace AccessModifiersDemo
{
    internal class Program
    {
        // Sağdaki başvurulara kullanılacak olan classın olduğu projeyi ekledim, sonra üstte using ile import ettim ve diğer projedeki classı
        //public olarak tanımladım bu sayede bu projede diğer projedeki class erişilebilir hale geldi
        static void Main(string[] args)
        {
            Course course = new Course();
        }
    }
}
