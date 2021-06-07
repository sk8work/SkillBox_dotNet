using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class DeleteDuplicateChars
    {
        public string InnerString { get; set; }
        public char[] FormattedString { get; set; }

        /// <summary>
        /// Конструктор по-умолчанию
        /// </summary>
        public DeleteDuplicateChars()
        {
            InnerString = GetString();

            FormattedString = GetFormattedAndCutString(InnerString);

            PrintString(FormattedString);
        }

        /// <summary>
        /// Получаем строку от пользователя
        /// </summary>
        /// <returns></returns>
        public string GetString()
        {
            Console.WriteLine("Введите любую строку");
            string getString = Console.ReadLine();
            return getString;
        }

        public char[] GetFormattedAndCutString(string str)
        {
            string lowerString =  str.ToLower();
            char s = lowerString[0];
            int counter = 1;
            int strLength = lowerString.Length;
            for (int i = 1; i < strLength; i++)
            {
                if(s != lowerString[i])
                {
                    counter++;
                    s = lowerString[i];
                }
            }
            char[] result = new char[counter];
            result[0] = lowerString[0];

            for (int i = 1, j = 1; i < strLength; i++)
            {
                if (lowerString[i] != lowerString[i-1])
                {
                    result[j] = lowerString[i];
                    j++;
                }
            }

            return result;
        }

        /// <summary>
        /// Выводит в консоль массив данных
        /// </summary>
        /// <param name="str"></param>
        public void PrintString(params char[] str)
        {
            foreach (char s in str)
            {
                Console.Write($"{s}");
            }
            Console.WriteLine();
        }

    }
}
