using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Одна штука некоторого товара стоит 20,4 руб. Напечатать таблицу стоимости 2, 3, ..., 20 штук этого товара.
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