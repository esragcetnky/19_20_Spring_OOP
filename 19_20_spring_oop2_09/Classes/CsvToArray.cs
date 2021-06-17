using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
namespace _19_20_spring_oop2_09.Classes
{
    class CsvToArray
    {
        //csv dosyasındaki verileri array'e ekler.
        public static void csvToarray(string a, string b)
        {
            //csv dosyasına baglanır.
            using (var reader = new StreamReader(GetPath.getPath(a)))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    using (var ureader = new StreamReader(GetPath.getPath(b)))
                    {
                        while (!ureader.EndOfStream)
                        {
                            var lline = ureader.ReadLine();
                            var vvalues = lline.Split(',');
                            if (values[0] == vvalues[0])
                            {
                                User newuser1 = new User();
                                newuser1.setName(values[0]);
                                newuser1.setHashCode(values[1]);
                                newuser1.setUserType(vvalues[1]);
                                Forms.Login.arrayUser.Add(newuser1);
                            }
                        }

                    }

                }

            }
        }
        public static void csvToarray(string a)
        {
            using (var reader = new StreamReader(GetPath.getPath(a)))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    NotesFolder.Notes.table.Rows.Add(values[0], values[1]);
                }
            }
        }
        
    }
}
    

