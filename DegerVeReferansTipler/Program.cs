using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;                 //burada sayı1 30 oldu ve sonra sayi2 bağlantısı koptu ve 30 olarak kaldı.
            int sayi2 = 30;                 // yani sayi 65 olsa bile sayi1 e etki etmez.
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1?=30


            int[] sayilar1 = new int[] { 10, 20, 30 };   // heapte adreste yeni bir yer oluştur.
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]=?


            //int,decimal,float,double,bool = değer tip
            //array,class,interface = referans tip
            //stack,heap

        }
    }
}
