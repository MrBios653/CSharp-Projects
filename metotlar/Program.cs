﻿using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =2;
            int b = 3;
            Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar metotlar = new Metotlar();
            metotlar.EkranaYazdır(Convert.ToString(sonuc));

            int sonuc2 = metotlar.ArttırveTopla(ref a, ref b);
            metotlar.EkranaYazdır(Convert.ToString(sonuc2));
            metotlar.EkranaYazdır(Convert.ToString(a+b));


        }

        static int Topla(int deger1, int deger2)
        {
            return (deger1+deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırveTopla(ref int deger1, ref int deger2)
        {
            deger1++;
            deger2++;
            return (deger1+deger2);
        }
    }
}
