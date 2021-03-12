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
        }
    }
}
