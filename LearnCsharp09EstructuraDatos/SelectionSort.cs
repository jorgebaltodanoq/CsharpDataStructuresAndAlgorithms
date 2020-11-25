using System;

namespace LearnCsharp09EstructuraDatos
{
    public static class SelectionSort
    {
        public static void Sort<T>(T [] array) where T : IComparable
        {
            for (var i = 0; i < array.Length; i++)
            {
                var minIndex = i;
                var minValue =array[i];

                for (var m= i+1; m < array.Length; m++)
                {
                    if (array[m].CompareTo(minValue) < 0)
                    {
                        minIndex = m;
                        minValue = array[m];

                        Swap(array, i, minIndex);
                    }
                }
            }
        }

        private static void Swap<T>(T [] array, int first, int second)
        {
            var temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
