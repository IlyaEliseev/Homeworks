using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations
{
    public class DeleteTaskOperation : IOperation
    {
        public string Name => "Delete task";

        public void Execute()
        {
            if (UserSession.Login == true)
            {
                Console.WriteLine("Input task Id: ");
                string userInput = Console.ReadLine();

                bool isNumber = int.TryParse(userInput, out int number);

                if (isNumber)
                {
                    TaskModel compliteTask = TaskStorage.GetById(number);
                    if (compliteTask != null)
                    {
                        compliteTask.DeletedDate = DateTime.Now;
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
            else
            {
                Console.WriteLine("Please login!");
            }
        }
    }
}
