using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class MultByNumber
    {
        int N { get; set; }
        int[,] startMatrix;
        int[,] resultMatrix;

        int Rows { get; set; }
        int Cols { get; set; }

        public MultByNumber()
        {
            startMatrix = GetMatrix();

            PrintMatrix(startMatrix);

            N = GetNumber();

            resultMatrix = GetResultMatrix(N, startMatrix);

            PrintMatrix(resultMatrix);
        }

        /// <summary>
        /// Принимает 2D матрицу в качестве параметра и выводит ее в консоль
        /// </summary>
        /// <param name="arr">2D матрица</param>
        private void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Console.Write($"{arr[i, j],10}");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Получаем итоговую матрицу умножением стартовой матрицы на число
        /// </summary>
        private int[,] GetResultMatrix(int n, int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    result[i, j] = arr[i, j] * n;
                }
            }
            return result;
        }

        /// <summary>
        /// Получаем стартовую 2D матрицу, используя конструктор класса CreateMatrix
        /// </summary>
        /// <returns>2D матрица</returns>
        private int[,] GetMatrix()
        {
            CreateMatrix createMatrix = new CreateMatrix();
            createMatrix.Get2DMatrixSize();
            int[,] newMatrix = createMatrix.Fill2DMatrix();

            Rows = createMatrix.Rows;
            Cols = createMatrix.Cols;

            return newMatrix;
        }

        /// <summary>
        /// Получаем значение мультипликатора с консоли
        /// </summary>
        private int GetNumber()
        {
            Console.Write("На какое число умножить матрицу?: ");
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }
    }
}
