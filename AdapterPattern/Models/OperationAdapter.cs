namespace AdapterPattern.Models
{
    using Interfaces;
    class OperationAdapter : IScoreOperation
    {
        private QuickSortClass sortObj;
        private BinarySearchClass searchObj;

        public OperationAdapter()
        {
            sortObj = new QuickSortClass();
            searchObj = new BinarySearchClass();
        }

        public int Search(int[] array, int key)
        {
            return searchObj.BinarySearch(array, key);
        }

        public int[] Sort(int[] array)
        {
            return sortObj.QuickSort(array);
        }
    }
}
