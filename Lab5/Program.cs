using Lab5;

class Program
{
    static void Main()
    {
        // Створення екземплярів класів
        var fileManager = new FileManager();
        var textAnalyzer = new TextAnalyzer();
        var reportGenerator = new ReportGenerator();
        
        // Читаємо файли з диска та записуємо в string
        var originalText = fileManager.ReadTextFiles();
        
        // Передпроцесинг тексту
        var preprocessedText = textAnalyzer.PreprocessText(originalText);
        
        // Витягування даних про компанії
        var companies = textAnalyzer.ExtractCompaniesInfo(preprocessedText);
        
        // Створення звіту
        reportGenerator.CreateReport(companies, fileManager);
    }
}