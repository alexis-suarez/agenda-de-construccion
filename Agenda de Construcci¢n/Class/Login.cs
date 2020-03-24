using System;

namespace Agenda_de_Construcción
{
    [Serializable]
    public class Login
    {
        private string userName;
        private string password;
        private string userRole;

        public Login()
        {
            this.userName = "";
            this.password = "";
            this.userRole = "";
        }

        public Login(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
            this.userRole = "";
        }

        public Login(string userName, string password, string userRole)
        {
            this.userName = userName;
            this.password = password;
            this.userRole = userRole;
        }

        public string UserName
        {
            get { return this.userName; }

            set { this.userName = value; }
        }

        public string Password
        {
            get { return this.password; }

            set { this.password = value; }
        }

        public string UserRole
        {
            get { return this.userRole; }

            set { this.userRole = value; }
        }
    }
}
