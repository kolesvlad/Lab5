namespace Lab5;

public class FileManager
{

    public Dictionary<string, string> ReadTextFiles()
    {
        var result = new Dictionary<string, string>();
        
        string directoryName = "/Users/valdemar/Склад/Драгопед/Обʼєктно-орієнтоване програмування/Готове/Лаб5/test_news/";
        DirectoryInfo directory;
        try
        {
            directory = new DirectoryInfo(directoryName);
        }
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
            return result;
        }
        
        
        var subdirectories = directory.GetDirectories();
        
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

        return result;
    }

    public void WriteReportText(string fileName, string contents)
    {
        string directoryPath = "/Users/valdemar/Склад/Драгопед/Обʼєктно-орієнтоване програмування/Готове/Лаб5/Reports";
        string filePath = directoryPath + "/" + fileName;
        
        Directory.CreateDirectory(directoryPath);
        
        using StreamWriter writer = new StreamWriter(filePath);
        try
        {
            writer.Write(contents);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            writer.Close();
        }
    }
}