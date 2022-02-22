using CleanetCode.TodoList.CLI.Models;

namespace CleanetCode.TodoList.CLI
{
    public class UserSession
    {
        private static readonly Dictionary<string, List<TaskModel>> _session = new();    
        public static User CurrentUser { get; set; }
        public static bool Login = false;

        public static bool Create()
        {
            return true;
        }

    }
}
