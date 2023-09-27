using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraDev_FX
{
    internal class Person
    {
       public string Firstname { get; set; }
       public string Lastname { get; set; }
        public Person() { }

        public Person(string _name, string _lname)
        {
            this.Firstname = _name;
            this.Lastname = _lname;
        }
    }
}
