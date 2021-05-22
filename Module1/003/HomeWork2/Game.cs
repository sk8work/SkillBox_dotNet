using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Game
    {
        /********** vars **********/

        int maxGuessNumber = 200;
        int minGessNumber = 20;

        readonly int minStep = 1;
        readonly int maxStep = 4;

        int guessNumber = 0;

        int maxPlayers = 10;
        int minPlayers = 2;

        int playerNums = 0;
        public int PlayerNums
        {
            get { return playerNums; }
            set { playerNums = value; }
        }

        public void NewGame()
        {

            PlayersCount();

            GuessNumber();

            string[] names = new string[PlayerNums];
            int[] steps = new int[PlayerNums];
            for (int i = 0; i < PlayerNums; i++)
            {
                Console.Write($"Введите имя для игрока №{i + 1}: ");
                Player player = new();
                player.NewPlayer();
                names[i] = player.Name;
                steps[i] = player.Steps;
            }

            int count = PlayerNums;

            while (guessNumber > 0)
            {
                for (int i = 0; i < PlayerNums; ++i)
                {
                    Console.WriteLine($"Ходит: {names[i]}");

                    int insertNum = 0;

                    while(insertNum == 0)
                    {
                        try
                        {
                            Console.Write("Введите число от 1 до 4: ");
                            insertNum = Convert.ToInt32(Console.ReadLine());
                            steps[i]++;
                        }
                        catch (FormatException)
                        {

                            Console.WriteLine("Вы ввели недопустимое значение. Попробуйте еще раз");
                            insertNum = 0;
                            continue;
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Вы ввели недопустимое значение. Попробуйте еще раз");
                            insertNum = 0;
                            continue;
                        }

                        if (insertNum > maxStep || insertNum < minStep)
                        {
                            Console.WriteLine("Вы ввели неверные данные. Ход переходит к следующему игроку, а ваше очко уходит в зрительный зал");
                            insertNum = 0;
                            break;
                        }
                    }
                    
                    guessNumber -= insertNum;

                    if (guessNumber == 0)
                    {
                        Console.WriteLine($"Победил игрок {names[i]} за {steps[i]} ходов");
                        break;
                    }

                    if (i == PlayerNums)
                    {
                        i = 0;
                        continue;
                    }
                    Console.WriteLine($"Новое число - {guessNumber}");
                }
            }
        }

        int PlayersCount()
        {
            while (PlayerNums < minPlayers || PlayerNums > maxPlayers)
            {
                Console.Write($"Введите количество игроков (от {minPlayers} до {maxPlayers}): ");
                try
                {
                    PlayerNums = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели неверные данные, попробуйте еще раз");
                    continue;
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("Вы ввели слишком большое число игроков, попробуйте еще раз");
                    continue;
                }

                if (PlayerNums < minPlayers || PlayerNums > maxPlayers)
                {
                    Console.WriteLine("Вы ввели число игроков вне диапазона, попробуйте еще раз");
                }
            }
            return PlayerNums;
        }

        int GuessNumber()
        {
            while (guessNumber < minGessNumber || guessNumber > maxGuessNumber)
            {
                Console.Write("Введите число (от 20 до 200): ");
                try
                {
                    guessNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Вы ввели неверные данные, попробуйте еще раз");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Вы ввели слишком большое число игроков, попробуйте еще раз");
                    continue;
                }

                if (guessNumber < minGessNumber || guessNumber > maxGuessNumber)
                {
                    Console.WriteLine("Вы ввели загадали число вне диапазона, попробуйте еще раз");
                }
            }

            return guessNumber;
        }
    }
}
