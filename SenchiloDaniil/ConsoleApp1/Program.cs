using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int a;
            string i = Console.ReadLine();
            if (Int32.TryParse(i, out a))
            {
                
               
                if (a > 7)
                {
                    Console.WriteLine("Привет");
                }
                else
                {
                    Console.WriteLine(" Ошибка, введено число меньше 7");
                }
                
            }
            else {
                Console.WriteLine("Некоректный ввод");
            }
        }
    }
}
