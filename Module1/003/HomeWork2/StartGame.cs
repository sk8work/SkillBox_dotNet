using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class StartGame
    {
        bool isStartGame = true;

        public bool IsStartGame
        {
            get { return isStartGame; }
            set { isStartGame = value; }
        }
        public char BoolAnswer { get; set; }

        public void PlayGame()
        {
            while (isStartGame == true)
            {
                Console.WriteLine(new string('*', 100));
                Console.WriteLine("\nНебходимо по-очереди вводить число, которое будет вычитаться из выбранного в начале игры числа.");
                Console.WriteLine("Победит тот игрок, который сумеет привести его к 0.");
                Console.WriteLine("Можно вводить числа от 1 до 4");
                Console.WriteLine("Удачи!");
                Game game = new();
                game.NewGame();

                Console.Write("Хотите сыграть реванш? (y/n): ");
                BoolAnswer = Convert.ToChar(Console.ReadLine());

                if (BoolAnswer == 'y' || BoolAnswer == 'Y' || BoolAnswer == 'у' || BoolAnswer == 'У')
                {
                    IsStartGame = true;
                    continue;
                }
                else
                    Console.WriteLine(new string('*', 50));
                    Console.WriteLine("Game Over");
                IsStartGame = false;
            }
        }

    }
}
