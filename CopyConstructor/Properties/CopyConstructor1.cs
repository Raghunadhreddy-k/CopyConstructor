using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace copyConstructor
{
    class student
    {
        int studentid;
        string studentname;
        public student(int sid, string sname)
        {
            studentid = sid;
            studentname = sname;
        }
        public student(student sobj)
        {
            studentid = sobj.studentid;
            studentname = sobj.studentname;
        }
        public void studentdisplay()
        {
            Console.WriteLine("Student id is " + studentid);
            Console.WriteLine("Student name is " + studentname);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student obj = new student(139, "Raghu");
            obj.studentdisplay();
            student stu = new student(obj);
            stu.studentdisplay();
        }
    }
}