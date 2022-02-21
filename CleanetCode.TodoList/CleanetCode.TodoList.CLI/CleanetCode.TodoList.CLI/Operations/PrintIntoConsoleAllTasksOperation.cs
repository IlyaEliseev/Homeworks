using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations
{
    public class PrintIntoConsoleAllTasksOperation : IOperation
    {
        public string Name => "Print into console";

        public void Execute()
        {
            List<TaskModel> tasks = TaskStorage.GetAll();

            tasks.ForEach(task =>
            {
                Console.WriteLine();
                Console.WriteLine($"Id: {task.InStorrageId}" +
                                  $" Name: {task.Name} " +
                                  $" Description: {task.Description}" +
                                  $" Task complite status: {task.IsCompleted}" +
                                  $" Create time: {task.CreatedDate}");
                Console.WriteLine();
            });
        }
    }
}
