using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {   //Do not repeat yourself
            //type safety - tip güvenliği

            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            //sisteme giriş yapmış mı için(bool)
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun) ;
            {
                Console.WriteLine("Artış butonu");
            }
            
            else
            {
                    
            }

            Console.WriteLine(kategoriEtiketi);

        }

    }
}
