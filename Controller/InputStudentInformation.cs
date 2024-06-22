using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManager.Models;
using StudentManager.Validates;

namespace StudentManager.Services
{
    public class InputStudentInformation
    {
        //input new student
        public static string InputName()
        {
            string Name;
            do
            {
                Console.WriteLine("Input student's name: ");
                Name = Console.ReadLine();
                Console.WriteLine(HumanInfoValidate.GetValidName(Name).Message);
            }
            while (!HumanInfoValidate.GetValidName(Name).IsValid);
            return Name;
        }
        public static DateTime InputDateOfBirth()
        {
            DateTime DateOfBirth;
            do
            {
                Console.WriteLine("Input student's birthday: ");
                string s = Console.ReadLine();
                bool checkNull = DateTime.TryParse(s, out DateOfBirth);
                if (checkNull)
                {
                    Console.WriteLine(HumanInfoValidate.GetValidDate(DateOfBirth).Message);
                }
                else
                    Console.WriteLine($"Can't convert string {s} to type DateTime.");
            }
            while (!HumanInfoValidate.GetValidDate(DateOfBirth).IsValid);
            return DateOfBirth;
        }
        public static string InputAddress()
        {
            string Address;
            do
            {
                Console.WriteLine("Input student's address: ");
                Address = Console.ReadLine();
                Console.WriteLine(HumanInfoValidate.GetValidAddress(Address).Message);
            }
            while (!HumanInfoValidate.GetValidAddress(Address).IsValid);
            return Address;
        }
        public static double InputHeight()
        {
            double Height;
            do
            {
                Console.WriteLine("Input student's height: ");
                Height = double.Parse(Console.ReadLine());
                Console.WriteLine(HumanInfoValidate.GetValidHeight(Height).Message);
            }
            while (!HumanInfoValidate.GetValidHeight(Height).IsValid);
            return Height;
        }
        public static double InputWeight()
        {
            double Weight;
            do
            {
                Console.WriteLine("Input student's weight: ");
                Weight = double.Parse(Console.ReadLine());
                Console.WriteLine(HumanInfoValidate.GetValidWeight(Weight).Message);
            }
            while (!HumanInfoValidate.GetValidWeight(Weight).IsValid);
            return Weight;
        }
        public static string InputStudentCode(List<Student> students)
        {
            string StudentCode;
            do
            {
                Console.WriteLine("Input student ID: ");
                string str = Console.ReadLine();
                string[] strArr = str.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                StudentCode = string.Join("", strArr).ToUpper();
                Console.WriteLine(StudentInfoValidate.GetValidStudentCode(StudentCode,students).Message);
            }
            while (!StudentInfoValidate.GetValidStudentCode(StudentCode, students).IsValid);
            return StudentCode;
        }
        public static string InputSchoolName()
        {
            string SchoolName;
            do
            {
                Console.WriteLine("Input school's name: ");
                SchoolName = Console.ReadLine();
                Console.WriteLine(StudentInfoValidate.GetValidSchoolName(SchoolName).Message);
            }
            while (!StudentInfoValidate.GetValidSchoolName(SchoolName).IsValid);
            return SchoolName;
        }
        public static int InputYear()
        {
            int YearOfStartingLearn;
            do
            {
                Console.WriteLine("Input year of starting learn: ");
                YearOfStartingLearn = int.Parse(Console.ReadLine());
                Console.WriteLine(StudentInfoValidate.GetValidStartYear(YearOfStartingLearn).Message);
            }
            while (!StudentInfoValidate.GetValidStartYear(YearOfStartingLearn).IsValid);
            return YearOfStartingLearn;
        }
        public static double InputGPA()
        {
            double GPA;
            do
            {
                Console.WriteLine("Input GPA: ");
                GPA = double.Parse(Console.ReadLine());
                Console.WriteLine(StudentInfoValidate.GetValidGPA(GPA).Message);
            }
            while (!StudentInfoValidate.GetValidGPA(GPA).IsValid);
            return GPA;
        }
        public static Student InputInformation(List<Student> students)
        {
            var Name = InputName();
            var Address = InputAddress();
            var DateOfBirth = InputDateOfBirth();
            var Height = InputHeight();
            var Weight = InputWeight();
            var StudentCode = InputStudentCode(students);
            var SchoolName = InputSchoolName();
            var YearOfStartingLearn = InputYear();
            var GPA = InputGPA();
            return new Student(StudentCode,SchoolName,YearOfStartingLearn,GPA,Name,DateOfBirth,Address,Height,Weight);
        }
    }
}
