using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteringsalgoritm
{
    internal class MergeSort2:IntSorter
    {
        private int M;
        public MergeSort2(int limit) 
        {
            this.M = limit;
        }
        public void Sort(int[] a)
        {
            Sort(a, 0, a.Length - 1);
        }
        public void Sort(int[] a, int low, int high)

        {
            //if (low >= high) { return; }
            if(high-low +1 < M) 
            {
                InsertionSort(a, low, high);
                return;
            }
            if (low < high) 
            {
                //beräkana mittpunketn på arrayen
                int mid = (low + high) / 2;

                Sort(a, low, mid);
                Sort(a, mid + 1, high);
                //merga ihop de två halvorna till arrayen
                Merge(a, low, mid, high);
            }
            

        }
        public void Merge(int[] a, int low, int mid, int high)
        {
            //new array som börjar från mitten av a
            int[] b = new int[high - low + 1];
            //går igenom alla värden från low till high
            for (int k = low; k <= high; k++)
            {
                //kopierar över delarna till en ny array
                b[k - low] = a[k];
            }



            int i = 0; //i börjar från början
            int j = mid - low + 1;// j börjar från mitten

            //k används för att uppdatera a[]
            for (int k = low; k <= high; k++)
            {
                // Om 'i' är större än 'mid', betyder det att den vänstra delen är slut
                if (i > mid - low)
                {
                    // Kopiera värdet från den högra delen av den temporära arrayen till den sorterade arrayen
                    a[k] = b[j++]; // Öka j med 1 efter att ha kopierat värdet

                }
                // Om 'j' är större än 'high', betyder det att den högra delen är slut
                else if (j > high - low)
                {
                    a[k] = b[i++];

                }
                // Om det aktuella värdet i den vänstra delen är mindre än eller lika med det aktuella värdet i den högra delen
                else if (b[i] <= b[j])
                {
                    // Kopiera värdet från den vänstra delen till den sorterade arrayen
                    a[k] = b[i++];// Öka i med 1 efter att ha kopierat värdet

                }
                // Annars, det aktuella värdet i den högra delen är mindre
                else
                {
                    // Kopiera värdet från den högra delen till den sorterade arrayen
                    a[k] = b[j++];

                }
            }

        }
        public void InsertionSort(int[] a, int low, int high)
        {
            int N = a.Length;
            for (int i = low+1; i <= high; i++)
            {
                int key = a[i];
                int j = i-1;
                while(j>=low && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = key;
            }
        }
    }
}
