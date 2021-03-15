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
    }
}
