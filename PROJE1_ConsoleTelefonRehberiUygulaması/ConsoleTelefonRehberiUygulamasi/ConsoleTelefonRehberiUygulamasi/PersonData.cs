using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTelefonRehberiUygulamasi
{
    public class PersonData
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NameSurname { get; set; }
        public string PhoneNumber { get; set; }


        public Dictionary<string, string> persons = new Dictionary<string, string>() {
            {"Ahmet Yılmaz", "5673456781" },
            {"Mehmet Yılmaz", "5436793425" },
            {"Ayşe Yılmaz", "5673452167" },
            {"Kemal Öncül", "5893456893" },
            {"İshak Demir", "5432567865" }
        };


        //public Dictionary<string, string> persons = new Dictionary<string, string>() {
        //    {"Ahmet Yılmaz", "5673456781" },
        //    {"Mehmet Yılmaz", "5436793425" },
        //    {"Ayşe Yılmaz", "5673452167" },
        //    {"Kemal Öncül", "5893456893" },
        //    {"İshak Demir", "5432567865" }
        //};



    }
}
