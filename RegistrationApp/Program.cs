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
            Course testCourse = new Course("AI", new DateTime());
            Course dotnet = new Course("dotnet", new DateTime());

            Student s = new Student("Stephen", "Kirkland", "ha", "sk01417@uga.edu", 91253674, "CSEE");
            Student paul = new Student("Paul", "a", "pwd", "1@1.com", 1);
            Student mike = new Student("Mike", "a", "pwd", "2@2.com", 2);
            Student stephen = new Student("Stephen", "a", "pwd", "3@3.com", 3);
            Student chris = new Student("Chris", "a", "pwd", "4@4.com", 4);
            Student devonte = new Student("Devonte", "a", "pwd", "5@5.com", 5);
            Student alain = new Student("Alain", "a", "pwd", "6@6.com", 6);
            Student antone = new Student("Antone", "a", "pwd", "7@7.com", 7);
            Student erik = new Student("Erik", "a", "pwd", "8@8.com", 8);
            Student summer = new Student("Summer", "Wilken", "pwd", "9@9.com", 9);
            Student kirk = new Student("Stephen", "Kirkland", "pwd", "10@10.com", 10);

            Administrator a1 = Administrator.GetInstance;
            Administrator b2 = Administrator.GetInstance;

            dotnet.cr = a1.ChangeCourseStatus;
            dotnet.cr += b2.ChangeCourseStatus;

            dotnet.AddStudent(paul);
            dotnet.AddStudent(mike);
            dotnet.AddStudent(stephen);
            dotnet.AddStudent(chris);
            dotnet.AddStudent(devonte);
            dotnet.AddStudent(alain);
            dotnet.AddStudent(antone);
            dotnet.AddStudent(erik);
            dotnet.AddStudent(summer);
            dotnet.AddStudent(kirk);
            dotnet.AddStudent(paul);
            dotnet.AddStudent(mike);
            dotnet.AddStudent(stephen);
            dotnet.AddStudent(chris);
            dotnet.AddStudent(devonte);
            dotnet.AddStudent(alain);
            dotnet.AddStudent(antone);
            dotnet.AddStudent(erik);
            dotnet.AddStudent(summer);
            dotnet.AddStudent(kirk);


          /*
            
            int StephenKirkland = dotnet.GetStudentByFullName("Stephen Kirkland").Count();

            Console.WriteLine($"Number of Stephen Kirklands: {StephenKirkland}\n");

            dotnet.RemoveStudent(3); // removed other Stephen
            
            int numberOfStephens = dotnet.GetStudentByFirstName("Stephen").Count();

            Console.WriteLine($"Total number of Stephens: {numberOfStephens}\n");

            int numberOfSummers = dotnet.GetStudentByFullName("Summer", "Wilken").Count();

            Console.WriteLine($"Total number of Summer Wilkens: {numberOfSummers}\n");

            #region try if student is gone
            try
            {
                Student f = dotnet.GetStudentByID(3);
            }
            catch(NullReferenceException n) { 
                Console.WriteLine("nope! no student.");
            }
            #endregion try

            #region 1 or 2 credit hours
            try
            {
                dotnet.OneOrTwo();
            }
            catch (Exception d)
            {
                Console.WriteLine(d.Message);
                Console.WriteLine();
            }
            #endregion 1 or 2 credit hours

            List<Student> list = new List<Student>();

            dotnet.AddStudents(list);

            Console.WriteLine($"No students added yet...? {testCourse.RosterCount}");

            for (int i = 0; i < 3; i++)
            {
                list.Add(s);
            }
            dotnet.AddStudents(list);

            Console.WriteLine(testCourse.RosterCount);

            for (int i = 0; i < 18; i++)
            {
                list.Add(s);
            }

            #region try-catch-finally
            //multiply catches
            try
            {
                // open file
                // read from file
                // write and save file
                testCourse.AddStudents(list);
            }
            catch(DivideByZeroException ex)
            {

            }
            catch (ArgumentNullException d)
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
                // Console.WriteLine(e.ToString());
            }
            finally
            {
                // close file
            }
            #endregion try-catch-finally

        */

            Console.ReadLine();
        }
    }
}
