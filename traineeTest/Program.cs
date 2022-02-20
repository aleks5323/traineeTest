using System;
using System.Collections.Generic;

namespace traineeTest
{
    class Program
    {

        public static int[][] action(int n)
        {
            int v = 0;
            Random rnd = new Random();

            HashSet<int> arrLengths = new HashSet<int>();
            int[][] resArr = new int[n][];

            do
            {
                arrLengths.Add(rnd.Next(2, n * 2));
            } while (arrLengths.Count != n);

            foreach (int i in arrLengths)
            {
                resArr[v] = new int[i];
                for (int j = 0; j < i; j++)
                    resArr[v][j] = rnd.Next(1000);
                v++;
            }

            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                    Array.Sort(resArr[i], (x, y) => y.CompareTo(x));
                else
                    Array.Sort(resArr[i]);
            }

            return resArr;
        }

        static void Main(string[] args)
        {
            int n = 0;

            Console.Write("What is N: ");
            n = Convert.ToInt32(Console.ReadLine());
            action(n);
        }
    }
}