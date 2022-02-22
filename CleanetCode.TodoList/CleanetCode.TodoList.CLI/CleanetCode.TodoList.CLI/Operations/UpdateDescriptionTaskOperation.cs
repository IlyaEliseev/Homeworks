using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations
{
    public class UpdateDescriptionTaskOperation : IOperation
    {
        public string Name => "Update task description";

        public void Execute()
        {
            Console.Write("Input task Id: ");
            string userInput = Console.ReadLine();

            bool isNumber = int.TryParse(userInput, out int taskId);

            if (isNumber && TaskStorage.GetAll().Count >= taskId)
            {
                Console.Write("Input new task Description: ");
                string newName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(newName))
                {
                    TaskModel task = TaskStorage.GetById(taskId);
                    task.Name = newName;
                }
                else
                {
                    ColorMessage.SetRedColor("Uncorrect description! Try again.");
                }
            }
            else
            {
                ColorMessage.SetRedColor("Wrong id!");
            }
        }
    }
}
