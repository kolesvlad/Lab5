﻿using Lab5;

class Program
{
    static void Main()
    {
        var fileManager = new FileManager();
        var textAnalyzer = new TextAnalyzer();
        
        var originalText = fileManager.ReadTextFiles();
        var preprocessedText = textAnalyzer.PreprocessText(originalText);
        var companies = textAnalyzer.ExtractCompaniesInfo(preprocessedText);
        
        Console.WriteLine(companies.Count);
        foreach (var company in companies)
        {
            Console.WriteLine(company);
        }
        
    }
}