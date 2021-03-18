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
                if(firstName == null)
                {
                    throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.NULL_NAME, "Null First Name");
                }
                else if (firstName.Equals(string.Empty))
                {
                    throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.EMPTY_NAME, "Empty First Name");

                }
                Regex.IsMatch(firstName, REGEX_FIRSTNAME);                
                return true;         
            }
            catch (NullReferenceException)
            {
                throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.INVALID_NAME, "Invalid First Name");

            }
            
        }       
        public bool ValidateLastName(string lastName)
        {
            try
            {
                if(lastName == null)
                {
                    throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.NULL_NAME, "Null Last Name");
                }
                else if (lastName.Equals(string.Empty))
                {
                    throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.EMPTY_NAME, "Empty Last Name");
                }
                Regex.IsMatch(lastName, REGEX_LASTNAME);
                return true;            
            }
            catch(NullReferenceException)
            {
                throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.INVALID_NAME, "Invalid Last Name");
            }
        }
        public bool ValidateEmail(string mail)
        {
            try
            {
                if(mail == null)
                {
                    throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.NULL_EMAIL, "Null Mail");
                }
                else if (mail.Equals(string.Empty))
                {
                    throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.EMPTY_EMAIL, "Empty Mail");
                }
                Regex.IsMatch(mail, REGEX_EMAIL);
                return true;          
            }
            catch(NullReferenceException)
            {
                throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.INVALID_EMAIL, "Invalid Mail");
            }
        }
        public bool ValidatePhoneNumber(string phoneNumber)
        {
            try
            {
                if(phoneNumber == null)
                {
                    throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.NULL_PHONE_NUMBER, "Null Phone Number");
                }               
                else if (phoneNumber.Equals(string.Empty))
                {
                    throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.EMPTY_PHONE_NUMBER, "Empty Phone Number");
                }
                Regex regex = new Regex(REGEX_PHONENUMBER);
                return regex.IsMatch(phoneNumber);
            }
            catch(NullReferenceException)
            {
                throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.INVALID_PHONE_NUMBER, "Invalid Phone Number");
            }
        }

        public bool ValidatePassword(string password)
        {
            try
            {
                if (password == null)
                {
                    throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.NULL_PASSWORD, "Null Password");
                }
                else if (password.Equals(string.Empty))
                {
                    throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.EMPTY_PASSWORD, "Empty Password");
                }
                Regex.IsMatch(password, REGEX_PASSWORD);
                return true;                            
                
            }
            catch(NullReferenceException)
            {
                throw new ValidateUserDetailsCustomException(ValidateUserDetailsCustomException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
            }
        }
    }
}


