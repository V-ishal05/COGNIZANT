using Moq;
using NUnit.Framework;
using CustomerCommLib;

namespace CustomerComm.Tests
{
    [TestFixture]
    public class CustomerCommTests
    {
        [Test]
        public void SendMailToCustomer_ShouldReturnTrue()
        {
            // Arrange
            Mock<IMailSender> mockMailSender = new Mock<IMailSender>();

            mockMailSender
                .Setup(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            CustomerCommLib.CustomerComm customer =
    new CustomerCommLib.CustomerComm(mockMailSender.Object);
            // Act
            bool result = customer.SendMailToCustomer();

            // Assert
            Assert.That(result, Is.True);
        }
    }
}