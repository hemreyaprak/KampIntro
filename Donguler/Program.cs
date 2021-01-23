using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Geliştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            // bu tip verileri array-dizi olarak tanımlanır.

            string[] kurslar = new string[] { "Yazılım Geliştirici Geliştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java" };

            for (int i = 0; i <kurslar.Lenght; i++) //burada length deyincene kadar eleman varsa onu verir. Kaç tane olduğunu bakmaya gerek yok
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)//buradaki kurs aslında alies yani dizi demek. Dizileri tek tek dolaşmaya yarar.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }

    }
}
