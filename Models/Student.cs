using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using StudentManager.Enums;

namespace StudentManager.Models
{
    public class Student : Human
    {
        //fields
        private string studentCode;
        private string schoolName;
        private int startYear;
        private double gPA;
        private GradePoint studentGradePoint;
        //properties
        public string StudentCode
        {
            get { return studentCode; }
            set { studentCode = value; }
        }
        public string SchoolName
        {
            get { return schoolName; }
            set { schoolName = value; }
        }
        public int StartYear
        {
            get { return startYear; }
            set { startYear = value; }
        }
        public double GPA
        {
            get { return gPA; }
            set 
            {
                gPA = value;
                studentGradePoint = SetGradePoint();
            }
        }
        public GradePoint StudentGradePoint
        {
            get { return studentGradePoint; }
        }

        //contructors
        public Student(string studentCode, string schoolName, int startYear, double gPA, string name, DateTime dateOfBirth, string address, double height, double weight) : base(name, dateOfBirth, address, height, weight)
        {
            StudentCode = studentCode;
            SchoolName = schoolName;
            StartYear = startYear;
            GPA = gPA;
        }

        //methods
        
        public override string ToString()
        {
            return $"Student ID: {StudentCode};\nSchool name: {SchoolName};\nYear of starting learn: {StartYear};\nGPA: {GPA};\nGrade point: {StudentGradePoint};\n" + base.ToString();
        }
        public GradePoint SetGradePoint()
        {
            if (GPA <= 3)
                return GradePoint.Poor;
            if (GPA <= 5)
                return GradePoint.Weak;
            if (GPA <= 6.5)
                return GradePoint.Medium;
            if (GPA <= 7.5)
                return GradePoint.QuiteGood;
            if (GPA <= 9)
                return GradePoint.Good;
            return GradePoint.Excellent;
        }
    }
}
