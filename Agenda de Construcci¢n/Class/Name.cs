using System;

namespace Agenda_de_Construcción
{
    [Serializable]
    public class Name
    {
        private string firstName;
        private string lastName;

        public Name()
        {
            this.firstName = "";
            this.lastName = "";
        }

        public Name(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }

            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }

            set { this.lastName = value; }
        }

        public string FullNameByLastname
        {
            get { return this.lastName + " " + this.firstName; }
        }

        public string FullNameByFirstname
        {
            get { return this.firstName + " " + this.lastName; }
        }
    }
}
