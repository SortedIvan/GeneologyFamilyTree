using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemetschek_Genealogy_Family_Tree
{
    public class PersonFactory
    {
        public PersonFactory()
        {

        }

        public Person CreatePerson(string firstName, string lastName, bool personGender)
        {
            Person person = new Person(firstName, lastName, personGender);
            return person;
        }


    }
}
