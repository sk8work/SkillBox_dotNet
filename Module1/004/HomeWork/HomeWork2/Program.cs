// Выведите на экран треугольник Паскаля.

using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывести на экран треугольник Паскаля");

            int row, cellWidth;
            int[][] PascaleTriangleJaggedArray;
            FillPascaleTriangle(out row, out cellWidth, out PascaleTriangleJaggedArray);

            PrintPascale(row, cellWidth, PascaleTriangleJaggedArray);

            // Delay
            Console.ReadKey();
        }

        private static void FillPascaleTriangle(out int row, out int cellWidth, out int[][] PascaleTriangleJaggedArray)
        {
            Console.Write("Введите размер треугольника: ");
            row = Convert.ToInt32(Console.ReadLine());
            //int row = 6;
            cellWidth = 4;
            PascaleTriangleJaggedArray = new int[row][];
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
        }

        private static void PrintPascale(int row, int cellWidth, int[][] PascaleTriangleJaggedArray)
        {
            int col = cellWidth * row;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < PascaleTriangleJaggedArray[i].Length; j++)
                {
                    Console.SetCursorPosition(col, Console.CursorTop);
                    col += cellWidth * 2;
                    Console.Write($"{PascaleTriangleJaggedArray[i][j],6}");
                }
                col = cellWidth * row - cellWidth * (i + 1);
                Console.WriteLine();
            }
        }

       
    }
}
