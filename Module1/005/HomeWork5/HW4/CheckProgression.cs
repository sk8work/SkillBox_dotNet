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
        int count = 10;
        public CheckProgression()
        {
            for (int i = 0; i < count; i++)
            {
                CreateArray createArray = new CreateArray();
                Sleep();
                Console.WriteLine($"Исходный сгенерированный массив №{i + 1}: ");
                PrintArr(createArray.Arr);
                Console.WriteLine($"Является ли массив числовой последовательнстью и арифметической прогрессией: {IsArrAriphmeticProgression(createArray.Arr)}");
                Console.WriteLine($"Является ли массив числовой последовательнстью и геометрической прогрессией: {IsArrGometricProgression(createArray.Arr)}");
                PrintString();
            }

            // Примеры, показывающие заранее известный результат (контрольные примеры)
            //Console.WriteLine($"Является ли массив числовой последовательнстью и арифметической прогрессией: {IsArrAriphmeticProgression(new int[] { 1,0,0})}"); //false
            //Console.WriteLine($"Является ли массив числовой последовательнстью и геометрической прогрессией: {IsArrGometricProgression(new int[] { 1, 2, 3, 4, 5, 6 })}"); //false

            //Console.WriteLine($"Является ли массив числовой последовательнстью и арифметической прогрессией: {IsArrAriphmeticProgression(new int[] { 1, 2, 4, 8, 16, 32 })}"); //false
            //Console.WriteLine($"Является ли массив числовой последовательнстью и геометрической прогрессией: {IsArrGometricProgression(new int[] { 1, 2, 4, 8, 16, 32 })}"); // true

        }

        /// <summary>
        /// Задержка по времени 1с
        /// </summary>
        private void Sleep()
        {
            Thread.Sleep(300);
        }

        /// <summary>
        /// Печать массива в консоль
        /// </summary>
        /// <param name="arr">Arr</param>
        public void PrintArr(params int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write($"{i,-5}");
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
            // bool isTrue = true;
            int length = arr.Length;

            if (length < 3)
                return false;

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        return false;
                    }
                }
            }

            for (int i = 1; i < length - 1; i++)
            {
                if (arr[i] != (arr[i - 1] + arr[i + 1]) / 2)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Проверяет, является ли массив геометрической прогрессией
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public bool IsArrGometricProgression(int[] arr)
        {
            int length = arr.Length;

            if (length < 3)
                return false;

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        return false;
                    }
                }
            }

            for (int i = 1; i < length - 1; i++)
            {
                if (arr[i] * arr[i] != (arr[i - 1] * arr[i + 1]))
                {
                    return false;
                }
            }
            return true;
        }

        public void PrintString()
        {
            Console.WriteLine(new string('*', 50));
        }
    }
}
