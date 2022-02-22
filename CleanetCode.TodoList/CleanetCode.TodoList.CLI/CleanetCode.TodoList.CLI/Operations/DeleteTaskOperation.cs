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
                ColorMessage.SetGreenColor("Input task Id: ");
                string userInput = Console.ReadLine();

                bool isNumber = int.TryParse(userInput, out int number);

                if (isNumber)
                {
                    TaskModel compliteTask = TaskStorage.GetById(number);
                    if (compliteTask != null)
                    {
                        compliteTask.DeletedDate = DateTime.Now;
                        ColorMessage.SetGreenColor("Task delete!");
                    }
                    else
                    {
                        ColorMessage.SetRedColor("Id is not found!");
                    }
                }
                else
                {
                    ColorMessage.SetRedColor("Wrong id!");
                }
            }
            else
            {
                ColorMessage.SetRedColor("Please login!");
            }
        }
    }
}
