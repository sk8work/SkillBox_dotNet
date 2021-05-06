/*Задание 1, Задание2, Задание3,
Задание 4, Задание 5*/


using System;

namespace _001_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees emp1 = new Employees();
            emp1.DisplayInfoSimple();

            Employees emp2 = new Employees();
            emp2.DisplayInfoFormated();

            Employees emp3 = new Employees();
            emp3.DisplayInfoInterpolated();


            // Delay
            Console.ReadKey();
        }
    }
}
