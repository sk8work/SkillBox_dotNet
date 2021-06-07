using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW4
{
    class CreateArray
    {
        Random r = new Random();
        public int N { get; set; }
        public int[] Arr { get; set; }

        int minArrInt = 0;
        int maxArrInt = 100;


        /// <summary>
        /// Конструктор по-умолчанию. Создает массив из случайных N-элементов, заполненный случайными числами от minArrInt = 0, до maxArrInt = 100 включительно
        /// </summary>
        public CreateArray()
        {
            GetArrSize();
            Arr = GetArr(minArrInt, maxArrInt + 1);
        }

        /// <summary>
        /// Получаем массив, заполненный случайными значениями
        /// </summary>
        /// <param name="min">MinArrInt</param>
        /// <param name="max">MaxArrInt</param>
        /// <returns></returns>
        private int[] GetArr(int min, int max)
        {
            int[] newArr = new int[N];
            for (int i = 0; i < N; i++)
            {
                newArr[i] = r.Next(min, max);
            }
            return newArr;
        }

        /// <summary>
        /// Получаем размер массива
        /// </summary>
        private void GetArrSize()
        {
            Console.WriteLine("Определяем размер массива случайным образом от 3 до 20 элементов включительно");
            for (int i = 0; i < 5; i++)
            {
                
            }
            N = r.Next(3, 21);
        }

        
    }
}
