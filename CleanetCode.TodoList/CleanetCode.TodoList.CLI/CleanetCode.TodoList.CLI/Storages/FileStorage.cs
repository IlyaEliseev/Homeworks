using CleanetCode.TodoList.CLI.Models;
using Newtonsoft.Json;

namespace CleanetCode.TodoList.CLI.Storages
{
    public class FileStorage
    {
        private static string UsersFilePath => @"D:\projects\Homeworks\CleanetCode.TodoList\CleanetCode.TodoList.CLI\CleanetCode.TodoList.CLI\Users.json";

        public static string TasksFilePath => @"D:\projects\Homeworks\CleanetCode.TodoList\CleanetCode.TodoList.CLI\CleanetCode.TodoList.CLI\Tasks.json";

        static JsonSerializer serializer = new JsonSerializer();

        public static void WriteToFile()
        {
            //write users
            using (StreamWriter sw = new StreamWriter(UsersFilePath))
            using (JsonWriter jw = new JsonTextWriter(sw))
            {

                jw.Formatting = Formatting.Indented;
                Dictionary<string, User> data = UserStorage.GetAll();
                serializer.Serialize(jw, data);
            }

            //write tasks
            using (StreamWriter sw = new StreamWriter(TasksFilePath))
            using (JsonWriter jw = new JsonTextWriter(sw))
            {

                jw.Formatting = Formatting.Indented;
                List<TaskModel> data = TaskStorage.GetAll();
                serializer.Serialize(jw, data);
            }
        }

        public static void ReadIntoFile()
        {
            //Read users
            if (File.Exists(UsersFilePath))
            {
                using (StreamReader sr = File.OpenText(UsersFilePath))
                {
                    string json = sr.ReadToEnd();
                    Dictionary<string, User> deserializeData = JsonConvert.DeserializeObject<Dictionary<string, User>>(json);
                    if (deserializeData != null)
                    {
                        foreach (var data in deserializeData)
                        {
                            UserStorage.ReadIntoFile(data);
                        }
                    }
                }
            }

            //Read task
            if (File.Exists(TasksFilePath))
            {
                using (StreamReader sr = File.OpenText(TasksFilePath))
                {
                    string json = sr.ReadToEnd();
                    List<TaskModel> deserializeData = JsonConvert.DeserializeObject<List<TaskModel>>(json);
                    if (deserializeData != null)
                    {
                        foreach (var data in deserializeData)
                        {
                            TaskStorage.ReadIntoFile(data);
                        }
                    }
                }
            }
        }
    }
}


