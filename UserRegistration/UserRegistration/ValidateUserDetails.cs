using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
   public class ValidateUserDetails
    {
        public static string REGEX_FIRSTNAME = "^[A-Z][a-z]{2,}$";
        public static string REGEX_LASTNAME = "^[A-Z][a-z]{2,}$";
        public static string REGEX_EMAIL = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public static string REGEX_PHONENUMBER = "^(91[ ])?[7-9][0-9]{9}$";
        public string REGEX_PASSWORD = "(?=.*[A-Z])(?=.*[0-9])(?=.*?[@#$%^&*?]){8,}";

        private string message;
        public ValidateUserDetails()
        {
        }
        public ValidateUserDetails(string message)
        {
            this.message = message;
        }
        public bool ValidateFirstName(string firstName)
        {
            try
            {
                if (Regex.IsMatch(firstName, REGEX_FIRSTNAME))
                {
                    return true;
                }
                if (firstName.Equals(string.Empty))
                {
                    throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.EMPTY_NAME, "Name can't be empty");

                }
                throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.INVALID_NAME,"Invalid Name");
            }
            catch (NullReferenceException)
            {
                throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.NULL_NAME, "Name can't be null");

            }
            
        }       
        public bool ValidateLastName(string lastName)
        {
            try
            {
                if (Regex.IsMatch(lastName, REGEX_LASTNAME))
                {
                    return true;
                }
                else if (lastName.Equals(string.Empty))
                {
                    throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.EMPTY_NAME, "Last name cant be empty");
                }
                throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.INVALID_NAME,"Invalid Last Name");
            }
            catch
            {
                throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.NULL_NAME, "LastName is never null");
            }
        }
        public bool ValidateEmail(string mail)
        {
            try
            {
                if (Regex.IsMatch(mail, REGEX_EMAIL))
                {
                    return true;
                }
                else if (mail.Equals(string.Empty))
                {
                    throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.EMPTY_EMAIL, "Mail can't be Empty");
                }
                throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.INVALID_EMAIL, "Invalid Mail");
            }
            catch
            {
                throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.NULL_EMAIL,"Mail can't be Null");
            }
        }
        public bool ValidatePhoneNumber(string phoneNumber)
        {
            try
            {
                if (Regex.IsMatch(phoneNumber, REGEX_PHONENUMBER))
                {
                    return true;
                }
                else if (phoneNumber.Equals(string.Empty))
                {
                    throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.EMPTY_PHONE_NUMBER, "PhoneNumber cant be Empty");
                }
                throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.INVALID_PHONE_NUMBER, "Invalid Phone Number");
            }
            catch
            {
                throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.NULL_PHONE_NUMBER,"PhoneNumber cant be nul");
            }
        }

        public bool ValidatePassword(string password)
        {
            try
            {
                if( Regex.IsMatch(password, REGEX_PASSWORD))
                {
                    return true;
                }
                else if(password.Equals(string.Empty))
                {
                    throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.EMPTY_PASSWORD,"Password cant be empty");
                }
                throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.INVALID_PASSWORD,"Invlid Password");
            }catch
            {
                throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.NULL_PASSWORD,"Password cant be Null");
            }
        }
    }
}


