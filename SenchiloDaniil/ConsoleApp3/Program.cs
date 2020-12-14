using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string i;
            
            while (true)
            {



                i = Console.ReadLine();
                
                if (i == "Вячеслав")
                {
                    Console.WriteLine("Привет, " + i);
                }
                else
                    Console.WriteLine("Нет такого имени");
                if (i == "стоп")
                {
                    break;  
                }
            }
            


            Console.ReadKey();
        }
    }
}
