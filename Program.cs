using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Генерируются 10 случайных целых чисел в интервале (-40, 40). Вывести эти числа.
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
            for (int x = 1; x <= 10; x++)
            {
                int number = rnd.Next(-40, 40);
                Console.WriteLine($"{x}-е число={number}");
                

                
            }
        }
        
    }
}
