// работа со строками. Класс String, Char

using System;

namespace Practice_002
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String
            string str = "Visual lausiV";
            Console.WriteLine($"str.IndexOf('i') = {str.IndexOf('i')}");
            Console.WriteLine($"str.LastIndexOf('i') = {str.LastIndexOf('i')}");

            Console.WriteLine($"str.IndexOf('z') = {str.IndexOf('z')}"); // -1

            string s = str.Insert(str.IndexOf(' ') + 1, "c# ");
            Console.WriteLine($"s = {s}");

            // Возвращает новую строку, в которой были удалены все символы с указанной позиции
            Console.WriteLine($"str.Remove(6) = {str.Remove(6)}");

            // Возврвщает новую строку, в которой были удалены все символы начиная с указанной позиции count элементов
            Console.WriteLine($"str.Remove(6,3) = {str.Remove(6, 3)}");

            // Возвращает новую строку, в которой все вхождения заданного знака Юникода в текущем
            // экземпляре заменены другим заданным знаком Юникода
            Console.WriteLine($"str.Replace('a', 'z') = {str.Replace('a', 'z')}");

            // Извлекает подстроку из данного экземпляра. Подстрока начинается в указанном положении
            // символов и продолжается до конца строки
            Console.WriteLine($"str.Substring(4) = {str.Substring(4)}");


            Console.WriteLine($"str.ToUpper() = {str.ToUpper()}");
            Console.WriteLine($"str.ToLower() = {str.ToLower()}");

            //str.Trim();         // Удаляет все начальные и конечные символы-разделители из текущего объекта System.String
            //str.TrimEnd();      // Удаляет все конечные разделители
            //str.TrimStart();    // Удаляет все начальные разделители

            // Разбивает строку на подстроки в зависимости от символов в массиве
            string[] array = "1 2 3 4.5 6;7 8 9;10".Split(' ', ',', ';');

            string test = null;
            Console.WriteLine($"StringIsNullOrEmpte = {String.IsNullOrEmpty(test)}"); // True

            test = String.Empty;
            Console.WriteLine($"StringIsNullOrEmpte = {String.IsNullOrEmpty(test)}"); // True

            test = "Skill";
            Console.WriteLine($"StringIsNullOrEmpte = {String.IsNullOrEmpty(test)}"); // False

            #endregion

            #region Char

            char c = 'c';
            //char.IsDigit
            //char.IsLetter
            //char.IsLower
            //char.IsUpper

            char[] symbols = "symbols".ToCharArray();
            foreach (var item in symbols)
            {
                Console.Write($"{item}");
            }

            string newStr = new String(symbols);

            Console.WriteLine($"string newStr = {newStr}");
            #endregion

            // Delay
            Console.ReadKey();
        }
    }
}
