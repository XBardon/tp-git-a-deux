using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraDev_FX
{
    internal class Person
    {
       string firstname;
       string lastname;  
        
        public Person(string _name, string _lname)
        {
            this.firstname = _name;
            this.lastname = _lname;
        }
    }
}
