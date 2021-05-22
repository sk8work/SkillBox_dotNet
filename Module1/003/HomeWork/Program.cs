using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.PlayGame();

            // Delay
            Console.ReadKey();
        }
    }
}
