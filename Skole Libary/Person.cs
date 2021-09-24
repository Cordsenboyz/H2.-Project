using System;
using System.Collections.Generic;

namespace Skole_Libary
{
    public class Person
    {
        private int id;
        private string cpr;
        private string navn;
        private int alder;
        private string gender;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Cpr
        {
            get
            {
                return cpr;
            }
            set
            {
                if (value != "")
                    cpr = value;
                else
                    throw new Exception("Forkert Indtastning");
            }
        }

        public string Navn
        {
            get
            {
                return navn;
            }
            set
            {
                if (value != "")
                    navn = value;
                else
                    throw new Exception("Forkert Indtastning");
            }
        }

        public int Alder
        {
            get
            {
                return alder;
            }
            set
            {
                alder = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value != "")
                    gender = value;
                else
                    throw new Exception("Forkert Indtastning");
            }
        }

        public override string ToString()
        {
            return $"ID: {Id} Navn: {Navn} Cpr: {Cpr} Alder: {Alder} Gender: {Gender}";
        }
    }
}