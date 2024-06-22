using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Validates
{
    public class FieldData
    {
        public const int MAX_LENGTH_OF_NAME = 100;
        public const int MIN_YEAR_OF_BIRTHDAY = 1900;
        public const int MAX_LENGTH_OF_ADDRESS = 300;
        public const double MIN_VALUE_OF_HEIGHT = 50;
        public const double MAX_VALUE_OF_HEIGHT = 300;
        public const double MIN_VALUE_OF_WEIGHT = 5;
        public const double MAX_VALUE_OF_WEIGHT = 1000;
        public const int LENGTH_OF_STUDENT_ID = 10;
        public const int MAX_LENGTH_OF_SCHOOL_NAME = 200;
        public const int MIN_START_YEAR = 1900;
        public const double MIN_VALUE_OF_GPA = 0;
        public const double MAX_VALUE_OF_GPA = 10;
        public const string filePath = "StudentList.txt";
    }
}
