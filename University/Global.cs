using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public static class Global
    {
        public static int maxStudents = 20;
        public static int maxNumberOfCourses = 15;
        public static int maxNumberOfOneHour = 10;
        public static int maxNumberOfTwoHour = 5;
    }

    public static class Errors
    {
        public static string notEnoughError = "Attempting to add too many students. Not enough space. Cannot add.";
        public static string notCorrectHours = "The class has to be either 1 or 2 credit hours.";
    }
}
