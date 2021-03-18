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
        public void GivenFirstName_WhenValidate_Then_ReturnTrue()
        {
            //Act        
            bool result = validateUserDetails.ValidateFirstName("Neha");

            //Assert
            Assert.AreEqual(expectedResult,result);
        }

        [TestMethod]

        public void GivenLastName_WhenValidate_Then_ReturnTrue()
        {
            //Act
            bool result = validateUserDetails.ValidateLastName("Kotarwar");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]

        public void GivenEmail_WhenValidate_Then_ReturnTrue()
        {
            //Act
            bool result = validateUserDetails.ValidateEmail("abc.xyz@bl.co.in");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GivenPhoneNumber_WhenValidate_ThenReturnTrue()
        {
            //Act
            bool result = validateUserDetails.ValidatePhoneNumber("91 9919819801");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GivenPassword_WhenValidate_ThenReturnTrue()
        {
            //Act
            bool result = validateUserDetails.ValidatePassword("Neha@12348");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GivenPasswordUpperCase_WhenValidate_Then_ReturnTrue()
        {
            //Act
            bool result = validateUserDetails.ValidatePassword("Neha@K12348");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GivenPasswordDigit_WhenValidate_Then_ReturnTrue()
        {
            //Act
            bool result = validateUserDetails.ValidatePassword("Neha@12348");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GivenPasswordSpecialCharacter_WhenValidate_Then_ReturnTrue()
        {
            //Act
            bool result = validateUserDetails.ValidatePassword("Neha@1234");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GivenMultipleEmails_WhenValidate_Then_ReturnTrue()
        {
            //Act

            bool result_One = validateUserDetails.ValidateEmail("abc.100@yahoo.com");
            bool result_Two = validateUserDetails.ValidateEmail("abc111@abc.com");
            bool result_Three = validateUserDetails.ValidateEmail("abc-100@abc.net");
            bool result_Four = validateUserDetails.ValidateEmail("abc.100@abc.com.au");
            bool result_Five = validateUserDetails.ValidateEmail("abc@1.com");
            bool result_Six = validateUserDetails.ValidateEmail("abc@gmail.com.com");
            bool result_Seven = validateUserDetails.ValidateEmail("abc-100@gmail.com");
            bool result_Eight = validateUserDetails.ValidateEmail("abc+100@yahoo.com");
            bool result_Nine = validateUserDetails.ValidateEmail("abc@yahoo.com");

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

        [TestMethod]
        public void GivenEmptyFirstName_WhenValidate_ThenThrowCustomEmptyFirstNameException()
        {
            try
            {
                string firstName = "";
                bool result = validateUserDetails.ValidateFirstName(firstName);
            }
            catch (ValidateUserDetailsCustomException e)
            {
                Assert.AreEqual("Empty First Name", e.Message);
            }
           
        }

        [TestMethod]
        public void GivenInvalidFirstName_WhenValidate_ThenThrowCustomInvalidFirstNameException()
        {
            try
            {
                string firstName = "neha";
                bool result = validateUserDetails.ValidateFirstName(firstName);
            }
            catch (ValidateUserDetailsCustomException e)
            {
                Assert.AreEqual("Invalid First Name", e.Message);
            }

        }

        [TestMethod]
        public void GivenNullFirstName_WhenValidate_ThenThrowCustomNullFirstNameException()
        {
            try
            {
                string firstName = null;
                bool result = validateUserDetails.ValidateFirstName(firstName);
            }
            catch (ValidateUserDetailsCustomException e)
            {
                Assert.AreEqual("Null First Name", e.Message);
            }

        }
        [TestMethod]
        public void GivenEmptyLastName_WhenValidate_ThenThrowCustomEmptyLastNameException()
        {
            try
            {
                string lastName = "";
                bool result = validateUserDetails.ValidateLastName(lastName);
            }
            catch (ValidateUserDetailsCustomException e)
            {
                Assert.AreEqual("Empty Last Name", e.Message);
            }

        }
        

        [TestMethod]
        public void GivenInvalidLastName_WhenValidate_ThenThrowCustomInvalidLastNameException()
        {
            try
            {
                string lastName = "kotarwar";
                bool result = validateUserDetails.ValidateLastName(lastName);
            }
            catch (ValidateUserDetailsCustomException e)
            {
                Assert.AreEqual("Invalid Last Name", e.Message);
            }

        }
        [TestMethod]
        public void GivenNullLastName_WhenValidate_ThenThrowCustomNullLastNameException()
        {
            try
            {
                string lastName = null;
                bool result = validateUserDetails.ValidateLastName(lastName);
            }
            catch (ValidateUserDetailsCustomException e)
            {
                Assert.AreEqual("Null Last Name", e.Message);
            }

        }
        [TestMethod]
        public void GivenEmptyMail_WhenValidate_ThenThrowCustomEmptyMailException()
        {
            try
            {
                string mail = "";
                bool result = validateUserDetails.ValidateEmail(mail);
            }
            catch (ValidateUserDetailsCustomException e)
            {
                Assert.AreEqual("Empty Mail", e.Message);
            }

        }
        [TestMethod]
        public void GivenInvalidMail_WhenValidate_ThenThrowCustomInvalidMailException()
        {
            try
            {
                string mail = "neha@g.c";
                bool result = validateUserDetails.ValidateEmail(mail);
            }
            catch (ValidateUserDetailsCustomException e)
            {
                Assert.AreEqual("Invalid Mail", e.Message);
            }

        }
        [TestMethod]
        public void GivenNullMail_WhenValidate_ThenThrowCustomNullMailException()
        {
            try
            {
                string mail = null;
                bool result = validateUserDetails.ValidateEmail(mail);
            }
            catch (ValidateUserDetailsCustomException e)
            {
                Assert.AreEqual("Null Mail", e.Message);
            }

        }
        [TestMethod]
        public void GivenEmptyPhoneNumber_WhenValidate_ThenThrowCustomEmptyPhoneNumberException()
        {
            try
            {
                string phoneNumber = "";
                bool result = validateUserDetails.ValidatePhoneNumber(phoneNumber);
            }
            catch (ValidateUserDetailsCustomException e)
            {
                Assert.AreEqual("Empty Phone Number", e.Message);
            }

        }
        [TestMethod]
        public void GivenInvalidPhoneNumber_WhenValidate_ThenThrowCustomInvalidPhoneNumberException()
        {
            try
            {
                string phoneNumber = "63563";
                bool result = validateUserDetails.ValidatePhoneNumber(phoneNumber);
            }
            catch (ValidateUserDetailsCustomException e)
            {
                Assert.AreEqual("Invalid Phone Number", e.Message);
            }

        }

        [TestMethod]
        public void GivenNullPhoneNumber_WhenValidate_ThenThrowCustomNullPhoneNumberException()
        {
            try
            {
                string phoneNumber = null;
                bool result = validateUserDetails.ValidatePhoneNumber(phoneNumber);
            }
            catch (ValidateUserDetailsCustomException e)
            {
                Assert.AreEqual("Null Phone Number", e.Message);
            }

        }
        [TestMethod]
        public void GivenEmptyPassword_WhenValidate_ThenThrowCustomEmptyPasswordException()
        {
            try
            {
                string password = "";
                bool result = validateUserDetails.ValidatePassword(password);
            }
            catch (ValidateUserDetailsCustomException e)
            {
                Assert.AreEqual("Empty Password", e.Message);
            }

        }
        [TestMethod]
        public void GivenInvalidPassword_WhenValidate_ThenThrowCustomInvalidPasswordException()
        {
            try
            {
                string password = "nn23424";
                bool result = validateUserDetails.ValidatePassword(password);
            }
            catch (ValidateUserDetailsCustomException e)
            {
                Assert.AreEqual("Invalid Password", e.Message);
            }

        }
        [TestMethod]
        public void GivenNullPassword_WhenValidate_ThenThrowCustomNullPasswordException()
        {
            try
            {
                string password = null;
                bool result = validateUserDetails.ValidatePassword(password);
            }
            catch (ValidateUserDetailsCustomException e)
            {
                Assert.AreEqual("Null Password", e.Message);
            }

        }
    }
}
