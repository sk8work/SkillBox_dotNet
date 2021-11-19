using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_new
{
    struct ConsoleMethods
    {
        /// <summary>
        /// Печать заголовка
        /// </summary>
        public static void PrintHeaderNote()
        {
            Console.WriteLine($"\n{"ID",-5}{"Дата и время",-20}{"Ф. И. О.",-25}{"Возраст",-10}{"Рост",-7}{"Дата рождения",-17}{"Место рождения",-17}");
        }

        /// <summary>
        /// Печатает элементы массива в строку
        /// </summary>
        /// <param name="data"></param>
        public static void PrintNote(string[] data)
        {
            Console.WriteLine($"{data[0],-5}{data[1],-20}{data[2],-25}{data[3],-10}{data[4],-7}{data[5],-17}{data[6],-17}");
        }

        /// <summary>
        /// Печатает сообщение об ошибке чтения из файла
        /// </summary>
        public static void FileExistError()
        {
            Console.WriteLine("\nФайл пуст или не существует. Заполните файл!");
        }

        /// <summary>
        /// Печатает сообщение об ошибке чтения из файла
        /// </summary>
        public static void IdError()
        {
            Console.WriteLine("\nДанного Id не существует. Введите Id.");
        }

        /// <summary>
        /// Выводит сообщение об успешном удалении записи сотрудника
        /// </summary>
        public static void NoteDeleted()
        {
            Console.WriteLine("\nЗапись удалена.");
        }

        /// <summary>
        /// 
        /// </summary>
        public static string GetUserIdForDelete()
        {
            Console.Write("\nВведите Id сотрудникка для удаления: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        public static string GetUserIdForRename()
        {
            Console.Write("\nВведите Id сотрудникка для изменения записи: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// Печатает 'Good bye!!!'
        /// </summary>
        public static void PrintGoodbye()
        {
            Console.WriteLine("\nGood Bye!!!");
        }
    } 
}
