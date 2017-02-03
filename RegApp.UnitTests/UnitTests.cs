using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using University.Courses;
using University.Users;

namespace RegApp.UnitTests
{

    [TestFixture]
    public class UnitTests
    {
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
            
        }

    }
}
