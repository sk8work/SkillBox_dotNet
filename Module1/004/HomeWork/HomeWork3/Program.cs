//Реализуйте:
//умножение матрицы на число,
//сложение и вычитание матриц,
//умножение двух матриц.

using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {

            #region умножение матрицы на число
            Console.WriteLine("Умножение матрицы на число");
            Console.WriteLine("На число может быть умножена любая матрица");
            Console.WriteLine("Пример: ");
            Console.WriteLine("Матрица 3x3");
            int[,] arr3_3 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < arr3_3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3_3.GetLength(1); j++)
                {
                    Console.Write($"{arr3_3[i, j]}\t");
                }
                Console.WriteLine();
            }

            int mult = 5;

            Console.WriteLine($"Умножим матрицу на число {mult}: ");

            for (int i = 0; i < arr3_3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3_3.GetLength(1); j++)
                {
                    arr3_3[i, j] *= mult;
                    Console.Write($"{arr3_3[i, j]}\t");
                }
                Console.WriteLine();
            }

            #endregion

            PrintLine();

            #region сложение матриц
            Console.WriteLine("Сложение матриц");
            Console.WriteLine("Две матрицы A и B можно складывать(или вычитать) тогда и только тогда, когда они имеют одинаковый размер m x n.");
            Console.WriteLine("Пример: ");
            Console.WriteLine("Матрица A 3x3");

            int[,] arrA3_3 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < arrA3_3.GetLength(0); i++)
            {
                for (int j = 0; j < arrA3_3.GetLength(1); j++)
                {
                    Console.Write($"{arrA3_3[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Матрица B3x3");

            int[,] arrB3_3 = new int[3, 3] { { 3, 4, 5 }, { 6, 7, 8 }, { 9, 10, 11 } };

            for (int i = 0; i < arrB3_3.GetLength(0); i++)
            {
                for (int j = 0; j < arrB3_3.GetLength(1); j++)
                {
                    Console.Write($"{arrB3_3[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сложим матрицы A и B");

            if ((arrA3_3.GetLength(0) == arrB3_3.GetLength(0)) && (arrA3_3.GetLength(1) == arrB3_3.GetLength(1)))
            {
                for (int i = 0; i < arrA3_3.GetLength(0); i++)
                {
                    for (int j = 0; j < arrA3_3.GetLength(1); j++)
                    {
                        arrA3_3[i, j] = arrA3_3[i, j] + arrB3_3[i, j];
                        Console.Write($"{arrA3_3[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }

            #endregion

            PrintLine();

            #region вычитание матриц

            Console.WriteLine("Вычитание матриц");
            Console.WriteLine("Две матрицы A и B можно складывать(или вычитать) тогда и только тогда, когда они имеют одинаковый размер m x n.");
            Console.WriteLine("Пример: ");
            Console.WriteLine("Матрица С 3x3");

            int[,] arrC3_3 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < arrC3_3.GetLength(0); i++)
            {
                for (int j = 0; j < arrC3_3.GetLength(1); j++)
                {
                    Console.Write($"{arrC3_3[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Матрица D3x3");

            int[,] arrD3_3 = new int[3, 3] { { 1, 4, 5 }, { 2, 7, 0 }, { 0, 5, 8 } };

            for (int i = 0; i < arrD3_3.GetLength(0); i++)
            {
                for (int j = 0; j < arrD3_3.GetLength(1); j++)
                {
                    Console.Write($"{arrD3_3[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Вычтем матрицы C и D");

            if ((arrC3_3.GetLength(0) == arrD3_3.GetLength(0)) && (arrC3_3.GetLength(1) == arrD3_3.GetLength(1)))
            {
                for (int i = 0; i < arrC3_3.GetLength(0); i++)
                {
                    for (int j = 0; j < arrC3_3.GetLength(1); j++)
                    {
                        arrC3_3[i, j] = arrC3_3[i, j] - arrD3_3[i, j];
                        Console.Write($"{arrC3_3[i, j]}\t");
                    }
                    Console.WriteLine();
                }
            }

            #endregion

            PrintLine();

            #region умножение двух матриц
            Console.WriteLine("Умножение матриц");
            Console.WriteLine("Произведение матриц A и B существует тогда и только тогда, когда число столбцов в первой матрице равно числу строк во второй");
            Console.WriteLine("Пример: ");

            Console.WriteLine("Матрица E 3x2");
            int[,] arrE3_3 = new int[3, 2] { { 1, 2 }, { 4, 5 }, { 7, 8 } };

            for (int i = 0; i < arrE3_3.GetLength(0); i++)
            {
                for (int j = 0; j < arrE3_3.GetLength(1); j++)
                {
                    Console.Write($"{arrE3_3[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Матрица F 2x4");
            int[,] arrF3_3 = new int[2, 4] { { 4, 5, 3, 2 }, { 7, 8, 5, 1 } };

            for (int i = 0; i < arrF3_3.GetLength(0); i++)
            {
                for (int j = 0; j < arrF3_3.GetLength(1); j++)
                {
                    Console.Write($"{arrF3_3[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Умножим матрицу E на матрицу F");

            for (int i = 0; i < arrE3_3.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arrF3_3.GetUpperBound(1) + 1; j++)
                {
                    int res = 0;
                    for (var k = 0; k < arrE3_3.GetUpperBound(1) + 1; k++)
                    {
                        res += arrE3_3[i, k] * arrF3_3[k, j];
                    }
                    Console.Write($"{res}\t");
                }
                Console.WriteLine();
            }

            #endregion

            PrintLine();

            // Delay
            Console.ReadKey();

            void PrintLine()
            {
                Console.WriteLine();
                Console.WriteLine(new string('*', 50));
                Console.WriteLine();
            }
        }


    }
}
