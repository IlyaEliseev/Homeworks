using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations
{
    public class CompleteTaskOperation : IOperation
    {
        public string Name => "Complete task";

        public void Execute()
        {
            if (UserSession.Login)
            {
                Console.Write("Input task Id: ");
                string userInput = Console.ReadLine();

                bool isNumber = int.TryParse(userInput, out int taskId);

                if (isNumber && TaskStorage.GetAll().Count >= taskId)
                {
                    TaskModel compliteTask = TaskStorage.GetById(taskId);
                    if (compliteTask != null)
                    {
                        compliteTask.IsCompleted = true;
                    }
                    else
                    {
                        ColorMessage.SetRedColor("Id is not found");
                    }
                }
                else
                {
                    ColorMessage.SetRedColor("Wrong id");
                }
            }
            else
            {
                ColorMessage.SetRedColor("Please login");
            }
        }
    }
}
