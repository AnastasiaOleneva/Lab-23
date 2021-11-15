using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab_23
{
    class Program
    {
        static void Factorial() 
        {
            
            int result = 1;
            for (int i = 1; i <=10; i++)
            {
                result *= i;
            }
            Thread.Sleep(1000);
            Console.WriteLine("Факториал числа равен {0}",result); ;
        
        
        }

        static void ForControl(int n)
        {
            for (int i = n; i < n + 10; i++)
            {
                Console.WriteLine($"Метод ForControl выводит счетчик {i}");
                Thread.Sleep(800);
            }
            Console.WriteLine("Метод ForControl закончил работу");


        }
        static void Main(string[] args)
        {
            FactorialAsync();
            ForControl(10);
            Console.WriteLine("Метод Main окончил работу");
            Console.ReadKey();

        }


        static async void FactorialAsync() 
        {
            Console.WriteLine("Метод FactorialAsync начал работу");
            await Task.Run(() => Factorial());
            Console.WriteLine("Метод FactorialAsync окончил работу");
        
        
        }


    }
}
