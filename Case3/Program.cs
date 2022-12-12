using System;
using System.Collections.Generic;
using System.Linq;

namespace Case3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число для поиска");
            int a =int.Parse (Console.In.ReadLine());
            var dict = new Dictionary<int,string>();
            int m=0;
            int n=0;
            for (int i = 1; i <= a; i++)
            {
                m = i;
                n = a - i;
                for (int j = 1; j < (n * m + 1); j++)
                {
                    if (j % m == 0 && j % n == 0)
                    {
                        int nok = j;
                            string s = $"{m} {n}";
                           if(!dict.ContainsKey(nok)) dict.Add(nok, s);
                    }
                }
               
            }
            var dict1 = dict.OrderBy(p => p.Key);
            string result = dict1.First().Value;
            string[] results = result.Split(' ');
            int result1 = int.Parse(results[0]);
            int result2 = int.Parse(results[1]);
            Console.Out.WriteLine($"минимальные числа - {result1}  {result2}");
        }
    }
}
