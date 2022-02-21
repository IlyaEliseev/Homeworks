using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations
{
    public class CompleteTaskOperation : IOperation
    {
        public string Name => "Complete task";

        public void Execute()
        {
            Console.WriteLine("Input task Id: ");
            string userInput = Console.ReadLine();

            bool isNumber = int.TryParse(userInput, out int number);

            if (UserSession.Login == true)
            {
                
            }
            else
            {
                Console.WriteLine("Please login!");
            }


            if (isNumber)
            {
                TaskModel compliteTask = TaskStorage.GetById(number);
                if (compliteTask != null)
                {
                    compliteTask.IsCompleted = true;
                }
                else
                {
                    Console.WriteLine("Id is not found!");
                }
            }
            else
            {
                Console.WriteLine("Wrong id!");
            }
        }
    }
}
