using System;
using System.Collections.Generic;
using System.Text;

namespace Skole_Libary
{
    public class PersonController
    {
        public static Personliste pl = new Personliste();

        public void AddData()
        {
            Person person = new Person();
            person.Cpr = "120306-6363";
            person.Alder = 15;
            person.Id = 1;
            person.Navn = "Hans Hansen";
            person.Gender = "Male";
            pl.AddPerson(person);
        }

        public void DeleteData(Personliste P)
        {
            Person V = new Person();
            P.DeletePerson(V);
        }

        public void UpdateData()
        {
        }

        public delegate bool Validate(string a);

        public bool isMale(string cpr)
        {
            Person person = new Person();
            cpr = person.Cpr.ToString();
            string lastChar = cpr.Substring(cpr.Length - 1);

            int number = Convert.ToInt32(lastChar);
            return !(number % 2 == 0);
        }

        public bool isFemale(string cpr)
        {
            Person person = new Person();
            cpr = person.Cpr.ToString();
            string lastChar = cpr.Substring(cpr.Length - 1);

            int number = Convert.ToInt32(lastChar);

            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CprLengthOk(string cpr)
        {
            Person person = new Person();
            cpr = person.Cpr;
            return cpr.Length >= 11;
        }

        public bool CprCheck(string a, Validate test)
        {
            return test(a);
        }

        public void LegerMedDelegate()
        {
            Person person = new Person();
            Console.WriteLine("This Cpr Length Is Correct:" + CprCheck(person.Cpr, CprLengthOk));
            Console.WriteLine("This is a Female:" + CprCheck(person.Cpr, isFemale));
            Console.WriteLine("This is a Male:" + CprCheck(person.Cpr, isMale));
        }
    }
}