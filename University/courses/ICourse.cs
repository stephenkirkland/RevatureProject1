using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Users;

namespace University.Courses
{
    interface ICourse
    {
        // methods
        bool AddStudent(Student student);
        bool AddStudents(List<Student> roster);
        bool RemoveStudent(int id);
        bool RemoveStudent(Student student);
        bool RemoveStudent(string firstname, string lastname);
        bool OneOrTwo();
        Student GetStudentByID(int id);
        //Student GetStudentByFirstName(string firstname);
        //List<Student> GetStudentRoster();

        // properties
        bool isFull { get; }
        int RosterCount { get; }
        string Title { get; }
    }
}
