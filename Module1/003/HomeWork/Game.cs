using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Game
    {
        /**********  vars  **********/
        Random randNum = new Random();
        readonly int maxNum = 120;
        readonly int minNum = 12;
        readonly int minStep = 1;
        readonly int maxStep = 4;

        char startGame = 'y';

        public void PlayGame()
        {
            Console.WriteLine("Игра для двух игроков.");
            Console.WriteLine("Небходимо по-очереди вводить число, которое будет вычитаться из случайно сгенерированного в начале игры числа.");
            Console.WriteLine("Победит тот игрок, который сумеет привести его к 0.");
            Console.WriteLine("Можно вводить числа от 1 до 4");
            Console.WriteLine("Удачи!");


            while (startGame == 'y')
            {
                int player1vins = 0;
                int player2vins = 0;
                int player1Steps = 0;
                int player2Steps = 0;
                int count = 0;
                int insertNum;
                string firstPlayerName = "";
                Console.Write("Введите имя для первого игрока: ");
                firstPlayerName = Console.ReadLine();

                string secondPlayerName = "";
                Console.Write("Введите имя для второго игрока: ");
                secondPlayerName = Console.ReadLine();

                Console.WriteLine("/n" + new string('*', 50));
                int guessNum = randNum.Next(minNum, maxNum + 1);

                Console.WriteLine($"Итак, компьютер загадал число: {guessNum}");

                while (guessNum >= 0)
                {

                    if (count % 2 == 0)
                    {
                        ++player1Steps;
                        Console.Write($"Ходит {firstPlayerName}: ");
                    }
                    else
                    {
                        ++player2Steps;
                        Console.Write($"Ходит {secondPlayerName}: ");
                    }

                    insertNum = Convert.ToInt32(Console.ReadLine());
                    if (insertNum < minStep || insertNum > maxStep)
                    {
                        Console.WriteLine("Вы ввели неверное число. Ход переходит к следующему игроку");
                        insertNum = 0;
                        ++count;
                        continue;
                    }
                    else
                    {
                        guessNum -= insertNum;
                        Console.WriteLine($"Теперь чиcло =  {guessNum}");
                        if (guessNum == 0)
                        {
                            if (count % 2 == 0)
                            {
                                Console.WriteLine($"{firstPlayerName} победил за {player1Steps} шагов");
                                player1vins++;
                            }
                            else
                            {
                                Console.WriteLine($"{secondPlayerName} победил за {player2Steps} шагов");
                                player2vins++;
                            }
                            break;
                        }
                        if (guessNum < 0)
                        {
                            if (count % 2 == 0)
                            {
                                Console.WriteLine($"{secondPlayerName} победил за {player1Steps} шагов");
                                player1vins++;
                            }
                            else
                            {
                                Console.WriteLine($"{firstPlayerName} победил за {player2Steps} шагов");
                                player2vins++;
                            }
                            break;
                        }
                        count++;
                    }
                }

                Console.WriteLine("Хотите сыграть реванш? (y/n): ");
                startGame = Convert.ToChar(Console.ReadLine());

                if (startGame == 'y' || startGame == 'у')
                {
                    startGame = 'y';
                    continue;
                }
                else
                {
                    Console.WriteLine("Game Over");
                }
            }
        }
    }
}
