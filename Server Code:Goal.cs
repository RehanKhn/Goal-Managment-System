using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Managment_System_Server
{
    public class Goal
    {
        private string golname;
        private List<ToDo> todos = new List<ToDo>();

        public string Golname { get => golname; set => golname = value; }
        public List<ToDo> Todos { get => todos; }
    }
}
