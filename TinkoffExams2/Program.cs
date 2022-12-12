using System;

namespace TinkoffExams2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse( Console.In.ReadLine());
            string facility = Console.In.ReadLine();
            string paint = Console.In.ReadLine();
            string []text = facility.Split(' ');
            int uglyCount = 0;
            int textCount = -1;
            foreach (string s in text) {
                textCount += s.Length+1;
                for (int i = textCount-s.Length+1; i < textCount-1; i++)
                {
                    if (paint[i] == paint[i - 1]) {
                        uglyCount++;
                        break;
                            };
                }
                    }
            Console.Out.WriteLine(uglyCount);
        }
    }
}
