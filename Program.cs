using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlar1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            sozdizimi
            class sınıfı
            erişim belirteci  [veri tipi] ozellikAdi;
            erişim belirteci  [geri donus tipi] metotAdi ([parametre listesi])
            {
            metot komutlari
            }
               

             // erişim belirtecleri
            1. Public : Her yerden erişilebilir.
            2. Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
            3. Internal : Sadece bulunduğu proje içerisinden erişilebilir
            4. Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
             */


            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayse";
            calisan1.SoyAd = "Bagriyanik";
            calisan1.No = 1928374;
            calisan1.Departman = "Muhasebe";

            calisan1.CalisanBilgileri();

            Console.WriteLine("***************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.SoyAd = "Arda";
            calisan2.No = 256879;
            calisan2.Departman = "Insan Kaynaklari";

            calisan2.CalisanBilgileri();

            Console.ReadLine();
        }
    }

    class Calisan
    {
        public string Ad;
        public string SoyAd;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan adı:"+Ad);
            Console.WriteLine("Çalışan Soyadı:"+SoyAd);
            Console.WriteLine("Çalışan Numarası:"+No);
            Console.WriteLine("Çalışanın Departmanı: "+Departman);
        }
    }



}
