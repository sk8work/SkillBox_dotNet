using System;

namespace Homework_01

{
    class Program
    {
        static void Main(string[] args)
        {

            /**************************  Задание1  ******************************/

            Console.WriteLine(new string('*', 30));
            Console.WriteLine("Задание 1. Переделать программу так, чтобы до первой волны увольнени в отделе было не более 20 сотрудников");
            // Создание базы данных из 20 сотрудников
            Repository repository = new Repository(20);

            // Печать в консоль всех сотрудников
            repository.Print("База данных до преобразования");

            // Увольнение всех работников с именем "Агата"
            repository.DeleteWorkerByName("Агата");

            // Печать в консоль сотрудников, которые не попали под увольнение
            repository.Print("База данных после преобразования");


            Console.WriteLine(new string('*', 30));
            // Delay
            Console.ReadKey();


            /**************************  Задание2  ******************************/

            Console.WriteLine("Задание 2. Создать отдел из 40 сотрудников и реализовать несколько увольнений, по " +
                "результатам которых в отделе болжно остаться не более 30 работников");

            Console.WriteLine(new string('*', 30));

            Repository repository2 = new Repository(40);
            repository2.Print("База данных до преобразования");
            repository2.DeleteWorkerByNameLimitWorkers("Агата", 30);
            repository2.DeleteWorkerByNameLimitWorkers("Агнес", 30);
            repository2.DeleteWorkerByNameLimitWorkers("Аделаида", 30);

            repository2.DeleteWorkerBySalaryLimitWorkers(30000, 30);
            repository2.Print("База данных после преобразования");
            Console.WriteLine(new string('*', 30));
            // Delay
            Console.ReadKey();


            /**************************  Задание3  ******************************/
            Console.WriteLine("Задание 3. Создать отдел из 50 сотрудников и реализовать " +
                "увольнение работников чья зарплата превышает 30000руб");

            Console.WriteLine(new string('*', 30));

            Repository repository3 = new Repository(50);
            repository3.Print("База данных до преобразования");
            repository3.DeleteWorkerBySalary(20000);
            repository3.Print("База данных после преобразования");
            Console.WriteLine(new string('*', 30));
            // Delay
            Console.ReadKey();


            #region Домашнее задание

            // Уровень сложности: просто
            // Задание 1. Переделать программу так, чтобы до первой волны увольнени в отделе было не более 20 сотрудников

            // Уровень сложности: средняя сложность
            // * Задание 2. Создать отдел из 40 сотрудников и реализовать несколько увольнений, по результатам
            //              которых в отделе должно остаться не более 30 работников

            // Уровень сложности: сложно
            // ** Задание 3. Создать отдел из 50 сотрудников и реализовать увольнение работников
            //               чья зарплата превышает 30000руб



            #endregion

        }
    }
}
