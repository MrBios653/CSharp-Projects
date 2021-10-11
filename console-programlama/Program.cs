using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Adınızı giriniz: ");
            string name = Console.ReadLine();
            Console.Write("Soyadınızı giriniz: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba "+ name + " " + surname);
        }
    }
}
