using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
   public class ValidateUserDetailsCustomException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_STRING,
            NULL_STRING,
            INVALID_STRING
        }
        private readonly ExceptionType type;
       public ValidateUserDetailsCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
