using System;
using System.Collections.Generic;

namespace Agenda_de_Construcción
{
    [Serializable]
    public class ListClient : List<Client>
    {
        public ListClient()
        {

        }

        private void Swap(int a, int b)
        {
            Client Client;
            Client = this[a];
            this[a] = this[b];
            this[b] = Client;
        }

        public void QuickSort(int LeftEdge, int RightEdge, int Type)
        {
            if (this.Count > 1)
            {
                if (LeftEdge >= RightEdge) { return; }

                int i = LeftEdge;
                int j = RightEdge;

                while (i < j)
                {
                    if (Type == 0)
                    {
                        while (i < j && string.Compare(this[i].Name.FullNameByLastname, this[RightEdge].Name.FullNameByLastname) < 0) { i++; }
                        while (i < j && string.Compare(this[j].Name.FullNameByLastname, this[RightEdge].Name.FullNameByLastname) > 0) { j--; }
                    }

                    if (Type == 1)
                    {
                        while (i < j && string.Compare(this[i].Name.FullNameByFirstname, this[RightEdge].Name.FullNameByFirstname) < 0) { i++; }
                        while (i < j && string.Compare(this[j].Name.FullNameByFirstname, this[RightEdge].Name.FullNameByFirstname) > 0) { j--; }
                    }

                    else
                    {
                        break;
                    }

                    if (i != j) { this.Swap(i, j); }
                }

                if (i != RightEdge) { this.Swap(i, RightEdge); }

                this.QuickSort(LeftEdge, i - 1, Type);
                this.QuickSort(i + 1, RightEdge, Type);
            }
        }
    }
}
