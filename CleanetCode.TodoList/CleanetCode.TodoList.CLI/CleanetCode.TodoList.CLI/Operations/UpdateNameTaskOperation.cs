﻿using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations
{
    public class UpdateNameTaskOperation : IOperation
    {
        public string Name => "Update task name";

        public void Execute()
        {
            Console.Write("Input task Id: ");
            string userInput = Console.ReadLine();

            bool isNumber = int.TryParse(userInput, out int taskId);

            if (isNumber && TaskStorage.GetAll().Count >= taskId)
            {
                Console.Write("Input new task name:");
                string newName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(newName))
                {
                    TaskModel task = TaskStorage.GetById(taskId);
                    task.Name = newName;
                }
                else
                {
                    ColorMessage.SetRedColor("Uncorrect name! Try again.");
                }
            }
            else
            {
                ColorMessage.SetRedColor("Wrong id!");
            }
        }
    }
}
