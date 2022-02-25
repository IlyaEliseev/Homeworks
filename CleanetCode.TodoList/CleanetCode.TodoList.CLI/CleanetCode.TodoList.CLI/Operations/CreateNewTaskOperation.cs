using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations

{
    public class CreateNewTaskOperation : IOperation
    {
        public string Name => "Create new task";

        public void Execute()
        {
            if (UserSession.Login == true)
            {
                Console.Write("Input task name: ");
                string taskName = Console.ReadLine();

                Console.Write("Input task description: ");
                string taskDescription = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(taskName) && !string.IsNullOrWhiteSpace(taskName))
                {
                    TaskModel task = new TaskModel
                    {
                        Id = Guid.NewGuid(),
                        Name = taskName,
                        Description = taskDescription,
                        UserId = UserSession.CurrentUser.Id,
                        CreatedDate = DateTime.Now
                    };

                    bool isCreatedSuccess = TaskStorage.Add(task);
                    if (!isCreatedSuccess)
                    {
                        ColorMessage.SetRedColor("Task create is not complited. Try again");
                    }

                    ColorMessage.SetGreenColor("Task create");
                }
                else
                {
                    ColorMessage.SetRedColor("Name and description should not be null or white space");
                }
            }
            else
            {
                ColorMessage.SetRedColor("Please login");
            }
        }
    }
}
