using System.Diagnostics.SymbolStore;
using System.Text;

namespace Lab5;

public class FileManager
{

    public Dictionary<string, string> ReadTextFiles()
    {
        var result = new Dictionary<string, string>();
        
        string directoryName = "/Users/valdemar/Склад/Драгопед/Обʼєктно-орієнтоване програмування/Готове/Лаб5/test_news";
        var directory = new DirectoryInfo(directoryName);
        var subdirectories = directory.GetDirectories();
        
        Console.WriteLine("Subdirectories count = " + subdirectories.Length);
        
        foreach (var subdirectory in subdirectories)
        {
            foreach (var fileInfo in subdirectory.GetFiles())
            {
                if (result.ContainsKey(fileInfo.Name))
                {
                    var oldText = result[fileInfo.Name];
                    var newText = File.ReadAllText(fileInfo.FullName);
                    result[fileInfo.Name] = oldText + "/n" + newText;
                }
                else
                {
                    result.Add(fileInfo.Name, File.ReadAllText(fileInfo.FullName));
                }
            }
        }
        
        //Console.WriteLine(result["amilton-tops-belgian-gp-qualifying-for-fourth-consecutive-pole"]);

        return result;
    }

    public void WriteReportText(string fileName, string contents)
    {
        string directoryPath = "/Users/valdemar/Склад/Драгопед/Обʼєктно-орієнтоване програмування/Готове/Лаб5/Reports";
        string filePath = directoryPath + "/" + fileName;
        
        Directory.CreateDirectory(directoryPath);
        
        using StreamWriter writer = new StreamWriter(filePath);
        writer.Write(contents);
    }
}