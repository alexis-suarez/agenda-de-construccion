using System;

namespace Agenda_de_Construcción
{
    [Serializable]
    public class Client
    {
        private string id;

        private Name name;
        private Address address;

        private string phone;
        private string mobile;
        private string email;

        private ListConstruction listConstruction;

        public Client()
        {
            this.id = "";
            this.name = new Name();
            this.address = new Address();
            this.phone = "";
            this.mobile = "";
            this.email = "";
            this.listConstruction = new ListConstruction();
        }

        public Client(string id, Name name, Address address, string phone, string mobile, string email)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.mobile = mobile;
            this.email = email;
            this.listConstruction = new ListConstruction();
        }

        public string ID
        {
            get { return this.id; }

            set { this.id = value; }
        }

        public Name Name
        {
            get { return this.name; }

            set { this.name = value; }
        }

        public Address Address
        {
            get { return this.address; }

            set { this.address = value; }
        }

        public string Phone
        {
            get { return this.phone; }

            set { this.phone = value; }
        }

        public string Mobile
        {
            get { return this.mobile; }

            set { this.mobile = value; }
        }

        public string Email
        {
            get { return this.email; }

            set { this.email = value; }
        }

        public ListConstruction ListConstruction
        {
            get { return this.listConstruction; }

            set { this.listConstruction = value; }
        }
    }
}
