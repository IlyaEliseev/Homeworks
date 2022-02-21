using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations
{
    public class UpdateTaskOperation : IOperation
    {
        private List<IOperation> _operations;
        public UpdateTaskOperation(IOperation[] operations)
        {
            _operations = new List<IOperation>();
        }

        public string Name => "Update task";

        public void Execute()
        {
            List<string> operationNames = new List<string>();

            for (int i = 0; i < operationNames.Count; i++)
            {
                operationNames.Add($"{i} - Update task name");
                operationNames.Add($"{i} - Update task description");
                operationNames.Add($"{i} - Update task status");
            }

            Console.WriteLine(string.Join("\n", operationNames));
            Console.Write("Введите номер операции: ");

            string? userInput = Console.ReadLine();
            //if (userInput != null && userInput.Trim().ToLower() == "q")
            //{
            //    isUserQuit = true;
            //}

            bool isNumber = int.TryParse(userInput, out int operationNumber);
            if (isNumber)
            {
                _menu.Enter(operationNumber);
            }

            Console.WriteLine("Input new task name:");
            string taskName = Console.ReadLine();
            Console.WriteLine("Input new task description:");
            string taskDescription = Console.ReadLine();

            string userInput = Console.ReadLine();

            bool isNumber = int.TryParse(userInput, out int taskId);
            if (isNumber)
            {
                TaskModel task = TaskStorage.GetById(taskId);
            }
        }
    }
}
