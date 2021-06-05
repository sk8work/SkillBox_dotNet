using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class CreateMatrix
    {
        Random r = new Random();
        public int Rows { get; set; }
        public int Cols { get; set; }


        public void Get2DMatrixSize()
        {
            Console.Write("Введите количество строк: ");
            Rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            Cols = Convert.ToInt32(Console.ReadLine());
        }

        public int[,] Fill2DMatrix()
        {
            int[,] matrix = new int[Rows, Cols];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    matrix[i, j] = this.r.Next(0, 11);
                }
            }
            return matrix;
        }
    }
}
