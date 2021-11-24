using System;

namespace kurucu_fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Çalışan 1 *****");
            Calisan calisan1 = new Calisan("Ali", "Yılmaz", 23678962, "İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            
            Console.WriteLine("***** Çalışan 2 *****");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Mehmet";
            calisan2.Soyad = "Dursun";
            calisan2.No = 56832193;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();

            Console.WriteLine("***** Çalışan 3 *****");
            Calisan calisan3 = new Calisan("Ahmet", "Yılmaz");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;


        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan(){}
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı : {0}",Ad );
            Console.WriteLine("Çalışanın Soyadı : {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası : {0}",No);
            Console.WriteLine("Çalışanın Departmanı : {0}", Departman);

        }
    }
}
