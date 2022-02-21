using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace CleanetCode.TodoList.CLI.Operations
{
    public class LoginUserOperation : IOperation
    {
		public string Name => "Login into system";

		public void Execute()
		{
			Console.Write("Input youre email:");
			string? email = Console.ReadLine();
			User? user = UserStorage.Get(email);

			if (user != null)
			{
				UserSession.CurrentUser = user;
			}
            else
            {
                Console.WriteLine("User not found!");
            }
		}
	}
}
