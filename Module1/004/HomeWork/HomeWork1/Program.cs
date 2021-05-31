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

            #region заполнение массисов income, expenses, profit
            for (int i = 0; i < months.Length; i++)
            {
                income[i] = rand.Next(1, 20) * 10000;
                expenses[i] = rand.Next(1, 20) * 10000;
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

            // Заполним массив worstProfit худшими результатами прибыли за месяц
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

            // Определим количество месяцев с худшей прибылью
            int counter = 0;
            for (int i = 0; i < worstProfit.Length; i++)
            {
                for (int j = 0; j < profit.Length; j++)
                {
                    if (worstProfit[i] == profit[j])
                        counter++;
                }
            }
            #endregion

            #region Зададим массив allWorstMonths размерностью counter, заполним его нужными индексами и отсортируем для вывода по порядку
            int[] allWorstMonths = new int[counter];

            Console.WriteLine("WorstProfit");
            for (int i = 0; i < worstProfit.Length; i++)
            {
                Console.WriteLine($"worstProfit {worstProfit[i]}");
            }

            for (int i = 0, allWorstMonthsindexes = 0; i < worstProfit.Length; i++)
            {
                for (int j = 0; j < profit.Length; j++)
                {
                    if (worstProfit[i] == profit[j])
                    {
                        allWorstMonths[allWorstMonthsindexes] = j;
                        allWorstMonthsindexes++;
                    }
                }
            }


            Console.WriteLine(new string('*', 50));
            Array.Sort(allWorstMonths);

            Console.WriteLine("Месяцы с наихудшей прибылью:");
            for (int i = 0; i < allWorstMonths.Length; i++)
            {
                Console.Write($"{months[allWorstMonths[i]],-15}");
            }
            Console.WriteLine();
            for (int i = 0; i < allWorstMonths.Length; i++)
            {
                Console.Write($"{profit[allWorstMonths[i]],-15}");
            }

            #endregion

            // Delay
            Console.ReadKey();
        }
    }
}
