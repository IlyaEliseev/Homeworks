﻿using CleanetCode.TodoList.CLI.Models;

namespace CleanetCode.TodoList.CLI.Storages
{
    public class TaskStorage
    {
        public static readonly List<TaskModel> _tasks = new List<TaskModel>();

        public static bool Add(TaskModel task)
        {
            if (task is null)
            {
                return false;
            }

            _tasks.Add(task);
            task.InStorrageId += 1;
            return true;
        }

        public static List<TaskModel> GetAllAtCurrentUser()
        {
            return _tasks
                .Where(x => x.UserId == UserSession.CurrentUser.Id)
                .Where(x => x.DeletedDate == null).ToList();
        }

        public static List<TaskModel> GetAll()
        {
            return _tasks;
        }

        public static TaskModel? GetById(int taskId)
        {
            if (taskId == default)
            {
                Console.WriteLine("Task is not found!");
            }

            return _tasks.FirstOrDefault(x => x.InStorrageId == taskId);
        }
    }
}
