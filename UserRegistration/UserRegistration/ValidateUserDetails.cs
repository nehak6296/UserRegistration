using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class ValidateUserDetails
    {
        public static string REGEX_FIRSTNAME = "^[A-Z][a-z]{2,}$";
        public static string REGEX_LASTNAME = "^[A-Z][a-z]{2,}$";
        public static string REGEX_EMAIL = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public static string REGEX_PHONENUMBER = "^(91[ ])?[7-9][0-9]{9}$"; //91 9919819801
        public bool validateFirstName(string firstName)
        {           
            return Regex.IsMatch(firstName , REGEX_FIRSTNAME);
        }

        public bool validateLastName(string lastName)
        {
            return Regex.IsMatch(lastName,REGEX_LASTNAME);
        }
        public bool validateEmail(string mail)
        {
            return Regex.IsMatch(mail, REGEX_EMAIL);
        }
        public bool validatePhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, REGEX_PHONENUMBER);
        }
    }
}

