using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_new
{
    struct FileWorker
    {

        static void Writer(string path)
        {
            if (File.Exists(path))
            {
                UserInfo.Id = 0;
                using (StreamReader sr = new StreamReader(path, Encoding.Unicode))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        UserInfo.Id += 1;
                    }
                }
            }

            UserInfo.GetUserInfo();
            string noteToWrite = UserInfo.GetUserString(UserInfo.Id, UserInfo.Fio, UserInfo.Age, UserInfo.High, UserInfo.BirthDate, UserInfo.BirthPlace);
            WriteStreamToFile(path, noteToWrite);
        }
    }
}
