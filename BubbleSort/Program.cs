using System.Data.SqlTypes;
using System.Runtime.InteropServices;

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
        public static int[] SelectionSort(int[] array)
        {

        }
        static void Main(string[] args)
        {
            BubbleSortTest(BubbleSort);
        }

        public static void BubbleSortTest(Func<int[], int[]> sort)
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
