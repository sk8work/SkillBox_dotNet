using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class MatrixMinusMatrix
    {
        int[,] startMatrix1;
        int[,] startMatrix2;
        int[,] resultMatrix;

        int Rows { get; set; }
        int Cols { get; set; }

        public MatrixMinusMatrix()
        {
            Console.WriteLine();

            GetMatrixes();

            PrintMatrix(startMatrix1);

            PrintLine();

            PrintMatrix(startMatrix2);

            GetResultMatrix();

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
        /// Получаем итоговую матрицу вычитанием из каждого элемента матрицы заданного числа
        /// </summary>
        private void GetResultMatrix()
        {
            resultMatrix = new int[Rows, Cols];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    resultMatrix[i, j] = startMatrix1[i, j] - startMatrix2[i, j];
                }
            }
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
