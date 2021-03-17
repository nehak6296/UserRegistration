using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
   public class ValidateUserDetailsCustomException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_NAME , EMPTY_EMAIL , EMPTY_PHONE_NUMBER , EMPTY_PASSWORD,
            NULL_NAME , NULL_EMAIL, NULL_PHONE_NUMBER, NULL_PASSWORD ,
            INVALID_NAME , INVALID_EMAIL , INVALID_PHONE_NUMBER , INVALID_PASSWORD
        }
        private readonly ExceptionType type;
       public ValidateUserDetailsCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
