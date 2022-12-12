using System;

namespace TinkoffExams2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите количество букв в названии отдела");
            int count = int.Parse( Console.In.ReadLine());
            string facility="";
            string check = "";
            while (check.Length != count)
            {
                Console.WriteLine($"введите название отдела из {count} букв");
                string s = Console.In.ReadLine();
                string[] words = s.Split(' ');
                check =string.Concat(words);
                if (check.Length == count)
                    facility += s;
            }
            string paint = "";
            while (paint.Length != count)
            {
                Console.WriteLine($"введите идею из {count} букв");
                paint = Console.In.ReadLine();
                for (int i = 0; i < paint.Length; i++)
                {
                    if (paint[i].Equals("Y")|| paint[i].Equals("B"))
                    {
                        Console.WriteLine("допустимы только символы Y и B");
                        paint = "";
                    }    
                }
            }
            string []text = facility.Split(' ');
            int uglyCount = 0;
            int textCount = -1;
            foreach (string s in text)
            {
                textCount += s.Length+1;
                for (int i = textCount-s.Length+1; i < textCount-1; i++)
                {
                    if (paint[i] == paint[i - 1])
                    {
                        uglyCount++;
                        break;
                    };
                }
            }
            Console.Out.WriteLine(uglyCount);
        }
    }
}
