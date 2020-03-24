using System;

namespace Agenda_de_Construcción
{
    [Serializable]
    public class Construction
    {
        private string id;

        private string projectName;
        private string description;

        private Address address;

        private DateTime startProject;
        private DateTime finishProject;

        private ListMaterial listMaterial;
        private ListMoneyReceived listMoney;

        public Construction()
        {
            this.id = "";
            this.projectName = "";
            this.description = "";
            this.address = new Address();
            this.startProject = new DateTime();
            this.finishProject = new DateTime();
            this.listMaterial = new ListMaterial();
            this.listMoney = new ListMoneyReceived();
        }

        public Construction(string id, string projectName, string description, Address address, DateTime startProject)
        {
            this.id = id;
            this.projectName = projectName;
            this.description = description;
            this.address = address;
            this.startProject = startProject;
            this.finishProject = new DateTime();
            this.listMaterial = new ListMaterial();
            this.listMoney = new ListMoneyReceived();
        }

        public string ID
        {
            get { return this.id; }

            set { this.id = value; }
        }

        public string ProjectName
        {
            get { return this.projectName; }

            set { this.projectName = value; }
        }

        public string Description
        {
            get { return this.description; }

            set { this.description = value; }
        }

        public Address Address
        {
            get { return this.address; }

            set { this.address = value; }
        }

        public DateTime StartProject
        {
            get { return this.startProject; }

            set { this.startProject = value; }
        }

        public DateTime FinishProject
        {
            get { return this.finishProject; }

            set { this.finishProject = value; }
        }

        public ListMaterial ListMaterial
        {
            get { return this.listMaterial; }

            set { this.listMaterial = value; }
        }

        public ListMoneyReceived ListMoney
        {
            get { return this.listMoney; }

            set { this.listMoney = value; }
        }
    }
}
