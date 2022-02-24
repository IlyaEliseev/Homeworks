using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI
{
	internal class Application
	{
		private readonly Menu _menu;

		public Application(Menu menu)
		{
			_menu = menu;
			FileService.ReadIntoFile();
		}

		public void Run()
		{
			bool isUserQuit = false;

			while (!isUserQuit)
			{
				List<string> operationNames = new List<string>();
				operationNames.Add("q - выйти из программы");
				operationNames.AddRange(_menu.GetOperationNames());

				Console.WriteLine(string.Join("\n", operationNames));
				Console.Write("Введите номер операции: ");

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
			}
		}
	}
}
