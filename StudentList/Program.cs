using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    class Program
    {
        class Teacher
        {
            public string name;
            public string subject;
        }
        static void Main(string[] args)
        {
            List<Teacher> list = new List<Teacher>();
            list.Add(new Teacher() { name = "함기훈", subject = "뉴미디어콘텐츠제작" });
            list.Add(new Teacher() { name = "박민초", subject = "뉴미디어콘텐츠제작" });
        }
    }
}
