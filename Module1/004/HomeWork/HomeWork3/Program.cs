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

            int rows_arr3_3 = arr3_3.GetLength(0);
            int cols_arr3_3 = arr3_3.GetLength(1);
            for (int i = 0; i < rows_arr3_3; i++)
            {
                for (int j = 0; j < cols_arr3_3; j++)
                {
                    Console.Write($"{arr3_3[i, j]}\t");
                }
                Console.WriteLine();
            }

            int mult = 5;

            Console.WriteLine($"Умножим матрицу на число {mult}: ");

            for (int i = 0; i < rows_arr3_3; i++)
            {
                for (int j = 0; j < cols_arr3_3; j++)
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

            int rows_arrA3_3 = arrA3_3.GetLength(0);
            int cols_arrA3_3 = arrA3_3.GetLength(1);
            for (int i = 0; i < rows_arrA3_3; i++)
            {
                for (int j = 0; j < cols_arrA3_3; j++)
                {
                    Console.Write($"{arrA3_3[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Матрица B3x3");

            int[,] arrB3_3 = new int[3, 3] { { 3, 4, 5 }, { 6, 7, 8 }, { 9, 10, 11 } };

            int rows_arrB3_3 = arrB3_3.GetLength(0);
            int cols_arrB3_3 = arrB3_3.GetLength(1);

            for (int i = 0; i < rows_arrB3_3; i++)
            {
                for (int j = 0; j < cols_arrB3_3; j++)
                {
                    Console.Write($"{arrB3_3[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сложим матрицы A и B");

            if ((rows_arrA3_3 == rows_arrB3_3) && (cols_arrA3_3 == cols_arrB3_3))
            {
                for (int i = 0; i < rows_arrA3_3; i++)
                {
                    for (int j = 0; j < cols_arrA3_3; j++)
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

            int rows_arrC3_3 = arrC3_3.GetLength(0);
            int cols_arrC3_3 = arrC3_3.GetLength(1);

            for (int i = 0; i < rows_arrC3_3; i++)
            {
                for (int j = 0; j < cols_arrC3_3; j++)
                {
                    Console.Write($"{arrC3_3[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Матрица D3x3");

            int[,] arrD3_3 = new int[3, 3] { { 1, 4, 5 }, { 2, 7, 0 }, { 0, 5, 8 } };

            int rows_arrD3_3 = arrD3_3.GetLength(0);
            int cols_arrD3_3 = arrD3_3.GetLength(1);

            for (int i = 0; i < rows_arrD3_3; i++)
            {
                for (int j = 0; j < cols_arrD3_3; j++)
                {
                    Console.Write($"{arrD3_3[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Вычтем матрицы C и D");

            if ((rows_arrC3_3 == rows_arrD3_3) && (cols_arrC3_3 == cols_arrD3_3))
            {
                for (int i = 0; i < rows_arrC3_3; i++)
                {
                    for (int j = 0; j < cols_arrC3_3; j++)
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
            int[,] arrE = new int[3, 2] { { 1, 2 }, { 4, 5 }, { 7, 8 } };

            int rows_arrE = arrE.GetLength(0);
            int cols_arrE = arrE.GetLength(1);

            for (int i = 0; i < rows_arrE; i++)
            {
                for (int j = 0; j < cols_arrE; j++)
                {
                    Console.Write($"{arrE[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Матрица F 2x4");
            int[,] arrF = new int[2, 4] { { 4, 5, 3, 2 }, { 7, 8, 5, 1 } };

            int rows_arrF = arrF.GetLength(0);
            int cols_arrF = arrF.GetLength(1);

            for (int i = 0; i < rows_arrF; i++)
            {
                for (int j = 0; j < cols_arrF; j++)
                {
                    Console.Write($"{arrF[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Умножим матрицу E на матрицу F");

            for (int i = 0; i < rows_arrF; i++)
            {
                for (int j = 0; j < cols_arrF; j++)
                {
                    int res = 0;
                    for (var k = 0; k < cols_arrE; k++)
                    {
                        res += arrE[i, k] * arrF[k, j];
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
