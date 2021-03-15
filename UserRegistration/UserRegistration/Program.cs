using System;

namespace UserRegistration
{
   public class Program
    {
        static void Main(string[] args)
        {           
            ValidateUserDetails validateUserDetails = new ValidateUserDetails();
            Console.WriteLine("Your First Name Match :" + validateUserDetails.validateFirstName("Neha"));
            Console.WriteLine("Your Last Name Match :" + validateUserDetails.validateLastName("Kotarwar"));
            Console.WriteLine("Your Mail Match :" + validateUserDetails.validateEmail("abc.xyz@bl.co.in"));
            Console.WriteLine("Your Phone Number Match :" + validateUserDetails.validatePhoneNumber("91 9919819801"));
            Console.WriteLine("Your Password Match :" + validateUserDetails.validatePassword("Neha12348"));
            Console.WriteLine("Your Mail Match :" + validateUserDetails.validateEmail("abc.100@yahoo.com"));
            Console.WriteLine("Your Mail Match :" + validateUserDetails.validateEmail("abc.111@abc.com"));
            Console.WriteLine("Your Mail Match :" + validateUserDetails.validateEmail("abc.100@abc.net"));
            Console.WriteLine("Your Mail Match :" + validateUserDetails.validateEmail("abc.100@abc.com.au"));
            Console.WriteLine("Your Mail Match :" + validateUserDetails.validateEmail("abc@1.com"));
            Console.WriteLine("Your Mail Match :" + validateUserDetails.validateEmail("abc@gmail.com.com"));
            Console.WriteLine("Your Mail Match :" + validateUserDetails.validateEmail("abc+100@gmail.com"));
        }
    }
}
