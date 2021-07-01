// FileInfo

using System;
using System.IO;

namespace Practice_003_02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FileInfo

            // using System.IO

            FileInfo fileInfo = new FileInfo(@"D:\SkillBox_dotNet\Lesson6\data.txt");

            Console.WriteLine(fileInfo.Attributes);
            Console.WriteLine(fileInfo.Exists);
            Console.WriteLine(fileInfo.Extension);
            Console.WriteLine(fileInfo.IsReadOnly);
            Console.WriteLine(fileInfo.LastAccessTime);
            Console.WriteLine(fileInfo.LastWriteTime);

            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.DirectoryName);

            #endregion

            // Delay
            Console.ReadKey();
        }
    }
}
