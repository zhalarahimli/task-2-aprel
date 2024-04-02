using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class student:user

    {
        public int Grade;
        public student(string name, string surname, string username, string password, int grade):base(name, surname, username, password)
        {
            this.Grade = grade;
        }
        public student() { 
        }

    }
}
