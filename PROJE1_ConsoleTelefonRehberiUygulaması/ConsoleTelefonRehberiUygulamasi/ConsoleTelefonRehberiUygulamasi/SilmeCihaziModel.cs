using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTelefonRehberiUygulamasi
{
    class SilmeCihaziModel
    {
        public void DeletePersonData(PersonData personData)
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string deleteDataKey = Console.ReadLine();
            foreach (var item in personData.persons.Keys)
            {
                if(item.Contains(deleteDataKey))
                {
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",item);
                    string c = Console.ReadLine().ToString();
                    if (c == "n")
                        continue;    
                    else if (c == "y")
                    {
                        personData.persons.Remove(item);
                        break;
                    }

                }

                if (!item.Contains(deleteDataKey))
                {
                    Console.Write("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız. \n* Silmeyi sonlandırmak için: (1)\n* Yeniden denemek için: (2)");
                    string onay = Console.ReadLine().ToString();
                    if (onay == "2")
                        DeletePersonData(personData);
                    else if (onay == "1")
                        break;
                }


            }
            


        }

    }
}
