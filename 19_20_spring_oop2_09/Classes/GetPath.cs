using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
namespace _19_20_spring_oop2_09.Classes
{
    class GetPath
    {
        //csv dosyamızın paht'ini gönderen fonk.
        public static string getPath(string a)
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            // debuf file'in yolu
            var csvPath = Path.Combine(outPutDirectory, a+".csv");
            // csv dosyasının directory'si
            string csv_path = new Uri(csvPath).LocalPath;
            // path'de bu isimde dosya yoksa aynı isimde doysa oluşturur.
            if (File.Exists(csv_path) == false)
            {
                File.Create(a+ ".csv").Close();
            }
            return csv_path;
        }
        public static bool pathExists(string path)
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            // debuf file'in yolu
            var csvPath = Path.Combine(outPutDirectory, path + ".csv");
            // csv dosyasının directory'si
            string csv_path = new Uri(csvPath).LocalPath;
            // path'de bu isimde dosya yoksa aynı isimde doysa oluşturur.
            if (File.Exists(csv_path) == false)
            {
                return false;
            }
            return true;
        }
    }
}
