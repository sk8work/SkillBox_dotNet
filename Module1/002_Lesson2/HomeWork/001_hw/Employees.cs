using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_hw
{
    class Employees
    {
        /// <summary>
        /// Private fields by Employee's name
        /// </summary>
        private string name;

        /// <summary>
        /// Private fields by Employee's age
        /// </summary>
        private int age;

        /// <summary>
        /// Private fields by Employee's height
        /// </summary>
        private double height;

        /// <summary>
        /// Private fields by Employee's rusScore
        /// </summary>
        private int rusScore;

        /// <summary>
        /// Private fields by Employee's historyScore
        /// </summary>
        private int historyScore;

        /// <summary>
        /// Private fields by Employee's mathScore
        /// </summary>
        private int mathScore;

        /// <summary>
        /// readonly fields by Employee's MaxScore
        /// </summary>
        readonly int MaxScore = 100;

        /// <summary>
        /// readonly fields by Employee's MinScore
        /// </summary>
        readonly int MinScore = 0;


        // Public methods to create Employee
        public void GetName()
        {
            while (name == "" || name == null)
            {
                Console.WriteLine("Enter your name");

                try
                {
                    name = Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered incorrect name");
                    this.name = "";
                    continue;
                }
                if (name == "" || name == null)
                    Console.WriteLine("You entered incorrect name");
            }
        }
        public void GetAge()
        {
            while (age < 18 || age > 80)
            {
                Console.WriteLine("Enter your age");
                try
                {
                    age = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered incorrect age");
                    this.age = 0;
                    continue;
                }
            }
        }
        public void GetHeight()
        {
            while (height < 1.0 || height > 2.5)
            {
                Console.WriteLine("Enter your height");
                try
                {
                    height = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered incorrect height");
                    this.height = 0;
                    continue;
                }
            }
        }
        public void GetRusScore()
        {
            while (rusScore <= MinScore || rusScore > MaxScore)
            {
                Console.WriteLine("Enter your rus score");
                try
                {
                    rusScore = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered incorrect rus score");
                    this.rusScore = 0;
                    continue;
                }
            }
        }
        public void GetHistoryScore()
        {
            while (historyScore <= MinScore || historyScore > MaxScore)
            {
                Console.WriteLine("Enter your historyScore");
                try
                {
                    historyScore = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered incorrect historyScore");
                    this.historyScore = 0;
                    continue;
                }
            }
        }
        public void GetMathScore()
        {
            while (mathScore <= MinScore || mathScore > MaxScore)
            {
                Console.WriteLine("Enter your mathScore");
                try
                {
                    mathScore = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered incorrect mathScore");
                    this.mathScore = 0;
                    continue;
                }
            }
        }

        /// <summary>
        /// Dispay simple info about employee
        /// </summary>
        public void DisplayInfoSimple()
        {
            
            Console.WriteLine();
            Console.WriteLine("Name: " + this.name + ", age: " + this.age + ", height: " + this.height);
            Console.WriteLine("Rus: " + this.rusScore + ", History: " + this.historyScore + ", Math: " + this.mathScore);
            Console.WriteLine("Your average score is " + string.Format("{0:0.##}", AverageScore()));
            Console.WriteLine();

            string endOfLine = new string('-', 100);
            Console.SetCursorPosition((Console.WindowWidth - endOfLine.Length) / 2, Console.CursorTop);
            Console.WriteLine(endOfLine);

            Console.WriteLine();
        }

        /// <summary>
        /// Dispay formated info about employee
        /// </summary>
        public void DisplayInfoFormated()
        {
            Console.WriteLine();
            Console.WriteLine("Name: {0}, age: {1}, height: {2}", this.name, this.age, this.height);
            Console.WriteLine("Rus: {0}, History: {1}, Math: {2}", this.rusScore, this.historyScore, this.mathScore);
            Console.WriteLine("Your average score is {0}", string.Format("{0:0.##}", AverageScore()));
            Console.WriteLine(new string('-', 30));
        }

        /// <summary>
        /// Dispay interpolation info about employee
        /// </summary>
        public void DisplayInfoInterpolated()
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {this.name}, age: {this.age}, height: {this.height}");
            Console.WriteLine($"Rus: {this.rusScore}, History: {this.historyScore}, Math: {this.mathScore}");
            Console.WriteLine($"Your average score is {string.Format("{0:0.##}", AverageScore())}");
            Console.WriteLine(new string('-', 30));
        }

        /// <summary>
        /// Calculate average score
        /// </summary>
        public double AverageScore()
        {
            return (this.rusScore + this.historyScore + this.mathScore) / 3.0;
        }


        /// <summary>
        /// Constructor
        /// </summary>
        public Employees()
        {
            GetName();
            GetAge();
            GetHeight();
            GetRusScore();
            GetHistoryScore();
            GetMathScore();
        }
    }
}
