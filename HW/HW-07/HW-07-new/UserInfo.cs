using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_new
{
    /// <summary>
    /// Структура для описания полей пользователя
    /// </summary>
    struct UserInfo
    {
        /// <summary>
        /// Статичное поле для уникального Id пользователя
        /// </summary>
        public static int id = 0;

        public UserInfo(string fio, DateTime date, DateTime time, int age, int high, DateTime birthDate, string birthPlace, string userChoice)
        {
            Id = id;
            DT = date;
            TT = time;
            Fio = fio;
            Age = age;
            High = high;
            BirthDate = birthDate;
            BirthPlace = birthPlace;
            UserChoice = userChoice;
        }

        //public methods
        public int Id { get; set; }
        public DateTime DT { get; set; }
        public DateTime TT { get; set; }
        public string Fio { get; set; }
        public int Age { get; set; }
        public int High { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string UserChoice { get; set; }

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
        public void SetUserInfo()
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

            note += $"{id}#{DateTime.Now.ToShortDateString()}#{ DateTime.Now.ToShortTimeString()}#{fio}#{age}#{high}#{birthDate.ToShortDateString()}#{birthPlace}";
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
