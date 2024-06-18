using System.Text.Json;

namespace Lab5;

public class Company
{
    
    public string OfficialName { get; set; }
    
    public List<string> Synonyms { get; set; }
    
    public int MentionCount { get; set; }

    public List<string> MentionedTextFileNames { get; set; }
    
    public string Headquarters { get; set; }
    
    public int EmployeeCount { get; set; }
    
    public int OfficeCount { get; set; }

    public Company(string officialName, List<string> synonyms)
    {
        OfficialName = officialName;
        Synonyms = synonyms;
        MentionedTextFileNames = new List<string>();
    }

    public string ObtainJson()
    {
        return JsonSerializer.Serialize(this);
    }

    public void SetHeadquarters(string headquarters)
    {
        Headquarters = headquarters;
    }
    
    public void SetEmployeeCount(int employeeCount)
    {
        EmployeeCount = employeeCount;
    }
    
    public void SetOfficeCount(int officeCount)
    {
        OfficeCount = officeCount;
    }
}