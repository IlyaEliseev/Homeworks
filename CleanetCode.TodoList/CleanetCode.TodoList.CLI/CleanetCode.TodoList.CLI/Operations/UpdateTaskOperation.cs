using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations
{
    public class UpdateTaskOperation : IOperation
    {
        public string Name => "Update task";

        public void Execute()
        {
            string userInput = Console.ReadLine();

            bool isNumber = int.TryParse(userInput, out int taskId);
            if (isNumber)
            {
                TaskModel task = TaskStorage.GetById(taskId);
            }

            
                
            
        }
    }
}
