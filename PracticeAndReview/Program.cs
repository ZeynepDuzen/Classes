using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class icerisindeki degerlere klavyeden veri girisi

            Musteri m = new Musteri();
            Console.WriteLine("Id degerini girin : ");
            m.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adiniz : ");
            m.ad = Console.ReadLine();
            Console.WriteLine("Soyadiniz : ");
            m.soyad = Console.ReadLine();
            Console.WriteLine("Sehriniz : ");
            m.sehir = Console.ReadLine();

            Console.WriteLine("*** Musteri Kimlik Karti ***");
            Console.WriteLine();
            Console.WriteLine("Id : " + m.id);
            Console.WriteLine("Ad : " + m.ad);
            Console.WriteLine("Soyad  :" + m.soyad);
            Console.WriteLine("Sehir : " + m.sehir);

            Console.Read();
        }
    }
}
