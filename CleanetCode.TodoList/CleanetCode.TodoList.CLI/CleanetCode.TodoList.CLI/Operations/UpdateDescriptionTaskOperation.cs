using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations
{
    public class UpdateDescriptionTaskOperation : IOperation
    {
        public string Name => "Update task description";

        public void Execute()
        {
            if (UserSession.Login == true)
            {
                Console.WriteLine("Input task Id: ");
                string userInput = Console.ReadLine();

                bool isNumber = int.TryParse(userInput, out int taskId);

                if (isNumber)
                {
                    Console.WriteLine("Input new task Description:");
                    string newName = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(newName))
                    {
                        TaskModel task = TaskStorage.GetById(taskId);
                        task.Name = newName;
                    }
                    else
                    {
                        Console.WriteLine("Uncorrect description! Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong id!");
                }
            }
            else
            {
                Console.WriteLine("Please login!");
            }
        }
    }
}
