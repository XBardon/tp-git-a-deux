using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InfraDev_FX
{
    internal class PeopleContainer : IPersonContainer
    {
        List<Person> People {  get; set; }

        public PeopleContainer() 
        { 
            People = new List<Person>();
        }

        
        public List<Person> SortByFirstName()
        {
            return People.OrderBy(P => P.Firstname).ToList();
        }

        public List<Person> SortByLastName()
        {
            return People.OrderBy(P => P.Lastname).ToList();
        }
    }
}
