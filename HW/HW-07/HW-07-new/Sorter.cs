﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_new
{
    /// <summary>
    /// Сортирует массив пользователей по выбранному полю
    /// </summary>
    struct Sorter
    {

        /// <summary>
        /// Сортирует по Id
        /// </summary>
        /// <param name="userArr"></param>
        public static void SortById(List<UserInfo> userArr)
        {
            userArr.Sort(delegate (UserInfo us1, UserInfo us2)
            {
                return us1.Id.CompareTo(us2.Id);
            });
            ConsoleMethods.PrintHeaderNote();
            foreach (var item in userArr)
            {
                Console.WriteLine(item.Id);
            }
        }

        /// <summary>
        /// Сортирует по Имени
        /// </summary>
        /// <param name="userArr"></param>
        public static void SortByName(List<UserInfo> userArr)
        {
            userArr.Sort(delegate (UserInfo us1, UserInfo us2)
            {
                return us1.Fio.CompareTo(us2.Fio);
            });
            foreach (var item in userArr)
            {
                Console.WriteLine(item.Fio);
            }
        }

        /// <summary>
        /// Сортирует по Дате рождения
        /// </summary>
        /// <param name="userArr"></param>
        public static void SortByBDate(List<UserInfo> userArr)
        {
            userArr.Sort(delegate (UserInfo us1, UserInfo us2)
            {
                return us1.BirthDate.CompareTo(us2.BirthDate);
            });
            foreach (var item in userArr)
            {
                Console.WriteLine(item.BirthDate);
            }
        }

        /// <summary>
        /// Сортирует по Возрасту
        /// </summary>
        /// <param name="userArr"></param>
        public static void SortByAge(List<UserInfo> userArr)
        {
            userArr.Sort(delegate (UserInfo us1, UserInfo us2)
            {
                return us1.Age.CompareTo(us2.Age);
            });
            foreach (var item in userArr)
            {
                Console.WriteLine(item.Age);
            }
        }

        /// <summary>
        /// Сортирует по Росту
        /// </summary>
        /// <param name="userArr"></param>
        public static void SortByHigh(List<UserInfo> userArr)
        {
            userArr.Sort(delegate (UserInfo us1, UserInfo us2)
            {
                return us1.High.CompareTo(us2.High);
            });
            foreach (var item in userArr)
            {
                Console.WriteLine(item.High);
            }
        }

        /// <summary>
        /// Сортирует по Дате создания
        /// </summary>
        /// <param name="userArr"></param>
        public static void SortByDateCreation(List<UserInfo> userArr)
        {
            userArr.Sort(delegate (UserInfo us1, UserInfo us2)
            {
                return us1.DT.CompareTo(us2.DT);
            });
            foreach (var item in userArr)
            {
                Console.WriteLine(item.DT);
            }
        }
    }
}
