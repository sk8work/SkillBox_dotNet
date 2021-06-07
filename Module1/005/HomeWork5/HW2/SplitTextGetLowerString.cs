using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class SplitTextGetLowerString
    {
        public string InnerString { get; set; }
        string[] SortedString { get; set; }

        public SplitTextGetLowerString()
        {
            InnerString = GetString();
            PrintLine();

            Console.WriteLine("Строка, содержащая слово с минисальной длиной");
            PrintString(GetMinString(GetSplittedString(InnerString)));
            PrintLine();

            Console.WriteLine("Одно или несколько слов с максимальной длиной");
            PrintString(GetMaxString(GetSplittedString(InnerString)));
            PrintLine();
        }

        public string GetString()
        {
            Console.WriteLine("Введите любую строку");
            string getString = Console.ReadLine();
            return getString;
        }

        /// <summary>
        /// Разделяем строку на слова
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string[] GetSplittedString(string str)
        {

            var resultStr = str.Split(new[] { ',', ' ', '!', '?', ';', ':', '"', '/', '_', '-' }, StringSplitOptions.RemoveEmptyEntries);
            return resultStr;
        }

        /// <summary>
        /// возвращает строку, содержащую слово с минимальной длиной
        /// </summary>
        /// <param name="str"></param>
        /// <returns>minStr</returns>
        public string GetMinString(params string[] str)
        {
            string minStr = "";
            int minLength = str[0].Length;
            foreach (string s in str)
            {

                if (s.Length < minLength)
                    minLength = s.Length;
            }
            foreach (string s in str)
            {
                if (s.Length == minLength)
                {
                    minLength = s.Length;
                    minStr = s;
                    break;
                }
            }
            return minStr;
        }

        /// <summary>
        /// озвращает одно или несколько слов с максимальной длиной
        /// </summary>
        /// <param name="str"></param>
        /// <returns>maxStr</returns>
        public string[] GetMaxString(params string[] str)
        {
            int counter = 0;
            int maxLength = str[0].Length;

            foreach (string s in str)
            {
                if (s.Length >= maxLength)
                    maxLength = s.Length;
            }

            foreach (string s in str)
            {
                if (s.Length == maxLength)
                    counter++;
            }

            string[] maxStr = new string[counter];

            for (int i = 0; i < counter; i++)
            {
                for (int j = i; j < str.Length; j++)
                {
                    if (str[j].Length == maxLength)
                    {
                        maxStr[i] = str[j];
                        continue;
                    }
                }
            }
            return maxStr;
        }

        /// <summary>
        /// Выводит в консоль массив данных
        /// </summary>
        /// <param name="str"></param>
        public void PrintString(params string[] str)
        {
            foreach (string s in str)
            {
                Console.WriteLine($"{s}");
            }
        }

        /// <summary>
        /// new string('*', 50)
        /// </summary>
        public void PrintLine()
        {
            Console.WriteLine(new string('*', 50));
        }

    }
}
