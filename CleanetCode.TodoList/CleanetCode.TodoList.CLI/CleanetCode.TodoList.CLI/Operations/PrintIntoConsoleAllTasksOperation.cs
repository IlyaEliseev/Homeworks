using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations
{
    public class PrintIntoConsoleAllTasksOperation : IOperation
    {
        public string Name => "Print into console";

        public void Execute()
        {
            if (UserSession.Login == true)
            {
                List<TaskModel> tasks = TaskStorage.GetAllAtCurrentUser();

                tasks.ForEach(task =>
                {
                    Console.WriteLine($"Id: {task.InStorrageId}" +
                                      $" Name: {task.Name} " +
                                      $" Description: {task.Description}" +
                                      $" Task complite status: {task.IsCompleted}" +
                                      $" Create time: {task.CreatedDate}");
                });
            }
            else
            {
                ColorMessage.SetRedColor("Please login");
            }
        }
    }
}
