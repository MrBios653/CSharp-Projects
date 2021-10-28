using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            /*liste.Add("Ali");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            // içerisinde verilere erişim
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
                Console.WriteLine(item);

            */

            // AddRange : toplu olarak eklemek
            Console.WriteLine("***** AddRange *****");
            //string[] renkler = {"kırmızı", "sarı", "yesil"};
            List<int> sayilar = new List<int>(){9, 5, 4, 12, 34};
            liste.AddRange(sayilar);
            //liste.AddRange(renkler);

            foreach (var item in liste)
                Console.WriteLine(item);

            // Sort

            Console.WriteLine("***** Sort *****");
            liste.Sort();

            foreach (var item in liste)
                Console.WriteLine(item);

            // Binary search

            Console.WriteLine("***** Binary Search *****");
            Console.WriteLine(liste.BinarySearch(12));

            // Reverse

            Console.WriteLine("***** Reverse *****");
            liste.Reverse();
            
            foreach (var item in liste)
                Console.WriteLine(item);

            // Clear
            Console.WriteLine("***** Clear *****");
            liste.Clear();

            foreach (var item in liste)
                Console.WriteLine(item);












        }
    }
}
