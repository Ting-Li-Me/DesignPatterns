namespace AdapterPattern.Models
{
    class QuickSortClass
    {
        public int[] QuickSort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
            return array;
        }

        public void Sort(int[] array, int l, int r)
        {
           
            if (l < r)
            {
                int pivot = Partition(array, l, r);
                if (pivot>1)
                {
                    Sort(array, l, pivot - 1);
                }
                if (pivot + 1 < r)
                {
                    Sort(array, pivot + 1, r);
                }
            }
        }

        public int Partition(int[] arr, int l, int r)
        {
            int pivot = arr[l];
            while (true)
            {

                while (arr[l] < pivot)
                {
                    ++l;
                }

                while (arr[r] > pivot)
                {
                    r--;
                }

                if (l < r)
                {
                    if (arr[l] == arr[r]) return r;

                    int temp = arr[l];
                    arr[l] = arr[r];
                    arr[r] = temp;


                }
                else
                {
                    return r;
                }
            }
        }

     
    }
}
