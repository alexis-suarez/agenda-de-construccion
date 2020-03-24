using System;
using System.Windows.Forms;
using System.IO;

namespace Agenda_de_Construcción
{
    class Serializable
    {
        private string FileName;
        private string FileAccs;

        public Serializable()
        {
            this.FileName = "data.bin";
            this.FileAccs = "accs.bin";
    }

        public void SavaData(ref ListClient ListClient)
        {
            try
            {
                using (Stream Stream = File.Open(this.FileName, FileMode.Create))
                {
                    var BinaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    BinaryFormatter.Serialize(Stream, ListClient);
                }
            }

            catch (Exception Exception)
            {
                MessageBox.Show("Error al Guardar los Datos. " + Exception.Message);
            }
            
        }

        public void LoadData(ref ListClient ListClient)
        {
            try
            {
                if (File.Exists(this.FileName))
                {
                    using (Stream Stream = File.Open(this.FileName, FileMode.Open))
                    {
                        var BinaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                        ListClient = (ListClient)BinaryFormatter.Deserialize(Stream);
                    }
                }
            }

            catch (Exception Exception)
            {
                MessageBox.Show("Error al Leer los Datos. " + Exception.Message);
            }
        }

        public void SavaUser(Login Login)
        {
            try
            {
                using (Stream Stream = File.Open(this.FileAccs, FileMode.Create))
                {
                    var BinaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    BinaryFormatter.Serialize(Stream, Login);
                }
            }

            catch (Exception Exception)
            {
                MessageBox.Show("Error al Guardar los Datos. " + Exception.Message);
            }

        }

        public void LoadUser(ref Login Login)
        {
            try
            {
                if (File.Exists(this.FileAccs))
                {
                    using (Stream Stream = File.Open(this.FileAccs, FileMode.Open))
                    {
                        var BinaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                        Login = (Login)BinaryFormatter.Deserialize(Stream);
                    }
                }
            }

            catch (Exception Exception)
            {
                MessageBox.Show("Error al Leer los Datos. " + Exception.Message);
            }
        }
    }
}
