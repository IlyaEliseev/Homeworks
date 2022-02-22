using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations
{
    public class LoginUserOperation : IOperation
    {
		public string Name => "Login into system";

		public void Execute()
		{
			ColorMessage.SetGreenColor("Input youre email:");
			string? email = Console.ReadLine();
			User? user = UserStorage.Get(email);

			if (user != null)
			{
				UserSession.CurrentUser = user;
				UserSession.Login = true;
				ColorMessage.SetGreenColor("You login!");
			}
			else
            {
				ColorMessage.SetRedColor("User not found!");
            }
		}
	}
}
