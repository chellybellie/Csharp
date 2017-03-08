using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExe

{
    public class Name
    {
        public string firstName;
        public string middleName;
        public string lastName;

        public string FullName
        {
            get
            {
                string full = firstName;

                if (middleName != string.Empty)
                {
                    full += " " + middleName;
                }
                if (lastName != string.Empty)
                {
                    full += " " + lastName;
                }

                return full;
            }
            set
            {
                string[] names = value.Split(' ');

                if (names.Length == 3)
                {
                    firstName = names[0];
                    middleName = names[1];
                    lastName = names[2];
                }
                else if (names.Length == 2)
                {
                    firstName = names[0];
                    middleName = "";
                    lastName = names[1];
                }
                else if (names.Length == 1)
                {
                    firstName = names[0];
                    middleName = "";
                    lastName = "";
                }
            }
        }
        public string Initials
        {
            get
            {
                string letters = string.Empty;

                if (firstName != string.Empty)
                {
                    letters += firstName[0];
                }
                if (middleName != string.Empty)
                {
                    letters += middleName[0];
                }
                if (lastName != string.Empty)
                {
                    letters += lastName[0];
                }

                return letters;
            }
        }

        public string this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        return firstName;
                    case 1:
                        return middleName;
                    case 2:
                        return lastName;
                }

                // don't do that
                // you should really throw an exception
                // we'll talk about that in just a few minutes
                return "";
            }
            set
            {
                switch (i)
                {
                    case 0:
                        firstName = value;
                        break;
                    case 1:
                        middleName = value;
                        break;
                    case 2:
                        lastName = value;
                        break;
                }
            }
        }
    }
}