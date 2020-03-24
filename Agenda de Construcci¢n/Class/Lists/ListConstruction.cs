using System;
using System.Collections.Generic;

namespace Agenda_de_Construcción
{
    [Serializable]
    public class ListConstruction : List<Construction>
    {
        public ListConstruction()
        {

        }

        private void Swap(int a, int b)
        {
            Construction Construction;
            Construction = this[a];
            this[a] = this[b];
            this[b] = Construction;
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
                    while (i < j && string.Compare(this[i].ProjectName, this[RightEdge].ProjectName) < 0) { i++; }
                    while (i < j && string.Compare(this[j].ProjectName, this[RightEdge].ProjectName) > 0) { j--; }

                    if (i != j) { this.Swap(i, j); }
                }

                if (i != RightEdge) { this.Swap(i, RightEdge); }

                this.QuickSort(LeftEdge, i - 1);
                this.QuickSort(i + 1, RightEdge);
            }
        }
    }
}
