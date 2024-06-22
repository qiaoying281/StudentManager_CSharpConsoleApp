using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Models
{
    public class ValidateMessage
    {
        public bool IsValid { get; set; }
        public string Message { get; set; }

        public ValidateMessage()
        {
        }

        public ValidateMessage(bool IsValid, string message)
        {
            this.IsValid = IsValid;
            Message = message;
        }
    }
}
