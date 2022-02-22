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
                            UserStorage.Create(data.Value);
                            //Dictionary<string, User> users = UserStorage.GetAll();
                            //users.Add(data.Key, data.Value);
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
                            //List<TaskModel> tasks = TaskStorage.GetAll();
                            //tasks.ReadIntoFile(data);
                        }
                    }
                }
            }
        }
    }
}

//﻿using Newtonsoft.Json;
//using Shop.Models;
//using System.Collections.Generic;
//using System.IO;
//using JsonSerializer = Newtonsoft.Json.JsonSerializer;

//namespace Shop.Controllers
//{
//    public class FilesController
//    {
//        public string ProductsFilePath => @"D:\projects\CsharpForBeginners\Shop\Shop\Data\Products.json";
//        public string ShowcasesFilePath => @"D:\projects\CsharpForBeginners\Shop\Shop\Data\Showcases.json";
//        public string ArchiveProductsFilePath => @"D:\projects\CsharpForBeginners\Shop\Shop\Data\ArchiveProducts.json";

//        JsonSerializer serializer = new JsonSerializer();

//        public void WriteToFile(IProductController productController, IShowcaseController showcaseController, IProductArchiveController productArchiveController)
//        {
//            using (StreamWriter sw = new StreamWriter(ProductsFilePath))
//            using (JsonWriter jw = new JsonTextWriter(sw))
//            {

//                jw.Formatting = Formatting.Indented;
//                var data = productController.GetProducts();
//                serializer.Serialize(jw, data);
//            }

//            using (StreamWriter sw = new StreamWriter(ShowcasesFilePath))
//            using (JsonWriter jw = new JsonTextWriter(sw))
//            {

//                jw.Formatting = Formatting.Indented;
//                var data = showcaseController.GetShowcases();
//                serializer.Serialize(jw, data);
//            }

//            using (StreamWriter sw = new StreamWriter(ArchiveProductsFilePath))
//            using (JsonWriter jw = new JsonTextWriter(sw))
//            {

//                jw.Formatting = Formatting.Indented;
//                var data = productArchiveController.GetArchiveProducts();
//                serializer.Serialize(jw, data);
//            }
//        }

//        public void ReadFromFile(IProductController productController, IShowcaseController showcaseController, IProductArchiveController productArchiveController)
//        {
//            using (StreamReader sr = File.OpenText(ProductsFilePath))
//            {
//                string json = sr.ReadToEnd();
//                List<Product> deseializeData = JsonConvert.DeserializeObject<List<Product>>(json);
//                if (deseializeData != null)
//                {
//                    foreach (var data in deseializeData)
//                    {
//                        productController.AddDataFromFile(data);
//                    }
//                }
//            }

//            using (StreamReader sr = File.OpenText(ShowcasesFilePath))
//            {
//                string json = sr.ReadToEnd();
//                List<Showcase> deseializeData = JsonConvert.DeserializeObject<List<Showcase>>(json);

//                if (deseializeData != null)
//                {
//                    foreach (var data in deseializeData)
//                    {
//                        showcaseController.AddDataFromFile(data);
//                    }

//                }
//            }

//            using (StreamReader sr = File.OpenText(ArchiveProductsFilePath))
//            {
//                string json = sr.ReadToEnd();
//                List<Product> deseializeData = JsonConvert.DeserializeObject<List<Product>>(json);

//                if (deseializeData != null)
//                {
//                    foreach (var data in deseializeData)
//                    {
//                        productArchiveController.AddDataFromFile(data);
//                    }
//                }
//            }

//        }
//    }
//}
