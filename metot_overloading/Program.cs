using System;

namespace metot_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";
            int outSayi;
            bool sonuc = int.TryParse(sayi, out outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);

            }
            else
                Console.WriteLine("Başarısız!");


            Metotlar metotlar = new Metotlar();
            metotlar.Topla(8,9, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);


            // Metot Aşırı Yükleme - Overloading
            int ifade = 999;
            metotlar.EkranaYazdır(Convert.ToString(ifade));
            metotlar.EkranaYazdır(ifade);


            //metot imzası
            // metotAdi + parametre sayisi + parametre tipi       metot imzası yani 3 ü de aynı olursa kızar.


            metotlar.EkranaYazdır("Can", "Yılmaz");




            
        }
    }


    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b;
        }

        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdır(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdır(string s1, string s2)
        {
            Console.WriteLine(s1+s2);

        }
    }
}
