using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = {5, 99, 34, 67, 34, 3, 9};
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("***** Sıralı Dizi *****");
            Array.Sort(sayiDizisi);
            
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Clear
            Console.WriteLine("***** Array Clear *****");
            Array.Clear(sayiDizisi, 2, 2);
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Reverse
            Console.WriteLine("***** Array Reverse *****");
            Array.Reverse(sayiDizisi);
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //IndexOf
            Console.WriteLine("***** Array IndexOf *****");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 99));

            //Resize
            Console.WriteLine("***** Array Resize *****");
            Array.Resize<int>(ref sayiDizisi, 10);
            sayiDizisi[7] = 100;
            sayiDizisi[9] = 200;
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);


        }
    }
}
