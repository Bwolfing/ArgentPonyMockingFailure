using System;
using System.Threading.Tasks;
using ArgentPonyWarcraftClient;
using Moq;
using NUnit.Framework;

namespace ArgentPonyTest
{
    [TestFixture]
    public class Test
    {
        private Mock<WarcraftClient> _mockClient;

        private ClassToTest _fixture;

        [SetUp]
        public void SetUp()
        {
            _mockClient = new Mock<WarcraftClient>();

            _fixture = new ClassToTest(_mockClient.Object);
        }

        [Test]
        public async Task If_Request_Is_Successful_Then_Guild_Name_Is_Returned()
        {

        }
    }
}
