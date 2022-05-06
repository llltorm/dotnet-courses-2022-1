using System;
using System.IO;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Threading;

namespace Task2
{
    class Program
    {
        public static string Path;
        public static string DestPath;
        public static void Main(string[] args)
        {
            //IConfigurationRoot configuration;
            try
            {
/*                configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();*/

                //var key = configuration.GetSection("settings");
                Path = @"E:\учёба\EPAM_DOTNET\New";
                //key["sourse"];
                DestPath = @"E:\учёба\EPAM_DOTNET\BacksUp";
                     //key["savepath"];
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


            CopyFolder(DateTime.Now);
            using var watcher = new FileSystemWatcher(Path);

            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;
            watcher.Filter = "*.*";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
            watcher.Changed += OnChanged;
            watcher.Created += OnCreated;
            watcher.Deleted += OnDeleted;
            watcher.Renamed += OnRenamed;

            Console.WriteLine("Выход - q\n" +
                    "Отслеживать папку - start\n" +
                    "Остановить отслеживание - stop\n" +
                    "Откат файла - reload\n");
            while (true)
            {
                string key = Console.ReadLine();

                if (key == "q")
                {
                    break;
                }
                if (key == "start")
                {
                    watcher.EnableRaisingEvents = true;
                }
                if (key == "stop")
                {
                    watcher.EnableRaisingEvents = false;
                }
                if (key == "reload")
                {
                    watcher.EnableRaisingEvents = false;
                    Reload();
                    Thread.Sleep(10);
                    watcher.EnableRaisingEvents = true;
                }
            }


        }


        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            Console.WriteLine($"Changed: {e.FullPath}");
            CopyFolder(DateTime.Now);


        }

        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}";
            Console.WriteLine(value);
            CopyFolder(DateTime.Now);

        }

        private static void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Deleted: {e.FullPath}");
            CopyFolder(DateTime.Now);

        }


        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Renamed:");
            Console.WriteLine($"    Old: {e.OldFullPath}");
            Console.WriteLine($"    New: {e.FullPath}");
            CopyFolder(DateTime.Now);

        }


        public static void CopyFolder(DateTime dateTime)
        {
            string date = dateTime.ToString().Replace(":", ".");
            string copyPath = DestPath + @"\" + date;

            Directory.CreateDirectory(copyPath);

            foreach (string dirPath in Directory.GetDirectories(Path, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(Path, copyPath));

            foreach (string newPath in Directory.GetFiles(Path, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(Path, copyPath), true);
        }



        public static void Reload()
        {
            

            foreach (string dirPath in Directory.GetDirectories(DestPath, "*", SearchOption.TopDirectoryOnly))
            {
                int i = 1;
                string[] directories = dirPath.Split(@"\");
                
                 Console.WriteLine( directories[directories.Length - 1]);
                
            }
            string folder;
            while(true)
            { 
                Console.WriteLine("Введите дату");
                string point = Console.ReadLine();
                folder = DestPath + @"\" + point;
                if (!Directory.Exists(folder) || (String.IsNullOrEmpty(folder)))
                {
                    Console.WriteLine("Не существует");

                }
                else
                { 
                    break;
                }
            }

            
            foreach (string dirPath in Directory.GetDirectories(Path, "*", SearchOption.TopDirectoryOnly))
            {

                Directory.Delete(dirPath, true);

            }
            foreach (string filePath in Directory.GetFiles(Path))
            {
                File.Delete(filePath);
            }

            foreach (string dirPath in Directory.GetDirectories(folder, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(folder, Path));

            foreach (string newPath in Directory.GetFiles(folder, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(folder, Path), true);

        }
    }
}
