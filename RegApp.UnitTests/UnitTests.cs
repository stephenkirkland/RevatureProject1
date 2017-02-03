using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using University.Courses;
using University.Users;
using University;

namespace RegApp.UnitTests
{

    [TestFixture]
    public class UnitTests
    {
        Course testcourse;
        Student teststudent;

        //when you want to arrange multiple tests
        [SetUp]
        protected void SetupMockData()
        {
            testcourse = new Course("testcourse", new DateTime());
            teststudent = new Student("test", "lname", "pwd", "email", 1);
        }

        [Test]
        public void AddNumbers()
        {
            // aragnge
            int i = 1;
            int j = 2;

            // act
            int x = i + j;

            // assert
            Assert.AreEqual(x, i+j);
            Assert.AreEqual(3, x);
            Assert.AreNotEqual(x, i);

            /*
             * Success == Green
             * Fail == Red
             */ 
        } // AddNumbers class

        [Test]
        public void CoursesFullException()
        {
            // arrange
            #region ARRANGE
            /*
             Course dotnet = new Course("dotnet", new DateTime());

             // declaring students
             Student paul = new Student("Paul", "Stanton", "pwd", "1@1.com", 1);
             Student mike = new Student("Mike", "Furlow", "pwd", "2@2.com", 2);
             Student stephen = new Student("Stephen", "a", "pwd", "3@3.com", 3);
             Student chris = new Student("Chris", "a", "pwd", "4@4.com", 4);
             Student devonte = new Student("Devonte", "a", "pwd", "5@5.com", 5);
             Student alain = new Student("Alain", "a", "pwd", "6@6.com", 6);
             Student antone = new Student("Antone", "Eason", "pwd", "7@7.com", 7);
             Student erik = new Student("Erik", "May", "pwd", "8@8.com", 8);
             Student summer = new Student("Summer", "Wilken", "pwd", "9@9.com", 9);
             Student kirk = new Student("Stephen", "Kirkland", "pwd", "10@10.com", 10);

             // declaring administrators
             Administrator a1 = Administrator.GetInstance;
             Administrator b2 = Administrator.GetInstance; /* since this is implementing singleton, both pointers of a1 and b2 point to the same administrator instance.
             */

            /*
             * using a delegate that toggles the availabililty of a course;
             * for example: dotnet
             
            dotnet.cr = a1.ChangeCourseStatus;
            dotnet.cr += b2.ChangeCourseStatus;
           */

            #endregion ARRANGE
            for (int i = 0; i < Global.maxStudents; i++)
            {
                testcourse.AddStudent(new Student($"test{i}", "lname", "pwd", "email", i));
            }

            // adding students to the dotnet course
            // act
            #region ACT
            /*
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
            */
            #endregion ACT

            // assert
            Assert.Throws<Exception>(() => testcourse.AddStudent(teststudent));
            Assert.AreEqual(Global.maxStudents, testcourse.RosterCount);
        
        } // CoursesFullException method
    }
}
