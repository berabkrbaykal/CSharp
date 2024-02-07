using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();
            SelamVer();

            int sonuc = Topla();
            
        }

        static void SelamVer()
        {
            Console.WriteLine("Merhaba");
        }

        static int Topla()
        {
            return 5;
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
