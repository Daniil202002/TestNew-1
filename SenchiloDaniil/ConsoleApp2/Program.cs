using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array_from_set_user_parameter5
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ведите количество элементов массива");
            int n;
            string a = Console.ReadLine();
            if (Int32.TryParse(a, out n))
            {
                int[] Nabor = new int[n];
                int count = 0;
                List<int> chisla = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Введите " + (i + 1) + "-е значение");
                    Nabor[i] = Convert.ToInt32(Console.ReadLine());
                }
                foreach (int el in Nabor)
                {
                    if (el % 3 == 0)
                    {
                        chisla.Add(el);
                        count++;
                    }
                }
                if (count > 0)
                {
                    foreach (int el1 in chisla)
                    {
                        Console.WriteLine("Число кратное трём: " + el1);
                    }
                }
                else
                {
                    Console.WriteLine("Нет чисел кратных трём");
                }
            }
            else
            {
                Console.WriteLine("Некоректный ввод! Введите число.");
            }
        }
    }
}
