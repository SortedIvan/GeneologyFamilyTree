using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemetschek_Genealogy_Family_Tree
{
    public class Person
    {
        private int personID;
        private static int nextPersonID = 1;
        private string firstName;
        private string lastName;
        private bool personGender; //if true = male, if false = female;
        private int motherID;
        private int fatherID;

        public Person(string firstName, string lastName, bool personGender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.personGender = personGender;
            this.personID = nextPersonID;
            this.motherID = 0;
            this.fatherID = 0;
            nextPersonID += 1;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }
        public void SetFirstName(string name)
        {
            this.firstName = name;
        }

        public string GetLastName()
        {
            return this.lastName;
        }
        public void SetLastName(string name)
        {
            this.lastName = name;
        }

        public int GetPersonID()
        {
            return this.personID;
        }

        public bool GetPersonGender()
        {
            return this.personGender;
        }

        public int GetMotherID()
        {
            return this.motherID;
        }
        public void SetMotherID(int id)
        {
            this.motherID = id;
        }

        public int GetFatherID()
        {
            return this.fatherID;
        }
        public void SetFatherID(int id)
        {
            this.fatherID = id;
        }
        public override string ToString()
        {
            return $"{personID}: {this.firstName} {this.lastName} - {this.personGender} motherID:{this.motherID}|| fatherID:{this.fatherID}";
        }

    }
}
