// Встроенные классы. Math, Convert, DateTime, TimeSpan

using System;

namespace Practice_001
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Convert
            // Преобразует значение одного базового типа к другому базовому типу дынных

            // bool
            // byte
            // char
            // DateTime
            // decimal
            // double
            // short
            // int
            // long
            // sbyte
            // float
            // string
            // ushort
            // uint
            // ulong

            int i = Convert.ToByte("20");
            int j = byte.Parse("20");
            // j = (int)2011;
            i = Convert.ToByte(12.45);
            i = Convert.ToByte(56.78f);
            i = Convert.ToByte(89.09m);

            #endregion

            #region Math

            Console.ReadKey();

            // Math.PI;
            // Math.E;
            // Math.Abs;

            // Sin, Cos, Tan, Atan, Tanh etc.
            // Log, Log10
            // Max, Min
            // var result = Math.Max(11,22);

            // Приводит к верхнему целому числу
            Console.WriteLine(Math.Ceiling(1.2)); // 2
            Console.WriteLine(Math.Ceiling(-1.2)); // -1

            // Число е в степени 2
            Console.WriteLine(Math.Exp(2));

            // Приводитк нижнему целому числу
            Console.WriteLine(Math.Floor(1.2)); // 1
            Console.WriteLine(Math.Floor(-1.2)); // -2

            // Возведение в степень
            Console.WriteLine(Math.Pow(4,3));
            Console.WriteLine(Math.Pow(2020,2));

            // Округляет до указанного числа дробных разрядов
            Console.WriteLine(Math.Round(1.2345)); // 1
            Console.WriteLine(Math.Round(1.5345)); // 2
            Console.WriteLine(Math.Round(-1.5345)); // -2
            Console.WriteLine(Math.Round(-1.56789, 3)); // -1.568

            // Возвращает целое число, указывающее знак 8-разрядного целого числа со знаком
            Console.WriteLine(Math.Sign(-20)); // -1
            Console.WriteLine(Math.Sign(20)); // 1

            int r = 2;
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine(s);

            Console.ReadKey();
            #endregion

            #region DateTime, Timespan

            DateTime date = new DateTime(2020, 09, 28, 01, 30, 00);
            Console.WriteLine($"{date}"); // 28.09.2020 1:30:00

            // date.Year
            // date.Month
            // date.Day
            // date.Hour
            // date.Minute
            // date.Second
            // date.Millisecond

            Console.WriteLine(date.ToShortTimeString()); // 1:30
            Console.WriteLine(date.ToShortDateString()); // 28.09.2020

            DateTime newDate = date.AddDays(10);
            Console.WriteLine($"{newDate}"); // 08.10.2020 1:30:00

            Console.WriteLine(DateTime.Now);

            TimeSpan span = newDate - date;
            Console.WriteLine(span); // 10.00:00:00
            Console.WriteLine(span.TotalMilliseconds); // 14400

            Console.Clear();

            date = DateTime.Now;

            double sum = 0;

            for (int k = 0; k < 1_000_000; k++)
            {
                sum += k;
            }

            Console.WriteLine($"sum = {sum}");

            TimeSpan timeSpan = DateTime.Now.Subtract(date);
            Console.WriteLine($"timeSpan.TotalMilliseconds = {timeSpan.TotalMilliseconds}");

            #endregion

        }
    }
}
