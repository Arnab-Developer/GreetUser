using System;

namespace GitHubPackageNuget.Lib
{
    public class HelloService : IHelloService
    {
        string IHelloService.GetHelloMessage(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentException("User name can't be blank.");
            }
            string userNameTrimmed = userName.Trim();
            string helloMessage = $"Hello {userNameTrimmed}";
            return helloMessage;
        }
    }
}
