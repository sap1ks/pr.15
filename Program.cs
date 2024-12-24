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
            for (int x = 1; x <= 10; x++)
            {
                int number = rnd.Next(-40, 40);
                Console.WriteLine($"{x}-е число={number}");
                

                
            }
        }
        
    }
}