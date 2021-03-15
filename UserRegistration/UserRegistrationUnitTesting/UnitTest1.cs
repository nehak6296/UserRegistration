using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        //Arrange
        ValidateUserDetails validateUserDetails = new ValidateUserDetails();
        bool expectedResult = true;

        [TestMethod]
        public void Test_First_Name()
        {
            //Act        
            bool result = validateUserDetails.validateFirstName("Neha");

            //Assert
            Assert.AreEqual(expectedResult,result);
        }

        [TestMethod]

        public void Test_Last_Name()
        {
            //Act
            bool result = validateUserDetails.validateLastName("Kotarwar");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]

        public void Test_Email()
        {
            //Act
            bool result = validateUserDetails.validateEmail("abc.xyz@bl.co.in");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_Phone_Number()
        {
            //Act
            bool result = validateUserDetails.validatePhoneNumber("91 9919819801");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_Password()
        {
            //Act
            bool result = validateUserDetails.validatePassword("Neha@12348");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_Password_1UpperCase()
        {
            //Act
            bool result = validateUserDetails.validatePassword("Neha@K12348");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_Password_1Number()
        {
            //Act
            bool result = validateUserDetails.validatePassword("Neha@12348");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_Password_1SpecialCharacter()
        {
            //Act
            bool result = validateUserDetails.validatePassword("Neha@1234");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_Multiple_Emails()
        {
            //Act

            bool result_One = validateUserDetails.validateEmail("abc.100@yahoo.com");
            bool result_Two = validateUserDetails.validateEmail("abc111@abc.com");
            bool result_Three = validateUserDetails.validateEmail("abc-100@abc.net");
            bool result_Four = validateUserDetails.validateEmail("abc.100@abc.com.au");
            bool result_Five = validateUserDetails.validateEmail("abc@1.com");
            bool result_Six = validateUserDetails.validateEmail("abc@gmail.com.com");
            bool result_Seven = validateUserDetails.validateEmail("abc-100@gmail.com");
            bool result_Eight = validateUserDetails.validateEmail("abc+100@yahoo.com");
            bool result_Nine = validateUserDetails.validateEmail("abc@yahoo.com");

            //Assert
            Assert.AreEqual(expectedResult, result_One);
            Assert.AreEqual(expectedResult, result_Two);
            Assert.AreEqual(expectedResult, result_Three);
            Assert.AreEqual(expectedResult, result_Four);
            Assert.AreEqual(expectedResult, result_Five);
            Assert.AreEqual(expectedResult, result_Six);
            Assert.AreEqual(expectedResult, result_Seven);
            Assert.AreEqual(expectedResult, result_Eight);
            Assert.AreEqual(expectedResult, result_Nine);



        }

    }
}
