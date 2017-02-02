using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Users;

namespace University.Courses
{
    public class Course : ICourse
    {
        #region fields
        private List<Student> studentRoster = new List<Student>();

        public bool isClosed;
        private string title;
        private string major;
        private DateTime timeOfDay;
        private int creditHour;
        #endregion fields

  
        #region constructors
        public Course()
        {
        }

        public Course(string title, DateTime timeOfDay, int creditHour = 1, string major = "elective")
        {
            this.title = title;
            this.timeOfDay = timeOfDay;
            this.major = major;
            this.creditHour = creditHour;
        }
        #endregion constructors


        public delegate bool CloseRegistration(Course courseToClose);
        public CloseRegistration cr = null;

        /// <summary>
        /// checks to see if the class is full
        /// </summary>
        public bool isFull
        {
            get
            {
                return studentRoster.Count == Global.maxStudents;
            }
        }


        /// <summary>
        /// counts the number of students in a course
        /// </summary>
        public int RosterCount
        {
            get
            {
                return studentRoster.Count;
            }
        }

        /// <summary>
        /// adds a student to the roster and increments the student roster
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool AddStudent(Student student)
        {
            SpaceCheck(studentRoster.Count + 1);
            studentRoster.Add(student);
            if (cr != null && isFull == true)
            {
                cr(this);
            }
            return true;
        }

        /// <summary>
        /// adding an entire list of students to the course
        /// </summary>
        /// <param name="roster">list of students</param>
        /// <returns></returns>
        public bool AddStudents(List<Student> roster)
        {
            SpaceCheck(roster.Count + studentRoster.Count);

            foreach (Student item in roster)
            {
                AddStudent(item);
            }
            return true;
        }

        /// <summary>
        /// returns a list of all the students in the course
        /// </summary>
        /// <returns></returns>
        public List<Student> GetStudentRoster()
        {
            return studentRoster;
        }


        /// <summary>
        /// supposed to remove a specified student from the course
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool RemoveStudent(Student student)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// finds a student's corresponding id and removes that student from the course
        /// </summary>
        /// <param name="id">the student's id who is supposed to be removed</param>
        /// <returns></returns>
        public bool RemoveStudent(int id)
        {
            Student s = GetStudentByID(id);
            return studentRoster.Remove(s);
        }

        /// <summary>
        /// remove a student by entering their first and last name as parameters
        /// </summary>
        /// <param name="firstname">first name of student</param>
        /// <param name="lastname">last name of student</param>
        /// <returns></returns>
        public bool RemoveStudent(string firstname, string lastname)
        {

            return false;
        }

        /// <summary>
        /// a number will be passed into the parameter and checked to see if there is enough
        /// space in order to chcek to see if one could add more people to the course.
        /// </summary>
        /// <param name="countDractula"></param>
        /// <returns></returns>
        private bool SpaceCheck(int countDractula)
        {
            if (countDractula > Global.maxStudents)
            {
                throw new Exception(Errors.notEnoughError);
            }
            return true;
        }

        public bool OneOrTwo()
        {
            if(creditHour == 1 || creditHour == 2)
            {
                return true;
            }
            throw new Exception(Errors.notCorrectHours);
        }

        public Student GetStudentByID(int id)
        {
            /* The same exact thing as below.
             * var temp = from x in studentRoster 
             * where x.Id == id;
             * select x;
            */

            var student = studentRoster.Where(s => s.Id == id).FirstOrDefault(); // inside the Where() is the Lambda function, where it traverse through the users' ids and returns the id in the function's parameter to the variable x.
            return student;
        }

        public IEnumerable<Student> GetStudentByFirstName(string firstname)
        {
            var results = studentRoster.Where(fn => fn.firstname == firstname);
            return results;
        }

        public IEnumerable<Student> GetStudentByFullName(string fullname)
        {
            var results = studentRoster.Where(fn => fn.Fullname == fullname);
            return results;
        }

        public IEnumerable<Student> GetStudentByFullName(string firstname, string lastname)
        {
            return GetStudentByFullName($"{firstname} {lastname}");
        }

        private static bool CloseCourse(Course courseToClose)
        {
            courseToClose.isClosed = true;
            Console.WriteLine($"Registration closed for {courseToClose.Title}");
            return true;
        }

        #region properties
        /// <summary>
        /// a property that returns the title of the course
        /// </summary>
        public string Title
        {
            get
            {
                return this.title;
            }
        }

        #endregion properties
    }
}
