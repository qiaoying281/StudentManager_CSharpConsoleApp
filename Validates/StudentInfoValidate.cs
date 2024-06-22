using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManager.Models;

namespace StudentManager.Validates
{
    public class StudentInfoValidate
    {
        //methods
        public static ValidateMessage GetValidStudentCode(string StudentCode, List<Student> students)
        {
            if (string.IsNullOrEmpty(StudentCode))
                return new ValidateMessage(false, $"Student ID must not null.");
            if (StudentCode.Length != FieldData.LENGTH_OF_STUDENT_ID)
                return new ValidateMessage(false,$"Student ID's length must equal {FieldData.LENGTH_OF_STUDENT_ID} characters.");
            if (students.Any(s => s.StudentCode == StudentCode))
                return new ValidateMessage(false, $"Student ID exIst.");
            return new ValidateMessage(true,"");
        }
        public static ValidateMessage GetValidSchoolName(string SchoolName)
        {
            if (string.IsNullOrEmpty(SchoolName))
                return new ValidateMessage(false, $"School name must not null.");
            if (SchoolName.Length > FieldData.MAX_LENGTH_OF_SCHOOL_NAME)
                return new ValidateMessage(false, $"School name's length must shorter than {FieldData.MAX_LENGTH_OF_SCHOOL_NAME} characters.");
            return new ValidateMessage(true,"");
        }
        public static ValidateMessage GetValidStartYear(int StartYear)
        {
            if (string.IsNullOrEmpty(StartYear.ToString()))
                return new ValidateMessage(false, $"Year of starting learn must not null.");
            if (StartYear < FieldData.MIN_START_YEAR)
                return new ValidateMessage(false, $"Year of starting learn must bigger than {FieldData.MIN_START_YEAR}.");
            if (StartYear > DateTime.Now.Year)
                return new ValidateMessage(false, $"Year of starting learn must sooner than {DateTime.Now.Year}.");
            return new ValidateMessage(true,"");
        }
        public static ValidateMessage GetValidGPA(double GPA)
        {
            if (string.IsNullOrEmpty(GPA.ToString()))
                return new ValidateMessage(false, $"GPA must not null.");
            if (GPA > FieldData.MAX_VALUE_OF_GPA)
                return new ValidateMessage(false, $"GPA must lower than {FieldData.MAX_VALUE_OF_GPA}.");
            if (GPA < FieldData.MIN_VALUE_OF_GPA)
                return new ValidateMessage(false, $"GPA must higher than {FieldData.MIN_VALUE_OF_GPA}.");
            return new ValidateMessage(true,"");
        }
    }
}
