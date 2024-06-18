using Lab5;

class Program
{
    static void Main()
    {
        var fileManager = new FileManager();
        var textAnalyzer = new TextAnalyzer();
        var reportGenerator = new ReportGenerator();
        
        var originalText = fileManager.ReadTextFiles();
        var preprocessedText = textAnalyzer.PreprocessText(originalText);
        var companies = textAnalyzer.ExtractCompaniesInfo(preprocessedText);
        
        reportGenerator.CreateReport(companies, fileManager);
    }
}