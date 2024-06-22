using StudentManager.Models;
using StudentManager.Validates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Services
{
    public class ApplicationServices
    {
        public static void CreateStudent(List<Student> students)
        {
            try
            {
                Student student = InputStudentInformation.InputInformation(students);
                students.Add(student);
                Console.WriteLine("Add student successfull!");
                Console.WriteLine(student.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        //show list student
        public static void DisplayListStudent(List<Student> students)
        {
            if (students.Count != 0)
            {
                Console.WriteLine("==========LIST OF STUDENTS==========");
                foreach (Student student in students)
                {
                    Console.WriteLine(student.ToString());
                    Console.WriteLine("");
                }
                Console.WriteLine("==========END LIST==========");
            }
            else
                Console.WriteLine("Don't exist any student in list. Pleae input new student.");
        }


        //search student by id
        public static Student FindStudentById(List<Student> students)
        {
            Console.WriteLine("Input the student id that you want to find:");
            string idFind = Console.ReadLine();
            Student student = students.FirstOrDefault(s => s.StudentCode == idFind);
            if (student == null)
                Console.WriteLine($"Don't exist student with student id is: {idFind}");
            else
                Console.WriteLine("Student's info what you want to find:");
            return student;
        }


        //update student by id
        public static void UpdateStudentById(List<Student> students)
        {
            Console.WriteLine("Input the student id that you want to update:");
            string idUpdate = Console.ReadLine();
            Student student = students.FirstOrDefault(s => s.StudentCode == idUpdate);
            if (student == null)
                Console.WriteLine($"Don't exist student with st udent id is: {idUpdate}");
            else
            {
                try
                {
                    Student studentUpdated = InputStudentInformation.InputInformation(students);
                    student.Name = studentUpdated.Name;
                    student.DateOfBirth = studentUpdated.DateOfBirth;
                    student.Address = studentUpdated.Address;
                    student.Height = studentUpdated.Height;
                    student.Weight = studentUpdated.Weight;
                    student.StudentCode = studentUpdated.StudentCode;
                    student.SchoolName = studentUpdated.SchoolName;
                    student.StartYear = studentUpdated.StartYear;
                    student.GPA = studentUpdated.GPA;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                Console.WriteLine(student.ToString());
                Console.WriteLine("Update student successfull!");
            }
        }


        //delete student by id
        public static void DeleteStudentById(List<Student> students)
        {
            Console.WriteLine("Input the student id that you want to delete:");
            string idDelete = Console.ReadLine();
            bool hasStudent = students.Any(s => s.StudentCode == idDelete);
            if (hasStudent)
                Console.WriteLine($"Don't exist student with student id is: {idDelete}");
            else
            {
                try
                {
                    students.Remove(students.FirstOrDefault(s => s.StudentCode == idDelete));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                Console.WriteLine("Delete student successfull!");
            }
        }


        //view percent of grade point
        public static void DisplayGPAByPercent(List<Student> students)
        {
            var gradeGPAList = students.GroupBy(s => s.StudentGradePoint)
                .Select(l => new
                {
                    StudentGradePoint = l.Key,
                    Percent = (l.Count() * 100 / students.Count)
                }
                )
                .OrderByDescending(s => s.Percent).ToList();

            Console.WriteLine("==========Grade GPA list order by descending==========");
            foreach (var student in gradeGPAList)
                Console.WriteLine($"Grade point: {student.StudentGradePoint}; Percent: {student.Percent}%");
        }


        //view percent of average point
        public static void DisplayRankByPercent(List<Student> students)
        {
            Dictionary<double, int> averageGPAList = new Dictionary<double, int>();
            foreach (var student in students)
            {
                if (averageGPAList.ContainsKey(student.GPA))
                    averageGPAList[student.GPA]++;
                else
                    averageGPAList.Add(student.GPA, 1);
            }
            Console.WriteLine("==========Average GPA list==========");
            foreach (var result in averageGPAList)
                Console.WriteLine($"{result.Key} : {result.Value * 100 / students.Count}%");
        }



        //find student list bt grade
        public static void FindStudentByGrade(List<Student> students)
        {
            Console.WriteLine("Input grade what you want to find: ");
            string gradeGPA = Console.ReadLine();
            var studentsByGrade = students.Where(s => s.StudentGradePoint.ToString() == gradeGPA);
            if (studentsByGrade == null)
                Console.WriteLine($"Don't exist student with grade is {gradeGPA}");
            else
            {
                Console.WriteLine($"==========Student list with grade {gradeGPA}==========");
                foreach (var student in studentsByGrade)
                    Console.WriteLine(student.ToString());
            }
        }


        //save list to file .txt
        public static void SaveInFile(List<Student> students)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var student in students)
                sb.AppendLine(student.ToString());
            File.WriteAllText(FieldData.filePath, sb.ToString());
            Console.WriteLine("Save list successful!");
        }


        //close program
        public static void Close()
        {
            Console.WriteLine("Close program successfull!");
            Environment.Exit(0);
        }
    }
}
