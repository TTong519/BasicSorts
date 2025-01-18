using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

namespace BasicSort
{
    internal class Program
    {
        public static int[] BubbleSort(int[] array)
        {
            bool abool = true;
            while (abool)
            {
                abool = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    int current = array[i];
                    int next = array[i + 1];
                    if (current > next)
                    {
                        array[i] = next;
                        array[i + 1] = current;
                        abool = true;
                    }
                }
            }
            return array;
        }

        public static int FindLeast(int[] array, int startIndex = 0)
        {
            int min = int.MaxValue;
            for (int i = startIndex; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int FindIndex(int number, int[] array, int startIndex = 0, int endIndex = -1)
        {
            if (endIndex == -1)
            {
                endIndex = array.Length;
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                if (array[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min = FindLeast(array, i);
                int temp = array[i];
                int temp2 = FindIndex(min, array, i);
                array[temp2] = temp;
                array[i] = min;
                
            }
            return array;
        }

        public static int[] Swap(int[] array, int endindex, int startindex)
        {
            int temp = array[startindex];
            array[startindex] = array[endindex];
            array[endindex] = temp;
            return array;
        }
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int temp = FindLeast(array, i);
                for (int j = i - 1; j > 0; j--)
                {
                    if(array[j] > temp)
                }
            }
        }
        static void Main(string[] args)
        {
            SortTest(BubbleSort);
            SortTest(SelectionSort);
        }

        public static void SortTest(Func<int[], int[]> sort)
        {
            Random randy = new Random();
            for (int i = 0; i < 100; i++)
            {
                int[] ints = new int[100];
                for (int j = 0; j < 100; j++)
                {
                    ints[j] = randy.Next(1000);
                }

                sort(ints);

                for (int j = 0; j < 99; j++)
                {
                    if (ints[j] > ints[j + 1])
                    {
                        throw new Exception("you suck lol");
                    }
                }
            }
        }
    }
}
