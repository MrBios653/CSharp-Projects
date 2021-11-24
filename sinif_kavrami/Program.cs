using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ali";
            calisan1.Soyad = "Yılmaz";
            calisan1.No = 23678962;
            calisan1.Departman = "İnsan Kaynakları";
            calisan1.CalisanBilgileri();

            Console.WriteLine("************************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Mehmet";
            calisan2.Soyad = "Dursun";
            calisan2.No = 56832193;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();

        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı : {0}",Ad );
            Console.WriteLine("Çalışanın Soyadı : {0}", Soyad);
            Console.WriteLine("Çalışanın Numarası : {0}",No);
            Console.WriteLine("Çalışanın Departmanı : {0}", Departman);

        }
    }
}
