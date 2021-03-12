using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class ValidateUserDetails
    {
        
        public static string REGEX_EMAIL = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        
        public bool validateEmail(string mail)
        {
            return Regex.IsMatch(mail, REGEX_EMAIL);
        }
        

    }
}

