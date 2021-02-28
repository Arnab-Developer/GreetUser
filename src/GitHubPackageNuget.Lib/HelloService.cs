namespace GitHubPackageNuget.Lib
{
    public class HelloService : IHelloService
    {
        string IHelloService.GetHelloMessage(string userName)
        {
            string userNameTrimmed = userName.Trim();
            string helloMessage = $"Hello {userNameTrimmed}";
            return helloMessage;
        }
    }
}
