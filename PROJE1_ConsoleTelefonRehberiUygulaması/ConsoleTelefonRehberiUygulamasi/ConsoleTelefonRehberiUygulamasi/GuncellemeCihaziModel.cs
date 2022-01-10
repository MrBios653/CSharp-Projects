using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTelefonRehberiUygulamasi
{
    class GuncellemeCihaziModel
    {
        public void UpdatePersonData(PersonData personData)
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string updateData = Console.ReadLine();
            foreach (var item in personData.persons.Keys)
            {
                if (item.Contains(updateData))
                {
                    Console.WriteLine("Güncellemek istediğiniz numarayı giriniz: ");
                    string updateNumber = Console.ReadLine();
                    personData.persons[item] = updateNumber;
                    break;
                }
                if (!item.Contains(updateData))
                {
                    Console.Write("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. \n* Güncellemeyi sonlandırmak için: (1)\n* Yeniden denemek için: (2)");
                    string onay = Console.ReadLine().ToString();
                    if (onay == "2")
                        UpdatePersonData(personData);
                    else if (onay == "1")
                        break;
                }
            }
        }
    }
}
