using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Student
    {
        private string userName;
        private string passWord;
        private string selectGender;
        private string selectAge;
        private string fileContent;
        private string name;
        private string surname;
        private string email;

        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string SelectGender { get => selectGender; set => selectGender = value; }
        public string SelectAge { get => selectAge; set => selectAge = value; }
        public string FileContent { get => fileContent; set => fileContent = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }

       
    }
    class datastore
    {
        public static List<Student> data = new List<Student>();
    }
}
