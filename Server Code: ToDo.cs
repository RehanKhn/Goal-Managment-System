using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Managment_System_Server
{
    public class ToDo
    {
        private string todos;
        private string date;

        public string Todos { get => todos; set => todos = value; }
        public string Date { get => date; set => date = value; }
    }
}

