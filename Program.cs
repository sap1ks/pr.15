using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Генерируются 15 случайных целых чисел в интервале (-20, 30). Вывести эти числа и подсчитать количество положительных чисел.
/// </summary>
namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {          
            Func();
            Console.ReadKey();
        }
        static void Func()
        {
            Random rnd = new Random();
            int count = 0;
            for (int x = 1; x <= 15; x++)
            {
                int number = rnd.Next(-20, 30);
                if (number >= 0) 
                {
                    count++;
                }
                Console.WriteLine($"{x}-е число={number}");                
            }
            Console.WriteLine(count);
        }
        
    }
}
