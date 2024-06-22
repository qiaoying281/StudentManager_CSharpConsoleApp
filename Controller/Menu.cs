using StudentManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Services
{
    public class Menu
    {
        public static void ServicesList(List<Student> students)
        {
            string choice;
            while (true)
            {
                Console.WriteLine("==========STUDENT MANAGER==========");
                Console.WriteLine("1. Create new student.");
                Console.WriteLine("2. Print student list.");
                Console.WriteLine("3. Search student by Student Code.");
                Console.WriteLine("4. Update student.");
                Console.WriteLine("5. Delete.");
                Console.WriteLine("6. Show percent of grade.");
                Console.WriteLine("7. Show percent of average point.");
                Console.WriteLine("8. Find student list by grade.");
                Console.WriteLine("9. Save in file.");
                Console.WriteLine("10. Close program.");
                Console.WriteLine("Please input your choice:");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ApplicationServices.CreateStudent(students);
                        break;
                    case "2":
                        ApplicationServices.DisplayListStudent(students);
                        break;
                    case "3":
                        ApplicationServices.FindStudentById(students).ToString();
                        break;
                    case "4":
                        ApplicationServices.UpdateStudentById(students);
                        break;
                    case "5":
                        ApplicationServices.DeleteStudentById(students);
                        break;
                    case "6":
                        ApplicationServices.DisplayGPAByPercent(students);
                        break;
                    case "7":
                        ApplicationServices.DisplayRankByPercent(students);
                        break;
                    case "8":
                        ApplicationServices.FindStudentByGrade(students);
                        break;
                    case "9":
                        ApplicationServices.SaveInFile(students);
                        break;
                    case "10":
                        ApplicationServices.Close();
                        break;
                    default:
                        Console.WriteLine("Choice not exist. Please input again!");
                        break;
                }
            }
        }
    }
}
