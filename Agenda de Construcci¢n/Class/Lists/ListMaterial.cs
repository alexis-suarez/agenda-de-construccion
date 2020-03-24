using System;
using System.Collections.Generic;

namespace Agenda_de_Construcción
{
    [Serializable]
    public class ListMaterial : List<Material>
    {
        public ListMaterial()
        {

        }

        private void Swap(int a, int b)
        {
            Material Material;
            Material = this[a];
            this[a] = this[b];
            this[b] = Material;
        }

        public void QuickSort(int LeftEdge, int RightEdge)
        {
            if (this.Count > 1)
            {
                if (LeftEdge >= RightEdge) { return; }

                int i = LeftEdge;
                int j = RightEdge;

                while (i < j)
                {
                    while (i < j && DateTime.Compare(this[i].PurcheseDate, this[RightEdge].PurcheseDate) < 0) { i++; }
                    while (i < j && DateTime.Compare(this[j].PurcheseDate, this[RightEdge].PurcheseDate) > 0) { j--; }

                    if (i != j) { this.Swap(i, j); }
                }

                if (i != RightEdge) { this.Swap(i, RightEdge); }

                this.QuickSort(LeftEdge, i - 1);
                this.QuickSort(i + 1, RightEdge);
            }
        }
    }
}
