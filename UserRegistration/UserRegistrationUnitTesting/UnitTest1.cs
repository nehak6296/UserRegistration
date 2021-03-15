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
            bool result = validateUserDetails.validatePassword("Neha12348");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_Password_1UpperCase()
        {
            //Act
            bool result = validateUserDetails.validatePassword("NehaK12348");

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_Password_1Number()
        {
            //Act
            bool result = validateUserDetails.validatePassword("Neha12348");

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

    }
}
