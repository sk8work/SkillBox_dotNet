using System;

namespace HomeWork3
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
