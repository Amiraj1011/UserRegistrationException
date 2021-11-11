using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationException;

namespace ExceptionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidFirstNameOfUser()
        {
            //AAA method
            //Arrange
            string message = " ";
            string expected = "invalid";
            //creating object of moodanalyzer class and passing message
            UserException exception = new UserException(message);

            //Act
            string actual = exception.ValidFirstName();

            //Assert
            //comparing actual and expected value
            Assert.AreEqual(expected, actual);
        }
    }
}
