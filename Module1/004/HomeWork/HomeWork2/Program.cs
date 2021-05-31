// Выведите на экран треугольник Паскаля.

using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывести на экран треугольник Паскаля");


            #region Создадим Jagged Array и заполним его значениями
            Console.Write("Введите размер треугольника: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] PascaleTriangleJaggedArray = new int[n][];
            PascaleTriangleJaggedArray[0] = new int[] { 1 };

            for (int i = 1; i < PascaleTriangleJaggedArray.Length; i++)
            {
                PascaleTriangleJaggedArray[i] = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                        PascaleTriangleJaggedArray[i][j] = 1;
                    else
                    {
                        PascaleTriangleJaggedArray[i][j] = PascaleTriangleJaggedArray[i - 1][j - 1] + PascaleTriangleJaggedArray[i - 1][j];
                    }
                }
            }

            #endregion

            #region Вывод треугольника Паскаля
            // Выясним длину самой длинной (нижней) последовательности
            string mostWidthString = string.Join(" ", PascaleTriangleJaggedArray[n - 1]);
            int stringLength = mostWidthString.Length;

            for (int i = 0; i < PascaleTriangleJaggedArray.Length; i++)
            {

                Console.SetCursorPosition((mostWidthString.Length - string.Join(" ", PascaleTriangleJaggedArray[i]).Length) /2, Console.CursorTop);
                Console.Write( string.Join(" ", PascaleTriangleJaggedArray[i]));
                Console.WriteLine();
            }
            #endregion

            // Delay
            Console.ReadKey();
        }
    }
}
