using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp.NetDevelopHelper.IO
{
    public static class IOService
    {


        public static bool CheckPath(string path)
        {
            return Directory.Exists(path);
        }

        public static bool FileExists(string path)
        {
            return File.Exists(path);
        }
        public static string ReadFile(string path)
        {
            if (!File.Exists(path))
                throw new Exception($"فایل {path} وجود ندارد");

            return File.ReadAllText(path);
        }
        public static void CreateFile(string path, string content, bool overwrite = false)
        {
            if (!Directory.Exists(Directory.GetParent(path).FullName))
            {
                Directory.CreateDirectory(Directory.GetParent(path).FullName);
            }
            if (File.Exists(path) && !overwrite)
                throw new Exception($"فایل {path} از قبل وجود دارد");
            //if (!File.Exists(path))
            //{
            //    File.Create(path);
            //}
            File.WriteAllText(path, content);
        }
        public static void DeleteFile(string path)
        {

            if (!File.Exists(path))
                throw new Exception($"فایل {path} از قبل وجود ندارد");

            File.Delete(path);
        }

        public static void CutFromFile(string path, string content)
        {

            if (!File.Exists(path))
                throw new Exception($"فایل {path} وجود ندارد");
            var file = File.ReadAllText(path);
            File.WriteAllText(path, file.Replace(content, ""));
        }
        public static void InsertIntoFile(string path, int index, string content)
        {

            if (!File.Exists(path))
                throw new Exception($"فایل {path} وجود ندارد");
            var file = File.ReadAllText(path);
            File.WriteAllText(path, file.Insert(index, content));
        }
        public static void InsertIfNotExists(string path, int index, string content)
        {

            if (!File.Exists(path))
                throw new Exception($"فایل {path} وجود ندارد");
            var file = File.ReadAllText(path);
            if (file.IndexOf(content) == -1)
                File.WriteAllText(path, file.Insert(index, content));
        }
        public static int FindIndex(string path, string searchText, int start = 0)
        {
            if (!File.Exists(path))
                throw new Exception($"فایل {path} وجود ندارد");
            var file = File.ReadAllText(path);
            return file.IndexOf(searchText, start);
        }


        public static int FindLastIndex(string path, string searchText, int before = -1)
        {
            if (!File.Exists(path))
                throw new Exception($"فایل {path} وجود ندارد");
            var file = File.ReadAllText(path);
            int result=-1;
            while (true)
            {
               var index=  file.IndexOf(searchText,result+1);
                if (index != -1 && (index <= before || before == -1))
                    result = index;
                else break;
            }
            return result;
        }

        public static List<string> GetDirectories (string path , bool fullPath =false)
        {
            if (!Directory.Exists(path))
                throw new Exception($"مسیر {path} وجود ندارد");
            return  Directory.GetDirectories(path).Select(x=> fullPath ? x: Path.GetFileNameWithoutExtension(x)).ToList();
        }

        public static List<string> GetFiles(string path, bool fullPath = false)
        {
            if (!Directory.Exists(path))
                throw new Exception($"مسیر {path} وجود ندارد");
            return Directory.GetFiles(path).Select(x => fullPath ? x : Path.GetFileNameWithoutExtension(x)).ToList();
        }
    }
}
