using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        ValidateUserDetails validateUserDetails = new ValidateUserDetails();

        [TestMethod]
        public void Test_First_Name()
        {
            bool expectedResult = true;
            bool result = validateUserDetails.validateFirstName("Neha");
            Assert.AreEqual(expectedResult,result);
        }
    }
}
