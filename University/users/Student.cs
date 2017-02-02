﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Courses;

namespace University.Users
{
    public class Student : User
    {
        #region fields
        private string major;
        private bool isFulltime;  //full-time or part-time
        //List<Course> classes = new List<Course>();
        Dictionary<string, Course> classes = new Dictionary<string, Course>();

        //array of their courses
        #endregion fields
        #region constructor
        public Student(string firstname, string lastname, string password, string email, int id,
            string major = "undecided") : base(firstname, lastname, password, email, id)
        {
            this.major = major;
            isFulltime = false;
        }

        public override string GetInfo()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.Append($"Name: {Fullname}");
            sb.Append($"\n{major}");
            sb.Append($"\nIs fulltime: {isFulltime}");

            if (classes.Count == 0)
            {
                sb.Append($"\nNot registered for classes. Go register.");
            }

            else
            {
                foreach (KeyValuePair<string, Course> c in classes)
                {
                    sb.Append("\n");
                    sb.Append(c.Value.Title);
                }
            }

            return sb.ToString();
        }
        #endregion constructor

    }
}
