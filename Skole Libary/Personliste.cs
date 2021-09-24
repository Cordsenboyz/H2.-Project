using System;
using System.Collections.Generic;
using System.Text;

namespace Skole_Libary
{
    public class Personliste
    {
        private List<Person> personer;

        public Personliste()
        {
            personer = new List<Person>();
        }

        public List<Person> Folk
        {
            get
            {
                return personer;
            }
        }

        public void AddPerson(Person p)
        {
            personer.Add(p);
        }

        public void DeletePerson(Person p)
        {
            personer.Remove(p);
        }

        public void UpdatePerson(Person p)
        {
        }
    }
}