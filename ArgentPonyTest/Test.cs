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
            _mockClient = new Mock<WarcraftClient>(string.Empty);

            _fixture = new ClassToTest(_mockClient.Object);
        }

        [Test]
        public async Task If_Request_Is_Successful_Then_Guild_Name_Is_Returned()
        {
            const string expectedGuildName = "The example guild";

            var request = new RequestResult<Character>(new Character
            {
                Guild = new CharacterGuild
                {
                    Name = expectedGuildName
                }
            });

            _mockClient.Setup(c => c.GetCharacterAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CharacterFields>()))
                .ReturnsAsync(request);

            Assert.That(await _fixture.GetGuildNameForCharacter(string.Empty, String.Empty), Is.EqualTo(expectedGuildName));
        }
    }
}
