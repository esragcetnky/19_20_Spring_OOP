using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_20_spring_oop2_09.Classes
{
    class User
    {
        //kullanıcının ismini tutan değer
        private string userName;
        //sifrenin hashcode'u
        private string hashcode;
        //remember me boolean'ı
        private Boolean rememberMe;
        //kullanıcı isminin set fonksiyonu
        private string userType;

        public void setName(string value)
        {
            userName = value;
        }
        //kullanıcı isminin set fonk.
        public string getName()
        {
            return userName;
        }
        //kullanıcı isminin get fonk.
        public string getHashCode()
        {
            return hashcode;
        }
        //hashcode'un set fonk.
        public void setHashCode(string value)
        {
            hashcode = value;
        }
        public void setRememberMe(Boolean a)
        {
            rememberMe = a;
        }
        public Boolean getRememberMe()
        {
            return rememberMe;
        }
        public void setUserType(string value)
        {
            userType = value;
        }
        //kullanıcı isminin set fonk.
        public string getUserType()
        {
            return userType;
        }
    }
}
