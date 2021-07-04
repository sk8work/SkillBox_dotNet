using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class UserInterface
    {
        bool start = true;
        /// <summary>
        /// Запуск программы
        /// </summary>
        /// 

        public UserInterface()
        {
            StartWhileTrue();
        }

        private void StartWhileTrue()
        {
            while (start)
            {
                Menu();

                string userChoice = GetUserChoice();

                SwitchMenu(userChoice);
            }
        }

        /// <summary>
        /// Переключатель меню
        /// </summary>
        /// <param name="userChoice"></param>
        private void SwitchMenu(string userChoice)
        {
            switch (userChoice)
            {
                case "1":
                    Console.WriteLine("Вы нажали 1 - Умножение матрицы на число");
                    break;
                case "2":
                    Console.WriteLine("Вы нажали 2 - Сложение двух матриц");
                    break;
                case "3":
                    Console.WriteLine("Вы нажали 3 - Вычитание одной матрицы из другой");
                    break;
                case "4":
                    Console.WriteLine("Вы нажали 4 - Перемножение матриц");
                    break;
                case "exit":
                    Console.WriteLine("До новых встреч!");
                    start = false;
                    break;
                default:
                    Console.WriteLine("Bad operator");
                    break;
            }
        }

        /// <summary>
        /// Выбор пункта меню
        /// </summary>
        /// <returns></returns>
        private static string GetUserChoice()
        {
            string userChoice = "";
            userChoice = Console.ReadLine();
            return userChoice;
        }

        /// <summary>
        /// Печать меню
        /// </summary>
        private static void Menu()
        {
            Console.WriteLine(new string('*', 50));
            Console.WriteLine("Выберите режим работы: \n" +
                "1 - Показать только кол-во групп\n" +
                "2 - Выполнить алгоритм подсчета групп чисел методом перебора значений\n" +
                "с последующей архивацией или сохранением в файл\n" +
                "Требуется мощный процессор. Миллиард не обработает\n" +
                "3 - Быстрый алгоритм, не требует большого объема памяти.\n" +
                "Возможно обработает Миллиард значений. Но нужен мощный процессор");
        }
    }
}
