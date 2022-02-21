using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations
{
    public class UpdateTaskOperation : IOperation
    {
        public UpdateTaskOperation()
        {
            
        }

        public string Name => "Update task";

        public void Execute()
        {
            IOperation[] _operations = new IOperation[]
            {
                new UpdateNameTaskOperation(),
                new UpdateDescriptionTaskOperation()
            };

            List<string> operationNames = new List<string>();

            for (int i = 0; i < _operations.Length; i++)
            {
                operationNames.Add($"{i} - {_operations[i].Name}");
            }

            Console.WriteLine(string.Join("\n", operationNames));
            Console.Write("Введите номер операции: ");

            string userInput = Console.ReadLine();
            bool isNumber = int.TryParse(userInput, out int operationNumber);
            if (isNumber)
            {
                _operations[operationNumber].Execute();
            }

            //Console.WriteLine("Input new task name:");
            //string taskName = Console.ReadLine();
            //Console.WriteLine("Input new task description:");
            //string taskDescription = Console.ReadLine();

            //string userInput = Console.ReadLine();

            //bool isNumber = int.TryParse(userInput, out int taskId);
            //if (isNumber)
            //{
            //    TaskModel task = TaskStorage.GetById(taskId);
            //}
        }
    }
}
