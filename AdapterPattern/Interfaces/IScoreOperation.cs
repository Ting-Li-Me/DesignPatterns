namespace AdapterPattern.Interfaces
{
    interface IScoreOperation
    {
        int[] Sort(int[] array);
        int Search(int[] array, int key);
    }
}
