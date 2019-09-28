using System;
using System.Linq;

namespace Blockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 25, 14, 32, 40, 8, 23, 2, 7 };

            arr = arr.Where(x => x > 14).OrderByDescending(x => x).ToArray();

            foreach (int x in arr)
            { 
                Console.WriteLine(x);
            }
        }
    }
}
