namespace GreetUser.Lib
{
    public class HelloService : IHelloService
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
