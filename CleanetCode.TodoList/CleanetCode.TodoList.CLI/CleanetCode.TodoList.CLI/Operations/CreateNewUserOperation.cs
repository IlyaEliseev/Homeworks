using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations
{
    public class CreateNewUserOperation : IOperation
    {
		public string Name => "Create new user";

		public void Execute()
		{
            Console.Write("Input your email: ");
			string email = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(email))
            {
				User newUser = new User
				{
					Id = Guid.NewGuid(),
					Email = email
				};

				bool userCreated = UserStorage.Create(newUser);
				if (!userCreated)
				{
					ColorMessage.SetRedColor("User with this email is already exists");
				}

				ColorMessage.SetGreenColor("User create");
			}
            else
            {
				ColorMessage.SetRedColor("Email should not be null or white space");
            }
		}
	}
}
