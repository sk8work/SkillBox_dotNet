using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_new
{
    struct UserInfo
    {
        // incapsulated fields
        public static int id = 0;
        static string fio;
        static int age;
        static int high;
        static DateTime birthDate;
        static string birthPlace;
        static string userChoice;

        //public methods
        //public static int Id { get => id; set => id = value; }
        public static string Fio { get => fio; set => fio = value; }
        public static int Age { get => age; set => age = value; }
        public static int High { get => high; set => high = value; }
        public static DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public static string BirthPlace { get => birthPlace; set => birthPlace = value; }
        public static string UserChoice { get => userChoice; set => userChoice = value; }

        /// <summary>
        /// Формируем строку с данными от пользователя
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fio"></param>
        /// <param name="age"></param>
        /// <param name="high"></param>
        /// <param name="birthDate"></param>
        /// <param name="birthPlace"></param>
        /// <returns></returns>
        public static void GetUserInfo()
        {
            Console.Write("\nВведите Ф.И.О.: ");
            Fio = Console.ReadLine();

            Console.Write("Введите Возраст: ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Рост: ");
            High = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Дату рождения: ");
            BirthDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Введите Место рождения: ");
            BirthPlace = Console.ReadLine();
        }

        /// <summary>
        /// Формируем строку с данными от пользователя
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fio"></param>
        /// <param name="age"></param>
        /// <param name="high"></param>
        /// <param name="birthDate"></param>
        /// <param name="birthPlace"></param>
        /// <returns></returns>
        public static string GetUserString(int id, string fio, int age, int high, DateTime birthDate, string birthPlace)
        {
            string note = string.Empty;

            note += $"{id}#{DateTime.Now.ToShortDateString()}/{ DateTime.Now.ToShortTimeString()}#{fio}#{age}#{high}#{birthDate}#{birthPlace}";
            return note;
        }

        /// <summary>
        /// Формирует массив с информацией о сотруднике (разбивает строку)
        /// </summary>
        /// <param name="note"></param>
        public static string[] NoteToArr(string note)
        {
            string[] data = note.Split('#');
            return data;
        }


    }
}
