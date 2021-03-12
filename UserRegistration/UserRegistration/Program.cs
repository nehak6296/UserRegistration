using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateUserDetails validateUserDetails = new ValidateUserDetails();
            Console.WriteLine("Your First Name Match :" + validateUserDetails.validateFirstName("Neha"));
            Console.WriteLine("Your Last Name Match :" + validateUserDetails.validateLastName("Kotarwar"));
            Console.WriteLine("Your Mail Match :" + validateUserDetails.validateEmail("abc.xyz@bl.co.in"));
            Console.WriteLine("Your Phone Number Match :" + validateUserDetails.validatePhoneNumber("91 9919819801"));
            Console.WriteLine("Your Password Match :" + validateUserDetails.validatePassword("NehaK1234"));

        }
    }
}
