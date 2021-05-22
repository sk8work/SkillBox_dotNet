using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame startGame = new();
            startGame.PlayGame();

            // Delay
            Console.ReadKey();
        }
    }
}
