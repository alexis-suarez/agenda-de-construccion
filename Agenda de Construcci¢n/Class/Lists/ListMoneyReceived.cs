using System;
using System.Collections.Generic;

namespace Agenda_de_Construcción
{
    [Serializable]
    public class ListMoneyReceived : List<MoneyReceived>
    {
        public ListMoneyReceived()
        {

        }

        private void Swap(int a, int b)
        {
            MoneyReceived MoneyReceived;
            MoneyReceived = this[a];
            this[a] = this[b];
            this[b] = MoneyReceived;
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
                    while (i < j && DateTime.Compare(this[i].Date, this[RightEdge].Date) < 0) { i++; }
                    while (i < j && DateTime.Compare(this[j].Date, this[RightEdge].Date) > 0) { j--; }

                    if (i != j) { this.Swap(i, j); }
                }

                if (i != RightEdge) { this.Swap(i, RightEdge); }

                this.QuickSort(LeftEdge, i - 1);
                this.QuickSort(i + 1, RightEdge);
            }
        }
    }
}
