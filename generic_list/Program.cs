using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(15);
            sayiListesi.Add(11);
            sayiListesi.Add(75);
            sayiListesi.Add(34);
            sayiListesi.Add(77);
            sayiListesi.Add(67);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Yesil");
            renkListesi.Add("Mavi");
            renkListesi.Add("Beyaz");
            renkListesi.Add("Turuncu");




            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);


            //Foreach ve List.Foreach ile elemanlara erişim

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Listeden eleman çıkarma
            sayiListesi.Remove(75);
            renkListesi.Remove("Beyaz");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            // Liste içerisinde arama
            if(sayiListesi.Contains(15))
                Console.WriteLine("15 liste içerisinde bulundu.");

            // Eleman ile index e erişme
            Console.WriteLine(renkListesi.BinarySearch("Mavi"));

            // Diziyi List e çevirme
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            // Listeyi nasıl temizleriz?
            hayvanListesi.Clear();

            // List içerisinde nesne tutmak

            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Kemal";
            kullanıcı1.Soyisim = "Yılmaz";
            kullanıcı1.Yaş = 26;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Mehmet";
            kullanıcı2.Soyisim = "Yılmaz";
            kullanıcı2.Yaş = 28;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);


            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim ="Ahmet",
                Soyisim ="Bilen",
                Yaş = 34
                
                
                });



            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı İsim: "+kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyisim: "+kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yaş: "+kullanıcı.Yaş);
            }
            

        }

        public class Kullanıcılar{
            private string isim;
            private string soyisim;
            private int yaş;

            public string Isim { get => isim; set => isim = value;}
            public string Soyisim { get => soyisim; set => soyisim = value;}
            public int Yaş { get => yaş; set => yaş = value; }



        }
    }
}
