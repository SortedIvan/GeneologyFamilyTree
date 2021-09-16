using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemetschek_Genealogy_Family_Tree
{
    public class PersonManager
    {
        private List<Person> people;
        private PersonFactory personFactory;

        public PersonManager()
        {
            this.people = new List<Person>();
            this.personFactory = new PersonFactory();
        }

        public void AddPerson(string firstName, string lastName, bool personGender)
        {
            this.people.Add(this.personFactory.CreatePerson(firstName, lastName, personGender));
        }

        public List<Person> GetAllPeople()
        {
            return this.people;
        }

        public Person FindPersonByID(int id)
        {
            return this.people.ElementAt(id);
        }

        public void SetFatherID(int index, int newFatherID)
        {
            Person person = this.people.ElementAt(index);
            if(person.GetFatherID() != newFatherID)
            {
                this.people.ElementAt(index).SetFatherID(newFatherID);

            }
            else
            {
                throw new Exception("ID is already existing");
            }
        }

        public void SetMotherID(int index, int newMotherID)
        {
            Person person = this.people.ElementAt(index);
            if(person.GetMotherID() != newMotherID)
            {
                this.people.ElementAt(index).SetMotherID(newMotherID);
            }
            else
            {
                throw new Exception("ID is already existing");
            }
            
        }


    }
}
