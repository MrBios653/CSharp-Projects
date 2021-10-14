using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Lutfen bir sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata : " + ex.Message.ToString());

            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı.");
                // finally mecburi değil.
            }

            try
            {
                int a = int.Parse(null);
                
            }
            catch(ArgumentNullException ex1)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex1);
            }
            
            try
            {
                int b = int.Parse("test");
            }
            catch(FormatException ex2)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex2);

            }

            try
            {
                int c = int.Parse("-2000000000000000");

            }
            catch(OverflowException ex3)
            {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
                Console.WriteLine(ex3);

            }
            finally
            {
                Console.WriteLine("Başarıyla tamamlandı.");
            }
        }
    }
}
