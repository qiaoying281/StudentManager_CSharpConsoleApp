using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using StudentManager.Models;

namespace StudentManager.Validates
{
    public class HumanInfoValidate
    {
        //methods
        public static ValidateMessage GetValidName(string Name)
        {
            if (string.IsNullOrEmpty(Name) )
                return new ValidateMessage(false, $"Name must not null.");
            if (Name.Length >= FieldData.MAX_LENGTH_OF_NAME)
                return new ValidateMessage(false, $"Name's length must shorter than {FieldData.MAX_LENGTH_OF_NAME} characters.");
            return new ValidateMessage(true, "");
        }
        public static ValidateMessage GetValidDate(DateTime DateOfBirth)
        {
            if (DateOfBirth.ToString() == null)
                return new ValidateMessage(false, $"Date of birth must not null.");
            if (DateOfBirth.Year < FieldData.MIN_YEAR_OF_BIRTHDAY)
                return new ValidateMessage(false, $"Date of birth must bigger than {FieldData.MIN_YEAR_OF_BIRTHDAY}");
            if (DateOfBirth > DateTime.Now)
                return new ValidateMessage(false, $"Date of birth must smaller than {DateTime.Now}");
            return new ValidateMessage(true,"");
        }
        public static ValidateMessage GetValidAddress(string Address)
        {
            if (Address.Length > FieldData.MAX_LENGTH_OF_ADDRESS)
                return new ValidateMessage(false, $"Address length must shorter than {FieldData.MAX_LENGTH_OF_ADDRESS} characters.");
            return new ValidateMessage(true,"");
        }
        public static ValidateMessage GetValidHeight(double Height)
        {
            if (Height < FieldData.MIN_VALUE_OF_HEIGHT)
                return new ValidateMessage(false, $"Height must higher than {FieldData.MIN_VALUE_OF_HEIGHT} cm");
            if (Height > FieldData.MAX_VALUE_OF_HEIGHT)
                return new ValidateMessage(false, $"Height must lower than {FieldData.MAX_VALUE_OF_HEIGHT} cm");
            return new ValidateMessage(true,"");
        }
        public static ValidateMessage GetValidWeight(double Weight)
        {
            if (Weight > FieldData.MAX_VALUE_OF_WEIGHT)
                return new ValidateMessage(false, $"Weight must lower than {FieldData.MAX_VALUE_OF_WEIGHT} kg");
            if (Weight < FieldData.MIN_VALUE_OF_WEIGHT)
                return new ValidateMessage(false, $"Weight must higher than {FieldData.MAX_VALUE_OF_WEIGHT} kg");
            return new ValidateMessage(true,"");
        }
    }
}