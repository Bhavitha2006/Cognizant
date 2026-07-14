using CustomerCommLib;
using Moq;
using NUnit.Framework;

namespace CustomerCommTests
{
    [TestFixture]
    public class CustomerCommTests
    {
        private Mock<IMailSender>? mockMailSender;
        private CustomerComm? customerComm;

        [OneTimeSetUp]
        public void Init()
        {
            mockMailSender = new Mock<IMailSender>();
            customerComm = new CustomerComm(mockMailSender.Object);
        }

        [TestCase]
        public void SendMailToCustomer_ReturnsTrue()
        {
            mockMailSender!
                .Setup(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            bool result = customerComm!.SendMailToCustomer();

            Assert.That(result, Is.True);
        }
    }
}