using exceptiontwo;
using System;
using System.Text.RegularExpressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = null;

            try
            {
                newStudent = new Student();
                newStudent.StudentName = "James007";

                ValidateStudent(newStudent);
            }
            catch (InvalidStudentNameException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }

        private static void ValidateStudent(Student std)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(std.StudentName))
                throw new InvalidStudentNameException(std.StudentName);

        }
    }
}
/*
 * using System;
namespace ErrorHandlingDemo
{
class Example
{
  static void Main(string[] args)
  {
      int result = 0;
      int a = 25;
      int b = 0;
      try
     {
        result = a / b;
     }
     catch (DivideByZeroException)
     {
        Console.WriteLine("Exception occured");
     }
     finally
     {
        Console.WriteLine("Result: {0}", result);
     }
  }
}
}*/