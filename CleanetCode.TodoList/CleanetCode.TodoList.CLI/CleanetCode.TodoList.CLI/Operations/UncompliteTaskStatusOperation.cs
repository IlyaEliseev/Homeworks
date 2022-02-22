using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations
{
    public class UncompliteTaskStatusOperation : IOperation
    {
        public string Name => "Uncomplite task status";

        public void Execute()
        {
            ColorMessage.SetGreenColor("Input task Id: ");
            string userInput = Console.ReadLine();

            bool isNumber = int.TryParse(userInput, out int taskId);

            if (isNumber)
            {
                TaskModel task = TaskStorage.GetById(taskId);
                task.IsCompleted = false;
                ColorMessage.SetGreenColor("Task uncomplite!");

            }
            else
            {
                ColorMessage.SetRedColor("Wrong id!");
            }
        }
    }
}
