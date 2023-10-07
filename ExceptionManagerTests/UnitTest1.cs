using AutoKillProcess;

namespace ExceptionManagerTests
{
    public class Tests
    { 
        [Test]
        [TestCase("Oops, This thing blew up!")]
        public void DisplayError_ReturnsMessage(string message)
        {
            var returnedMessage = ExceptionManager.DisplayError(message);

            Assert.That(returnedMessage, Is.EqualTo(message));
        }

        [Test]
        [TestCase("Oops, This thing blew up!")]
        public void DisplayError_SetsShowExceptionTrue(string message)
        {
            var returnedMessage = ExceptionManager.DisplayError(message);

            bool exceptionIsShowing = ExceptionManager.showLastException;

            Assert.IsTrue(exceptionIsShowing);
        }
    }
}