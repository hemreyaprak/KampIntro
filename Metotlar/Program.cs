using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double Fiyati = 15;
            string Aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            

        Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe -- tip güvenli bir dil c#
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------");
            }

            Console.WriteLine("-------------Metotlar------------------ - ");

            //instance - örnek
            //encapsulation - kapsülleme

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 5);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 7);
            
        }
    }
}
//Do not repeat yourself(DRY) - Clean Code - Best Practice(doğru uygulama teknikleri)
//Temel yapılar classların içerisinde olur C# için.