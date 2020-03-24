using System;

namespace Agenda_de_Construcción
{
    [Serializable]
    public class MoneyReceived
    {
        private string id;
        private double money;
        private string description;
        private DateTime date;

        public MoneyReceived()
        {
            this.id = "";
            this.money = 0;
            this.description = "";
            this.date = new DateTime();
        }

        public MoneyReceived(string id, double money, string description, DateTime date)
        {
            this.id = id;
            this.money = money;
            this.description = description;
            this.date = date;
        }

        public string ID
        {
            get { return this.id; }

            set { this.id = value; }
        }

        public double Money
        {
            get { return this.money; }

            set { this.money = value; }
        }

        public string Description
        {
            get { return this.description; }

            set { this.description = value; }
        }

        public DateTime Date
        {
            get { return this.date; }

            set { this.date = value; }
        }
    }
}
