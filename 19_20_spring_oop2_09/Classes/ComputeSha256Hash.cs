using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace _19_20_spring_oop2_09.Classes
{
    
    class ComputeSha256Hash_
    {
        //gelen girdileri hascode'a çeviren fonk.
        public static string ComputeSha256Hash(string rawData)
        {
            // SHA256 oluşturur.  
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash bit array'i döndürür.
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                // bit dizisini string'e çevirir.  
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
