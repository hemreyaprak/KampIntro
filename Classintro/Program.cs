using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs(); //bu şekilde class tanımlanır
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs(); //bu şekilde class tanımlanır
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs(); //bu şekilde class tanımlanır
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            //array-dizi
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };


        }
            foreach (var kurs in kurslar)

	        {
            Console.WriteLine(Kurs.KursAdi);
            }
	}
}
