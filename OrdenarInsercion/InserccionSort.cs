using System;

namespace OrdenarInsercion
{
    public static class InserccionSort
    {
        public static void SortInsert<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                var j = i;

                while (j > 0 && array[j].CompareTo(array[j-1]) < 0)
                {
                    Swap(array , j-1 , j );
                    j--;
                }
            }
        }

        private static void Swap<T>(T[] array, int first, int second)
        {
            var temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}