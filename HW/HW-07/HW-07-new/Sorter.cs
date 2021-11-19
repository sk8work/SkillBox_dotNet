using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_new
{
    struct Sorter
    {
        public static void SortedBy(string path)
        {
            var lines = File.ReadAllLines(path);
            var count = lines.Length;
            string[,] arrToSort;
            Console.WriteLine(count);
        }
    }
}
