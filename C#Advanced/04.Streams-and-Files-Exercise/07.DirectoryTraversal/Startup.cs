using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _07.DirectoryTraversal
{
    public class Startup
    {
        public static void Main()
        {
            Console.Write("Please enter a path (full or relative): ");
            string path = Console.ReadLine();

            try
            {
                var files = GetFilesFromDirectory(path);

                var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                CreateReport(files, desktopPath);
                Console.WriteLine("A report was successfully made on the desktop, under the name of report.txt");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Oops something went wrong: {0}", ex.Message);
            }

        }

        private static void CreateReport(Dictionary<string, Dictionary<string, long>> files, string dir)
        {
            var report = Path.Combine(dir, "report.txt");

            using (var writer = new StreamWriter(report))
            {
                foreach (var group in files
                    .OrderByDescending(g => g.Value.Count).ThenBy(g => g.Key))
                {
                    var filesInGroup = string.Join(Environment.NewLine, group.Value
                        .OrderByDescending(f => f.Value)
                        .Select(kvp => $"\t--{kvp.Key} - {kvp.Value}kb"));

                    writer.Write($"{group.Key}{Environment.NewLine}{filesInGroup}{Environment.NewLine}");
                }
            }
        }

        private static Dictionary<string, Dictionary<string, long>> GetFilesFromDirectory(string path)
        {
            //string root = Directory.(path);

            var files = Directory.GetFiles(path);

            // Dictionary<extension, Dictionary<filePath, fileSize>>
            var result = new Dictionary<string, Dictionary<string, long>>();

            foreach (var file in files)
            {
                var extension = Path.GetExtension(file);
                var fileSize = new FileInfo(file).Length;

                if (!result.ContainsKey(extension))
                {
                    result[extension] = new Dictionary<string, long>();
                }

                result[extension][file] = fileSize;
            }

            return result;
        }
    }
}
