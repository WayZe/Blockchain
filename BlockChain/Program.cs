using System;

namespace Blockchain
{
    class Program
    {
        private const int N = 0;
        private static int[] arr;

        static void Main(string[] args)
        {
            arr = new int[] { 25, 14, 32, 40, 8, 23, 2, 7 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int tmpParam = arr[j];

                        arr[j] = arr[j + 1];

                        arr[j + 1] = tmpParam;
                    }
                }
            }

            foreach (int x in arr)
            {
                if (x > 14)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
