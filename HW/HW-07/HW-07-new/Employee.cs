using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_new
{
    struct Employee
    {
        /// <summary>
        /// id - статичное поле для уникального id сотрудника;
        /// </summary>
        public static int id;

        /// <summary>
        /// ID сотрудника (уникальный)
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Дата создания записи
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Время создания записи
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// ФИО сотрудника
        /// </summary>
        public string FIO { get; set; }

        /// <summary>
        /// Возраст сотрудника
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Рост сотрудника
        /// </summary>
        public int High { get; set; }

        /// <summary>
        /// ата рождения сотрудника
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Место рождения сотрудника
        /// </summary>
        public string PlaceOfBirth { get; set; }

        /// <summary>
        /// Преобразование набора полей в строку (для предварительной записи в файл)
        /// </summary>
        /// <returns></returns>
        static string EmpToString()
        {
            string note = String.Empty;
            note = $"{ID}#{CreationDate}#{CreationTime}#{FIO}#{Age}#{High}#{DateOfBirth}#{PlaceOfBirth}";
            return note;
        }

        /// <summary>
        /// Конструктор структуры Employee (создаем сотрудника)
        /// </summary>
        /// <param name="creationDate">Дата создания записи</param>
        /// <param name="creationTime">Время создания записи</param>
        /// <param name="fio">ФИО</param>
        /// <param name="age">Возраст</param>
        /// <param name="high">Рост</param>
        /// <param name="dateOfBirth">Дата рождения</param>
        /// <param name="placeOfBirth">Место рождения</param>
        internal Employee(DateTime creationDate, DateTime creationTime, string fio, int age, int high, DateTime dateOfBirth, string placeOfBirth)
        {
            ID = id;
            CreationDate = creationDate;
            CreationTime = creationTime;
            FIO = fio;
            Age = age;
            High = high;
            DateOfBirth = dateOfBirth;
            PlaceOfBirth = placeOfBirth;
        }
    }
}
