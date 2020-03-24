using System;

namespace Agenda_de_Construcción
{
    [Serializable]
    public class Address
    {
        private string street;
        private string suburb;
        private string number;

        public Address()
        {
            this.street = "";
            this.suburb = "";
            this.number = "";
        }

        public Address(string street, string suburb, string number)
        {
            this.street = street;
            this.suburb = suburb;
            this.number = number;
        }

        public string Street
        {
            get { return this.street; }

            set { this.street = value; }
        }

        public string Suburb
        {
            get { return this.suburb; }

            set { this.suburb = value; }
        }

        public string Number
        {
            get { return this.number; }

            set { this.number = value; }
        }
    }
}
