using System;
using System.Collections.Generic;
using StudentManager.Models;
using System.IO;
using System.Text;
using StudentManager.Enums;
using StudentManager.Services;
using StudentManager.Validates;
using System.ComponentModel.Design;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Student> students = new List<Student>();
            Menu.ServicesList(students);
        }
    }
}