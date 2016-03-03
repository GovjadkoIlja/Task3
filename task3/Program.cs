// Задание 3 с сайта олимпиадных задач
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i;
            int j;
            int t;
            int a;
            int s = 0;
            n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];
            for (i = 0; i < n; i++)
            {
                mass[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i=0; i<n; i++)
                for (j = 0; j < n - i-1; j++)
                    if (mass[j] > mass[j + 1])
                    {
                        t=mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = t;
                    }
            for (i = 0; i <= n / 2; i++)
                s += mass[i]/2+1;
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
