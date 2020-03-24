using System;

namespace Agenda_de_Construcción
{
    [Serializable]
    public class Material
    {
        private string id;

        private string materialName;
        private string description;

        private double import;
        private double quantity;
        private double total;

        private DateTime purchaseDate;

        public Material()
        {
            this.id = "";
            this.materialName = "";
            this.description = "";
            this.import = 0;
            this.quantity = 0;
            this.total = this.import * this.quantity;
            this.purchaseDate = new DateTime();
        }

        public Material(string id, string materialName, string description, double import, double quantity, DateTime purchaseDate)
        {
            this.id = id;
            this.materialName = materialName;
            this.description = description;
            this.import = import;
            this.quantity = quantity;
            this.total = import * quantity;
            this.purchaseDate = purchaseDate;
        }

        public string ID
        {
            get { return this.id; }

            set { this.id = value; }
        }

        public string MaterialName
        {
            get { return this.materialName; }

            set { this.materialName = value; }
        }

        public string Description
        {
            get { return this.description; }

            set { this.description = value; }
        }

        public double Import
        {
            get { return this.import; }

            set { this.import = value; }
        }

        public double Quantity
        {
            get { return this.quantity; }

            set { this.quantity = value; }
        }

        public double Total
        {
            get { return this.total; }

            set { this.total = value; }
        }

        public DateTime PurcheseDate
        {
            get { return this.purchaseDate; }

            set { this.purchaseDate = value; }
        }
    }
}
