using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            SelamVer("Bera Bekir");
            SelamVer();

            int sonuc = Topla(3,5);

            //Arrays
            string ogrenci1 = "Bera Bekir";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Danny";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Bera Bekir";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Danny"; 

            for (int i = 0;i<ogrenciler.Length;i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "Sivas" };
            string[] sehirler2 = new[] { "Diyarbakır", "Kahramanmaraş", "Gaziantep" };
            string[] sehirler3;

            sehirler2 = sehirler1;
            sehirler1[0] = "Antalya";
            Console.WriteLine(sehirler2[0]);

            sehirler3 = sehirler2;
            Console.WriteLine(sehirler3[1]);

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Eskişehir", "İzmir", "Konya" };
            yeniSehirler1.Add("Isparta");

            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }
            */

            Person person1 = new Person();
            person1.FirstName = "Bera Bekir";
            person1.LastName = "Baykal";
            person1.DateOfBirth = 2004;
            person1.NationalIdentity = 12345678910;

            Person person2 = new Person();
            person2.FirstName = "Engin";

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }

        static void SelamVer(string isim = "Nameless")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 0, int sayi2 = 0)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi = false;


            string ad = "Bera Bekir";
            string soyad = "Baykal";
            int dogumYili = 2004;
            long tcNo = 12345678901;

            Console.WriteLine(mesaj);

            Console.WriteLine(tutar * 1.18);
        }
    }
    public class Vatandas
    {
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public int DogumYili { get; set; }

        public long tcNo { get; set; }

    }
}
