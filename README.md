# RevatureProject1
#### Author: Stephen Kirkland
#### Due Date: Tuesday, February 21, 2017
College Registration App

The main objective of this project is to create a college registration app that allows students to enroll in up to 6 credit-hour courses.

Some of the main focuses on this project were:
- architecture
- modularity
- abstraction
- testability
- inheritance

<b>Included Files:</b>
- RegistrationApp.cs
- User.cs (abstract class)
- Student.cs
- Administrator.cs (singleton)
- Course.cs
- ICourse.cs (interface)
- Global.cs
- University.cs

<b><u>Courses:</u></b>
+ There are only 15 courses
+ 10 courses are only 1-credit hour
+ 5 courses to be 2-credit hours
+ There can only be 20 students in a course.

<b><u>Students:</u></b>
+ Student can only have 6 credit-hours total.
+ 3 to 6 credit-hours are considered full-time students
+ 1 to 2 credit-hours are considered part-time students
+ 0 credit-hours, the student isn't even enrolled.
+ You can add as many students to the university as we want.

<b><u>Requirements:</u></b>
+ There should be only one administrator using singleton 


<b>Status</b>
- Freshman
- Sophomore
- Junior
- Senior

<b>List of 1-Hour Courses</b>
- Basketball
- Tennis
- Psychology
- American Government
- German
- French
- Anthropology
- Art
- Spanish
- Religion

<b>List of 2-Hour Courses</b>
- Calculus II
- Data Structures
- Physics
- Artificial Intelligence
- Engineering Statics
