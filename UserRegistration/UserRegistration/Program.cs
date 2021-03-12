using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateUserDetails validateUserDetails = new ValidateUserDetails();
            Console.WriteLine("Your Match :" + validateUserDetails.validateFirstName("Neha"));            
        }
    }
}
