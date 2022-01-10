using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTelefonRehberiUygulamasi
{
    class ListelemeCihaziModel
    {
        public void Listeleme(PersonData personData)
        {
            int count = personData.persons.Count;
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach (var item in personData.persons.Keys)
            {
                String[] splittedList = item.Split(" ", 2);
                Console.WriteLine("Isim: {0}", splittedList[0]);
                Console.WriteLine("Soyisim: {0}", splittedList[1]);
                var item1 = personData.persons;
                Console.WriteLine("Telefon Numarası: {0}", item1[item]);
                Console.WriteLine("-");
            }
            

        }
    }
}
