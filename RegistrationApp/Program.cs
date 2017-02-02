using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Users;
using University.Courses;

namespace RegistrationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Course testCourse = new Course("AI", new DateTime(), 3);
            Student s = new Student("Stephen", "Kirkland", "ha", "sk01417@uga.edu", 91253674, "CSEE");
            Administrator ma = new Administrator();
            User u = new Administrator();

            Console.WriteLine(s.GetInfo());
            try {
                testCourse.OneOrTwo();
            }
            catch (Exception d)
            {
                Console.WriteLine(d.Message);
                Console.WriteLine();
            }

            List<Student> list = new List<Student>();
            testCourse.AddStudents(list);
            Console.WriteLine(testCourse.RosterCount);

            for (int i = 0; i < 3; i++)
            {
                list.Add(s);
            }
            testCourse.AddStudents(list);

            Console.WriteLine(testCourse.RosterCount);

            for (int i = 0; i < 18; i++)
            {
                list.Add(s);
            }

            try
            {
                testCourse.AddStudents(list);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
                // Console.WriteLine(e.ToString());
            }

            Console.ReadLine();
        }
    }
}
