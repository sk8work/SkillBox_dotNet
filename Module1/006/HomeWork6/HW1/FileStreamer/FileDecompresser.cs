using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.IO.Compression;

namespace HW1
{
    class FileDecompresser
    {
        string source = "Source/getnumber.txt";
        string compressed = "Source/getnumber.zip";

        /// <summary>
        /// Разорхивация даннных
        /// </summary>
        /// <param name="source"></param>
        private void Decompression(string source)
        {
            using (FileStream ss = new FileStream(compressed, FileMode.OpenOrCreate))
            {
                using (FileStream ts = File.Create($"_{source}"))
                {
                    // поток разархивации
                    using (GZipStream ds = new GZipStream(ss, CompressionMode.Decompress))
                    {
                        ds.CopyTo(ts);
                        Console.WriteLine($"{source} восстанвлен");

                        Console.WriteLine("Восстановление файла {0} заветшено. Было: {1}. Стало: {2}.",
                            source,
                            ss.Length,
                            ts.Length);
                    }
                }
            }
        }
    }
}
