using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations

{
    public class CreateNewTaskOperation : IOperation
    {
        public string Name => "Create new task";

        public void Execute()
        {
            Console.WriteLine("Input task name: ");
            string taskName = Console.ReadLine();
            Console.WriteLine("Input task description: ");
            string taskDescription = Console.ReadLine();

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
                Console.WriteLine("Task create is not complited. Try again!");
            }

            Console.WriteLine("Task created!");
        }
    }
}
