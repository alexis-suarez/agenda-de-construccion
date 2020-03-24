using System;
using System.Windows.Forms;

namespace Agenda_de_Construcción
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ListClient ListClient = new ListClient();

            new Serializable().LoadData(ref ListClient);    // Read Data

            new LoginForm(ref ListClient).ShowDialog();     // Show Login Form

            //new MainForm(ref ListClient).ShowDialog();     // Show MainForm

            new Serializable().SavaData(ref ListClient);    // Write Data
        }
    }
}
