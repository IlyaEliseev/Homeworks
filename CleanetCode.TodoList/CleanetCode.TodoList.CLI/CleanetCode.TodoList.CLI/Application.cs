using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI
{
	internal class Application
	{
		private readonly Menu _menu;

		public Application(Menu menu)
		{
			_menu = menu;
			FileService.ReadUsersIntoFile();
			FileService.ReadTasksIntoFile();
		}

		public void Run()
		{
			bool isUserQuit = false;

			while (!isUserQuit)
			{
				List<string> operationNames = new List<string>();
				operationNames.Add("q - exit the program");
				operationNames.AddRange(_menu.GetOperationNames());

				Console.WriteLine(string.Join("\n", operationNames));
				Console.Write("Input operation number: ");

				string? userInput = Console.ReadLine();
				if (userInput != null && userInput.Trim().ToLower() == "q")
				{
					isUserQuit = true;

				}

				bool isNumber = int.TryParse(userInput, out int operationNumber);
				if (isNumber)
				{
					_menu.Enter(operationNumber);
				}
                else
                {
					ColorMessage.SetRedColor("You input not number");
                }
			}
		}
	}
}
