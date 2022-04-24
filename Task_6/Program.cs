using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Programming");
            student.Fullname = "ilkin ibrahimov";

            Student student1 = new Student("Programming");
            student1.Fullname = "tural memmedzade";

            Student student2 = new Student("Design");
            student2.Fullname = "orxan qenberov";
            Console.WriteLine(student.Groupname);
            Console.WriteLine(student1.Groupname);
            Console.WriteLine(student2.Groupname);


        }
    }
}
