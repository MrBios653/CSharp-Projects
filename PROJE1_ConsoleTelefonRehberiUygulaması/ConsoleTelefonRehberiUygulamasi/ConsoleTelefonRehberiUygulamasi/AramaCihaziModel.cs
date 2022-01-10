using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTelefonRehberiUygulamasi
{
    class AramaCihaziModel
    {
        public void Search(PersonData personData)
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz: ");
            Console.WriteLine("**********************************************");
            Console.WriteLine();
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("İsim veya soyisim giriniz: ");
                    string key_input = Console.ReadLine();
                    foreach (var item in personData.persons.Keys)
                    {
                        if (item.Contains(key_input))
                        {
                            Console.WriteLine("Arama Sonuçlarınız: ");
                            Console.WriteLine("**********************************************");
                            String[] splittedListNameSurname = item.Split(" ", 2);
                            Console.WriteLine("Isim: {0}", splittedListNameSurname[0]);
                            Console.WriteLine("Soyisim: {0}", splittedListNameSurname[1]);
                            var item1 = personData.persons;
                            Console.WriteLine("Telefon Numarası: {0}", item1[item]);
                            Console.WriteLine("-");  
                        }
                        else
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine("Telefon numarası giriniz: ");
                    string value_input = Console.ReadLine();
                    foreach (var item in personData.persons)
                    {
                        var item_inside_value = item.Value;
                        var item_inside_key = item.Key;
                        if (item_inside_value.Contains(value_input))
                        {
                            Console.WriteLine("Arama Sonuçlarınız: ");
                            Console.WriteLine("**********************************************");
                            String[] splittedListPhone = item_inside_key.Split(" ", 2);
                            Console.WriteLine("Isim: {0}", splittedListPhone[0]);
                            Console.WriteLine("Soyisim: {0}", splittedListPhone[1]);
                            //var item1 = personData.persons;
                            Console.WriteLine("Telefon Numarası: {0}", item.Value);
                            Console.WriteLine("-");




                        }
                        
                        
                            
                    }
                    break;
            }
        }
    }
}
