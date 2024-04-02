using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class user
    {
        public string Name;
        public string SurName;
        public string UserName;
        public string Password;
        public user(string name, string surname, string username, string password)
        {
            this.Name = name;
            this.SurName = surname;
            this.UserName = username;
            this.Password = password;
        }
        public user()
        {
            
        }
    }
}
