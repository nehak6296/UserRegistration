using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
namespace UnitTestUserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        //Arrange
        ValidateUserDetails validateUserDetails = new ValidateUserDetails();

        [TestMethod]
        public void validate_First_Name_Test()
        {
            bool expectedResult = true;
            //Act
            bool result = validateUserDetails.validateFirstName("Neha");

            //Assert
            Assert.AreEqual(expectedResult,result);
        }
    }
}
