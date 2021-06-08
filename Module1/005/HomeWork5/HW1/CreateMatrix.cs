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
        bool isTrue = false;

        public void Get2DMatrixSize()
        {
            while(!isTrue)
            {
                Console.Write("Введите количество строк: ");
                try
                {
                    Rows = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели неверные данные, попробуйте еще раз");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Вы ввели слишком большое значение, попробуйте еще раз");
                    continue;
                }
                if (Rows < 0)
                {
                    Console.WriteLine("Матриц с отрицательным числом строк не существует!! Попробуйте еще раз.");
                    continue;
                }
                isTrue = true;
            }


            isTrue = false;
            while (!isTrue)
            {
                Console.Write("Введите количество столбцов: ");
                Cols = Convert.ToInt32(Console.ReadLine());
                if (Rows < 0)
                {
                    Console.WriteLine("Матриц с отрицательным числом столбцов не существует!! Попробуйте еще раз.");
                    continue;
                }
                isTrue = true;
            }
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
