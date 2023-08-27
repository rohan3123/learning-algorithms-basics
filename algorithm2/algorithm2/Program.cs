using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] a = new int[] { 1, 3,2,7,4,9};
            QuickSort(a,0,a.Length -1);
            for(int i=0;i<a.Length; i++)
            {
                Console.Write(a[i]);
            }
            Console.Read();
        }
        public static void Swap(int[] a, int i, int j)
        {
            int t = a[i];
            a[i]=a[j];
            a[j]=t;


        }

        private static int Partition(int[] a, int l, int r)
        {
            int ndx = l;
            int pivot = a[l];
            for (int i = l+1; i <= r; i++)
            {
                if(a[i]<pivot)
                {
                    ndx++;
                    Swap(a,ndx, l);
                }
            }
            Swap(a,ndx,l);
            return ndx;
        }

        private static void QuickSort(int[] a, int l, int r)
        {
            if(l<r)
            {
                var pi = Partition(a,l,r);
                QuickSort(a,l,pi - 1);
                QuickSort(a,pi+1, r);
            }
        }
    }
}
