using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class FileCompresser
    {
        string source = @"Source/getnumber.txt";
        string compressed = @"Source/getnumber.zip";

        /// <summary>
        /// Архивация данных
        /// </summary>
        /// <param name="source"></param>
        private void Compression(string source)
        {
            using (FileStream ss = new FileStream(source, FileMode.OpenOrCreate))
            {
                using (FileStream ts = File.Create(path: compressed)) // поток для записи сжатого файла
                {
                    // поток архивации
                    using (GZipStream cs = new GZipStream(ts, CompressionMode.Compress))
                    {
                        ss.CopyTo(cs);
                        Console.WriteLine("Сжатие файла {0} завершено. Было: {1}; Стало: {2}",
                            source,
                            ss.Length,
                            ts.Length);
                    }
                }
            }
        }
    }
}
