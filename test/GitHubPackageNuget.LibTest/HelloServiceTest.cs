using GitHubPackageNuget.Lib;
using System;
using Xunit;

namespace GitHubPackageNuget.LibTest
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
        public void CanGetHelloMessageWorkProperly()
        {
            string helloMessage = _helloService.GetHelloMessage(_userName);
            Assert.Equal("Hello test user", helloMessage);
        }

        [Fact]
        public void CanGetHelloMessageReturnTrimmedMessageStart()
        {
            string helloMessage = _helloService.GetHelloMessage(_userNameWithSpaceStart);
            Assert.Equal("Hello test user", helloMessage);
        }

        [Fact]
        public void CanGetHelloMessageReturnTrimmedMessageEnd()
        {
            string helloMessage = _helloService.GetHelloMessage(_userNameWithSpaceEnd);
            Assert.Equal("Hello test user", helloMessage);
        }

        [Fact]
        public void CanGetHelloMessageReturnTrimmedMessageBoth()
        {
            string helloMessage = _helloService.GetHelloMessage(_userNameWithSpaceBoth);
            Assert.Equal("Hello test user", helloMessage);
        }

        [Fact]
        public void CanGetHelloMessageThrowExceptionIfUserNameIsBlank()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                _helloService.GetHelloMessage("");
            });
        }

        [Fact]
        public void CanGetHelloMessageThrowExceptionIfUserNameIsEmpty()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                _helloService.GetHelloMessage(string.Empty);
            });
        }

        [Fact]
        public void CanGetHelloMessageThrowExceptionIfUserNameIsNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                _helloService.GetHelloMessage(null);
            });
        }
    }
}
