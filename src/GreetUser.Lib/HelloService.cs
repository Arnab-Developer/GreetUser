using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("GreetUser.LibTest")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace GreetUser.Lib
{
    internal class HelloService : IHelloService
    {
        string IHelloService.GetHelloMessage(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                return "User name can't be blank";
            }
            string userNameTrimmed = userName.Trim();
            string helloMessage = $"Hello {userNameTrimmed}";
            return helloMessage;
        }
    }
}
