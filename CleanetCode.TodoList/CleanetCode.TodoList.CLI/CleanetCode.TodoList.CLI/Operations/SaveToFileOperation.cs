﻿using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations
{
    public class SaveToFileOperation : IOperation
    {
        public string Name => "Save to file";

        public void Execute()
        {
            if (UserSession.Login == true)
            {
                FileStorage.WriteToFile();
                ColorMessage.SetGreenColor("You save data!");
            }
            else
            {
                ColorMessage.SetRedColor("Please login!");
            }
        }
    }
}
