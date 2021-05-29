//Напишите простое приложение по учёту финансов.
//Заказчик проекта ― крупная компания. Её руководство хочет иметь возможность проводить анализ финансов за последние 12 месяцев.

//Финансы компании должны отображаться в виде таблицы, столбцы которой включают:

//номер месяца,
//доход,
//расход,
//прибыль.
//Самый важный показатель для руководства компании ― количество месяцев с положительной прибылью. 
//Важно определить три месяца с наименьшей прибылью, при этом месяцы с одинаковой прибылью считаются за один. 
//Само собой, компания не хочет делиться своими финансовыми показателями, поэтому для демонстрации приложения 
//доходы и расходы вас попросили заполнить случайными значениями.

using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region необходимые переменные и объекты
            Random rand = new Random();
            string[] header = new string[4] { "Месяц", "Доход(руб)", "Расход(руб)", "Прибыль(руб)" };
            int[] months = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] income = new int[12];
            int[] expenses = new int[12];
            int[] profit = new int[12];
            int[] worstProfit = new int[3];
            int[] worstProfitIndexes = new int[3];

            int[] sortArr = new int[12]; // массив для сортировки. (доп массив)

            #endregion

            #region Заполняем массив доходов случайыми числами и заполняем массив income
            for (int i = 0; i < income.Length; i++)
            {
                income[i] = rand.Next(1, 20) * 10000;
            }
            #endregion

            #region Заполняем массив расходов случайыми числами и заполняем массив expenses
            for (int i = 0; i < expenses.Length; i++)
            {
                expenses[i] = rand.Next(1, 20) * 10000;
            }
            #endregion

            #region Вычисляем прибыль за месяц и заполняем массив profit
            for (int i = 0; i < profit.Length; i++)
            {
                profit[i] = income[i] - expenses[i];
            }
            #endregion

            #region Выводим инвормацию по доходам, расходам и общей прибыли по месяцам за год
            for (int i = 0; i < header.Length; i++)
            {
                Console.Write($"{header[i],-15}");
            }

            Console.WriteLine();

            for (int i = 0; i < months.Length; i++)
            {
                Console.Write($"{months[i],-15}{income[i],-15}{expenses[i],-15}{profit[i],-15}\n");
            }
            #endregion

            #region Находим количество месяцев с положительной прибылью. Перебираем массив profit и выводим значение
            int count = 0;
            int totalProfit = 0;
            int totalLoss = 0;
            for (int i = 0; i < profit.Length; i++)
            {
                if (profit[i] >= 0)
                {
                    totalProfit += profit[i];
                    count++;
                }
                else
                {
                    totalLoss += profit[i];
                }
            }
            Console.WriteLine($"Количество месяцев с положительной прибылью: {count}");
            Console.WriteLine($"Общая прибыть: {totalProfit}");
            Console.WriteLine($"Общий убыток: {totalLoss}");
            #endregion

            #region Определим три месяца с наименьшей прибылью, при этом месяцы с одинаковой прибылью считаются за один

            Console.WriteLine(new string('*', 50));

            // Копируем массив profit в дополнительный массив
            Array.Copy(profit, sortArr, profit.Length);

            // На объекте Array вызываем метод Sort и передаем ему в качестве параметра массив sortArr
            Array.Sort(sortArr);
            int worst = sortArr[0];
            worstProfit[0] = sortArr[0];

            for (int i = 1; i < worstProfit.Length; i++)
            {
                for (int j = 1; j < sortArr.Length; j++)
                {
                    if (sortArr[j] <= worst)
                    {
                        continue;
                    }
                    worst = sortArr[j];
                    worstProfit[i] = sortArr[j];
                    break;
                }
            }

            // Выясним, под какими индексами в массиве profit находятся месяцы с самой худшей прибылью
            // И заполним массив worstProfitIndexes[3]
            for (int i = 0; i < worstProfit.Length; i++)
            {
                for (int j = 0; j < profit.Length; j++)
                {
                    if (profit[j] == worstProfit[i])
                    {
                        worstProfitIndexes[i] = j;
                    }
                }
            }

            // На объекте Array вызываем метод Sort и передаем ему в качестве параметра массив worstProfitIndexes
            Array.Sort(worstProfitIndexes);

            // Выводим информацию по месяцам с наихудшей прибылью в порядке возрастания месяцев
            Console.WriteLine("Итого, худшая прибыль в следующие месяцы:");
            for (int i = 0; i < worstProfitIndexes.Length; i++)
            {
                Console.Write($"{months[worstProfitIndexes[i]],-15}");
            }
            Console.WriteLine();
            for (int i = 0; i < worstProfitIndexes.Length; i++)
            {
                Console.Write($"{profit[worstProfitIndexes[i]],-15}");
            }

            #endregion

            // Delay
            Console.ReadKey();
        }
    }
}
