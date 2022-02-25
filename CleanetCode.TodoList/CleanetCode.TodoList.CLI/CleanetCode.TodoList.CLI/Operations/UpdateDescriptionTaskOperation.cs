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
                string newDescription = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(newDescription))
                {
                    TaskModel task = TaskStorage.GetById(taskId);
                    task.Description = newDescription;
                    ColorMessage.SetGreenColor("You change description");
                }
                else
                {
                    ColorMessage.SetRedColor("Description should not be null or white space! Try again");
                }
            }
            else
            {
                ColorMessage.SetRedColor("Wrong id");
            }
        }
    }
}
