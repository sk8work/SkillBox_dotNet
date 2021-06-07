using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW4
{
    class CheckProgression
    {
        int count = 100;
        public CheckProgression()
        {
            for (int i = 0; i < count; i++)
            {
                CreateArray createArray = new CreateArray();
                Sleep();
                Console.WriteLine($"Исходный сгенерированный массив №{i+1}: ");
                PrintArr(createArray.Arr);
                PrintString();
            }
        }

        /// <summary>
        /// Задержка по времени 1с
        /// </summary>
        private void Sleep()
        {
            Thread.Sleep(100);
        }

        /// <summary>
        /// Печать массива в консоль
        /// </summary>
        /// <param name="arr">Arr</param>
        public void PrintArr(params int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write($"{i, -5}");
            }
            Console.WriteLine();
        }
        
        /// <summary>
        /// Проверяет, является ли массив арифметической прогрессией
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public bool IsArrAriphmeticProgression(int[] arr)
        {
            bool isTrue = false;


            return isTrue;
        }

        /// <summary>
        /// Проверяет, является ли массив геометрической прогрессией
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public bool IsArrGometricProgression(int[] arr)
        {
            bool isTrue = false;


            return isTrue;
        }

        public void PrintString()
        {
            Console.WriteLine(new string('*', 50));
        }
    }
}
