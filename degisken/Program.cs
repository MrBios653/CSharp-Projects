using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;
            sbyte c = -5;
            short s = -5;
            ushort us = 5;
            Int16 i16 = 10;
            int i = -2;
            Int32 i32 = 20;
            uint uInt = 2;
            long l = -10000;
            ulong ul = 100000;
            float f = 3.4;
            double doub = 3.44;
            decimal dec = 4.9987;
            char ch = 'a';
            string str = "Ahmet";

            bool b1 = true;
            bool b2 = false;

            DateTime dt = new DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'a';
            object o3 = 5;
            object o4 = 4.9;

            string str1 = string.Empty;
            string str2 = "Kemal Yılmaz";
            string ad = "Kemal";
            string soyad = "Yılmaz";
            string tamisim = ad + " " + soyad;


            bool bool9 = 10 > 5;

            string str20 = "20";
            int int20 = 20;

            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);
            

            int int21 = int20 + str20.ToInt();
            Console.WriteLine(int21);


            int int22 = int20 + int.Parse(str20);
            Console.WriteLine(int22);

            string dateTime5 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime5);

            string dateTime6 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime6);

            string dateTime7 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(dateTime7);

        }
    }
}
