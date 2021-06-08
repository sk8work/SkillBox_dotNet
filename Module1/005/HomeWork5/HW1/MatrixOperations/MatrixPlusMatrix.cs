using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class MatrixPlusMatrix
    {
        int[,] startMatrix1;
        int[,] startMatrix2;
        int[,] resultMatrix;

        int Rows { get; set; }
        int Cols { get; set; }

        public MatrixPlusMatrix()
        {
            Console.WriteLine();

            GetMatrixes();

            PrintMatrix(startMatrix1);

            PrintLine();

            PrintMatrix(startMatrix2);

            resultMatrix = GetResultMatrix(startMatrix1, startMatrix2);

            PrintLine();

            Console.WriteLine("Итоговая матрица: ");
            PrintMatrix(resultMatrix);
        }

        /// <summary>
        /// Печатает разделительную линию
        /// </summary>
        private static void PrintLine()
        {
            Console.WriteLine(new string('*', 10));
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
        /// Получаем итоговую матрицу сложением элементов матриц
        /// </summary>
        private int[,] GetResultMatrix(int[,] arr1, int[,] arr2)
        {
            int rows = arr1.GetLength(0);
            int cols = arr1.GetLength(1);

            int[,] resultMatrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultMatrix[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            return resultMatrix;
        }

        /// <summary>
        /// Получаем стартовую 2D матрицу, используя конструктор класса CreateMatrix
        /// </summary>
        /// <returns>2D матрица</returns>
        private void GetMatrixes()
        {
            CreateMatrix createMatrix = new CreateMatrix();
            createMatrix.Get2DMatrixSize();
            startMatrix1 = createMatrix.Fill2DMatrix();
            startMatrix2 = createMatrix.Fill2DMatrix();

            Rows = createMatrix.Rows;
            Cols = createMatrix.Cols;
        }
    }
}
