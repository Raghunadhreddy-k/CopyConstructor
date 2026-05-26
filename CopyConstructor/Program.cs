//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CopyConstructor
//{
//    class student
//    {
//        public int Sid;
//        public string Sname;

//        public student(int sid, string sname)
//        {
//            sid = Sid;
//            sname = Sname;
//        }
//        public student(student stu)
//        {
//            Sid = stu.Sid;
//            Sname = stu.Sname;
//        }
//        public void StudentDisplay()
//        {
//            Console.WriteLine("student id is " + Sid);
//            Console.WriteLine("student name is " + Sname);
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            student obj = new student(1, "Raghu");
//            obj.StudentDisplay();
//            student stu = new student(obj);
//            stu.StudentDisplay();
//        }
//    }
//}
