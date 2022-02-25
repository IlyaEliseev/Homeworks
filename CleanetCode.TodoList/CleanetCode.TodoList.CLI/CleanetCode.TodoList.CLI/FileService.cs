using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;
using Newtonsoft.Json;

namespace CleanetCode.TodoList.CLI
{
    public class FileService
    {
        private static readonly string _workingDirectory = Environment.CurrentDirectory;
        private static readonly string _projectDirectory = Directory.GetParent(_workingDirectory).Parent.Parent.FullName;

        private static readonly string _usersFileName = "Users.json";
        private static readonly string _tasksFileName = "Tasks.json";

        private static readonly string _usersFilePath = Path.GetFullPath(_usersFileName, _projectDirectory);
        private static readonly string  _tasksFilePath = Path.GetFullPath(_tasksFileName, _projectDirectory);

        static JsonSerializer serializer = new JsonSerializer();
        public static void WriteUsersToFile()
        {
            using (StreamWriter sw = new StreamWriter(_usersFilePath))
            using (JsonWriter jw = new JsonTextWriter(sw))
            {

                jw.Formatting = Formatting.Indented;
                Dictionary<string, User> data = UserStorage.GetAll();
                serializer.Serialize(jw, data);
            }
        }

        public static void WriteTasksToFile()
        {
            using (StreamWriter sw = new StreamWriter(_tasksFilePath))
            using (JsonWriter jw = new JsonTextWriter(sw))
            {

                jw.Formatting = Formatting.Indented;
                List<TaskModel> data = TaskStorage.GetAll();
                serializer.Serialize(jw, data);
            }
        }

        public static void ReadUsersIntoFile()
        {
            if (File.Exists(_usersFilePath))
            {
                using (StreamReader sr = File.OpenText(_usersFilePath))
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
        }

        public static void ReadTasksIntoFile()
        {
            if (File.Exists(_tasksFilePath))
            {
                using (StreamReader sr = File.OpenText(_tasksFilePath))
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


