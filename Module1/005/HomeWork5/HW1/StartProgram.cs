using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class StartProgram
    {
        bool start = true;

        public StartProgram()
        {
            StartWhileTrue();
        }

        /// <summary>
        /// Запуск программы
        /// </summary>
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
                    MultByNumber multByNumber = new MultByNumber();
                    break;
                case "2":
                    Console.WriteLine("Вы нажали 2 - Сложение двух матриц");
                    MatrixPlusMatrix matrixPlusMatrix = new MatrixPlusMatrix();
                    break;
                case "3":
                    Console.WriteLine("Вы нажали 3 - Вычитание одной матрицы из другой");
                    MatrixMinusMatrix matrixMinusMatrix = new MatrixMinusMatrix();
                    break;
                case "4":
                    Console.WriteLine("Вы нажали 4 - Перемножение матриц");
                    MatrixMultMatrix matrixMultMatrix = new MatrixMultMatrix();
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
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1 - Умножить матрицу на число");
            Console.WriteLine("2 - Сложить две матрицы");
            Console.WriteLine("3 - Вычитание матриц");
            Console.WriteLine("4 - Умножение матриц");
            Console.WriteLine("exit - Выход из программы");
        }
    }
}
