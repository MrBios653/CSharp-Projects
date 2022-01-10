using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleTelefonRehberiUygulamasi
{
    public class Program
    {
        //private static List<Person> AddSampleData()
        //{
        //    List<Person> output = new List<Person>();

        //    output.Add(new Person { Name = Console.ReadLine(), Surname = Console.ReadLine(), PhoneNumber = Console.ReadLine() });
        //    return output;
        //}

        
        
        static void Main(string[] args)
        {
            Console.Write("  Lütfen yapmak istediğiniz işlemi seçiniz :) \n " +
                "*******************************************\n" +
                "(1) Yeni Numara Kaydetmek \n" +
                "(2) Varolan Numarayı Silmek \n" +
                "(3) Varolan Numarayı Güncelleme \n" +
                "(4) Rehberi Listelemek \n" +
                "(5) Rehberde Arama Yapmak﻿ \n");
            int input = Convert.ToInt32(Console.ReadLine().Trim());
            PersonData personData = new PersonData();
            KayitCihaziModel kayitCihaziModel = new KayitCihaziModel();
            SilmeCihaziModel silmeCihaziModel = new SilmeCihaziModel();
            GuncellemeCihaziModel guncellemeCihaziModel = new GuncellemeCihaziModel();
            ListelemeCihaziModel listelemeCihaziModel = new ListelemeCihaziModel();
            AramaCihaziModel aramaCihaziModel = new AramaCihaziModel();
            switch (input)
            {
                case 1:
                    kayitCihaziModel.AddPersonData(personData);
                    foreach (var item in personData.persons)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 2:
                    silmeCihaziModel.DeletePersonData(personData);
                    foreach (var item in personData.persons)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 3:
                    guncellemeCihaziModel.UpdatePersonData(personData);
                    foreach (var item in personData.persons)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 4:
                    listelemeCihaziModel.Listeleme(personData);
                    break;
                case 5:
                    aramaCihaziModel.Search(personData);
                    break;
            }          
        }
    }
}
