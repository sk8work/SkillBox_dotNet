using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Ackerman(3,10));
        }
        static uint Ackerman(uint m, uint n)
        {
            if (m == 0)
                return n + 1;
            else if (n == 0)
                return Ackerman(m - 1, 1);
            else
                return Ackerman(m - 1, Ackerman(m, n - 1));
        }
    }
}
