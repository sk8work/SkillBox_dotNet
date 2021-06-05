using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class MatrixMultMatrix
    {
        int[,] startMatrix1;
        int[,] startMatrix2;
        int[,] resultMatrix;

        int Rows { get; set; }
        int Cols { get; set; }

        public MatrixMultMatrix()
        {
            Console.WriteLine();

            startMatrix1 = GetMatrix();
            PrintMatrix(startMatrix1);
            PrintLine();

            startMatrix2 = GetMatrix();
            CheckLength();

            PrintMatrix(startMatrix2);
            PrintLine();

            GetResultMatrix();

            PrintLine();

            Console.WriteLine("Итоговая матрица: ");
            PrintMatrix(resultMatrix);
        }

        /// <summary>
        /// Срвнивает количество строк первой матрицы и количество столбцов второй
        /// </summary>
        private void CheckLength()
        {
            while (startMatrix1.GetLength(0) != startMatrix2.GetLength(1))
            {
                Console.WriteLine("Вы ввели неверный размер второй матрицы. Попробуйте еще раз");
                startMatrix2 = GetMatrix();
            }
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
        /// Получаем итоговую матрицу перемножением двух матриц
        /// </summary>
        private void GetResultMatrix()
        {
            Rows = startMatrix1.GetLength(0);
            Cols = startMatrix2.GetLength(1);
            int tempRows = startMatrix2.GetLength(0);

            resultMatrix = new int[Rows, Cols];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < startMatrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < tempRows; k++)
                    {
                        resultMatrix[i, j] += startMatrix1[i, k] * startMatrix2[k, j];
                    }
                }
            }
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
    }
}
