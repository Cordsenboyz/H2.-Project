using System;
using System.Collections.Generic;
using System.Text;

namespace Skole_Libary
{
    public class Elev : Person
    {
        private int id;
        private string hold;
        private string værge;

        public int Id
        {
            get
            {
                return id;
            }
        }

        public string Hold
        {
            get
            {
                return hold;
            }
            set
            {
                if (value != "")
                    hold = value;
                else
                    throw new Exception("Forkert Indtastning");
            }
        }

        public string Værge
        {
            get
            {
                return værge;
            }
            set
            {
                if (value != "")
                    værge = value;
                else
                    throw new Exception("Forkert Indtastning");
            }
        }
    }
}