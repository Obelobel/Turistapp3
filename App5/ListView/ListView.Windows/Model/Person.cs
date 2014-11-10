using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ListView.Annotations;

namespace ListView.Model
{
    class Person
    {
        public string Name { get; set; }
        public string Telefon { get; set; }
        public string Adresse { get; set; }
        public string CPR { get; set; }
        public Person(string name, string telefon, string adresse, string cpr)
        {
            Name = name;
            Telefon = telefon;
            Adresse = adresse;
            CPR = cpr;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
