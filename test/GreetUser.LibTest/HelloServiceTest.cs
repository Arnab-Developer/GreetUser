using GreetUser.Lib;
using Xunit;

namespace GreetUser.LibTest
{
    public class HelloServiceTest
    {
        private readonly IHelloService _helloService;
        private const string _userName = "test user";
        private const string _userNameWithSpaceStart = " test user";
        private const string _userNameWithSpaceEnd = "test user  ";
        private const string _userNameWithSpaceBoth = " test user  ";

        public HelloServiceTest()
        {
            _helloService = new HelloService();
        }

        [Fact]
        public void Can_GetHelloMessage_WorkProperly()
        {
            string helloMessage = _helloService.GetHelloMessage(_userName);
            Assert.Equal("Hello test user", helloMessage);
        }

        [Fact]
        public void Can_GetHelloMessage_ReturnTrimmedMessageStart()
        {
            string helloMessage = _helloService.GetHelloMessage(_userNameWithSpaceStart);
            Assert.Equal("Hello test user", helloMessage);
        }

        [Fact]
        public void Can_GetHelloMessage_ReturnTrimmedMessageEnd()
        {
            string helloMessage = _helloService.GetHelloMessage(_userNameWithSpaceEnd);
            Assert.Equal("Hello test user", helloMessage);
        }

        [Fact]
        public void Can_GetHelloMessage_ReturnTrimmedMessageBoth()
        {
            string helloMessage = _helloService.GetHelloMessage(_userNameWithSpaceBoth);
            Assert.Equal("Hello test user", helloMessage);
        }

        [Fact]
        public void Can_GetHelloMessage_ReturnInvalidUserIfUserNameIsBlank()
        {
            string helloMessage = _helloService.GetHelloMessage("");
            Assert.Equal("User name can't be blank", helloMessage);
        }

        [Fact]
        public void Can_GetHelloMessage_ReturnInvalidUserIfUserNameIsSpace()
        {
            string helloMessage = _helloService.GetHelloMessage(" ");
            Assert.Equal("User name can't be blank", helloMessage);
        }

        [Fact]
        public void Can_GetHelloMessage_ReturnInvalidUserIfUserNameIsEmpty()
        {
            string helloMessage = _helloService.GetHelloMessage(string.Empty);
            Assert.Equal("User name can't be blank", helloMessage);
        }

        [Fact]
        public void Can_GetHelloMessage_ReturnInvalidUserIfUserNameIsNull()
        {
            string helloMessage = _helloService.GetHelloMessage(null);
            Assert.Equal("User name can't be blank", helloMessage);
        }
    }
}
