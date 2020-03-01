using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            Console.WriteLine("请输入十个数：");
            for (int i = 0; i < 10; i++)
            {
                string s = Console.ReadLine();
                int x = int.Parse(s);
                num[i] = x;
            }

            int max = num[0];
            for (int n = 1; n < 10; n++)
            {
                if (max < num[n])
                    max = num[n];

            }
            Console.WriteLine("最大值是{0}", max);
            int min = num[0];

            for (int a = 1; a < 10; a++)
            {
                if (min > num[a])
                    min = num[a];
            }
            Console.WriteLine("最小值是{0}", min);
            int all = 0;
            for (int h = 0; h < 10; h++)
            {
                all = all + num[h];
            }
            double average = all / 10;
            Console.WriteLine("平均值是{0}", average);

            Console.ReadKey(false);
        }
    }
}