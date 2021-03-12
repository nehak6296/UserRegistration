using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateUserDetails validateUserDetails = new ValidateUserDetails();
            
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
