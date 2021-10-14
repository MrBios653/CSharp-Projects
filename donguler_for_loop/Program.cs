using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayac = Int32.Parse(Console.ReadLine());
            for(int i=0; i<=sayac ; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            int tekToplam = 0;
            int ciftToplam = 0;

            for(int j = 1; j <= 1000; j++)
            {
                if(j%2 == 1)
                {
                    tekToplam += j;
                }
                else
                    ciftToplam += j;
            }

            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Çift Toplam: " + ciftToplam);



            for(int i = 1; i < 10; i++)
            {
                if(i == 4)
                    break;
                Console.WriteLine(i);
            }

            for(int i = 1; i < 10; i++)
            {
                if(i == 4)
                    continue;  // 4 ü atlar döngü devam eder.
                Console.WriteLine(i);
            }



        }
    }
}
