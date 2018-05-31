namespace SortingAndSearching
{
    using System;

    public class MergeSort<T> where T : IComparable<T>
    {
        private static T[] aux;

        public static void Sort(T[] arr)
        {
            aux = new T[arr.Length];
            Sort(arr, 0, arr.Length - 1);
        }

        private static void Sort(T[] arr, int lo, int hi)
        {
            if (lo >= hi) //only one element
            {
                return;
            }
            int mid = lo + (hi - lo) / 2;
            Sort(arr, lo, mid);
            Sort(arr, mid + 1, hi);
            Merge(arr, lo, mid, hi);
        }

        private static void Merge(T[] arr, int lo, int mid, int hi)
        {
            if (arr[mid].CompareTo(arr[mid + 1]) <= 0) //already sorted - highest left < smallest right
            {
                return;
            }
            for (int i = lo; i <= hi; i++) //copy all to aux so we can overwrite in the original
            {
                aux[i] = arr[i];
            }
            int left = lo;
            int right = mid + 1;
            for (int j = lo; j <= hi; j++)
            {
                if (left > mid) //we're done with the left elements
                {
                    arr[j] = aux[right];
                    right++;
                }
                else if (right > hi) //we're done with the right elements
                {
                    arr[j] = aux[left];
                    left++;
                }
                else if (aux[left].CompareTo(aux[right]) <= 0)
                {
                    arr[j] = aux[left];
                    left++;
                }
                else
                {
                    arr[j] = aux[right];
                    right++;
                }
            }
        }
    }
}
