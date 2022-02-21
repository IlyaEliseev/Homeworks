using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations
{
    public class UpdateNameTaskOperation : IOperation
    {
        public string Name => "Update task name";

        public void Execute()
        {
            Console.WriteLine("Input task Id: ");
            string userInput = Console.ReadLine();

            bool isNumber = int.TryParse(userInput, out int taskId);

            if (isNumber)
            {
                Console.WriteLine("Input new task name:");
                string newName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(newName))
                {
                    TaskModel task = TaskStorage.GetById(taskId);
                    task.Name = newName;

                }
                else
                {
                    Console.WriteLine("Uncorrect name! Try again.");
                }
            }
            else
            {
                Console.WriteLine("Wrong id!");
            }
        }
    }
}
