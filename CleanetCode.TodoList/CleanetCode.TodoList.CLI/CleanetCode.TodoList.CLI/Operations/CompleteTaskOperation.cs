using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations
{
    public class CompleteTaskOperation : IOperation
    {
        public string Name => throw new NotImplementedException();

        public void Execute()
        {

            Console.WriteLine("Input task number: ");
            string userInput = Console.ReadLine();

            bool isNumber = int.TryParse(userInput, out int number);

            if (isNumber)
            {
                TaskModel compliteTask = TaskStorage.GetById(number);
                if (compliteTask != null)
                {
                    compliteTask.IsCompleted = true;
                }
            }
            else
            {
                Console.WriteLine("Wrong number!");
            }
        }
    }
}
