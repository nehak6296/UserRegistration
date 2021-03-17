using System;

namespace UserRegistration
{
   public class Program
    {
        static void Main(string[] args)
        {           
            ValidateUserDetails validateUserDetails = new ValidateUserDetails();
            Console.WriteLine("Your First Name Match :" + validateUserDetails.ValidateFirstName("neha"));
            Console.WriteLine("Your Last Name Match :" + validateUserDetails.ValidateLastName("Kotarwar"));
            Console.WriteLine("Your Mail Match :" + validateUserDetails.ValidateEmail("abc.xyz@bl.co.in"));
            Console.WriteLine("Your Phone Number Match :" + validateUserDetails.ValidatePhoneNumber("91 9919819801"));
            Console.WriteLine("Your Password Match :" + validateUserDetails.ValidatePassword("Neha@1234"));
            Console.WriteLine("Your Mail Match :" + validateUserDetails.ValidateEmail("abc.100@yahoo.com"));
            Console.WriteLine("Your Mail Match :" + validateUserDetails.ValidateEmail("abc.111@abc.com"));
            Console.WriteLine("Your Mail Match :" + validateUserDetails.ValidateEmail("abc.100@abc.net"));
            Console.WriteLine("Your Mail Match :" + validateUserDetails.ValidateEmail("abc.100@abc.com.au"));
            Console.WriteLine("Your Mail Match :" + validateUserDetails.ValidateEmail("abc@1.com"));
            Console.WriteLine("Your Mail Match :" + validateUserDetails.ValidateEmail("abc@gmail.com.com"));
            Console.WriteLine("Your Mail Match :" + validateUserDetails.ValidateEmail("abc+100@gmail.com"));
        }
    }
}
