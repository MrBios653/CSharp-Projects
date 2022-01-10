using System;
using System.Collections.Generic;

namespace ConsoleTelefonRehberiUygulamasi
{
    public class KayitCihaziModel
    {
        public void AddPersonData(PersonData personData)
        {

            Console.WriteLine("İsim giriniz: ");
            personData.Name = Console.ReadLine();
            Console.WriteLine("Soyisim giriniz: ");
            personData.Surname = Console.ReadLine();
            Console.WriteLine("Telefon numarası giriniz: ");
            personData.PhoneNumber = Console.ReadLine();
            personData.NameSurname = string.Concat(personData.Name, " ", personData.Surname);

            personData.persons.Add(personData.NameSurname, personData.PhoneNumber);
        }




    }
    
        

  
}
