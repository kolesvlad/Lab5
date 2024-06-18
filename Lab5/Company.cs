namespace Lab5;

public class Company
{
    public string OfficialName { get; set; }
    
    public List<string> Synonyms { get; set; }

    public Company(string officialName, List<string> synonyms)
    {
        OfficialName = officialName;
        Synonyms = synonyms;
    }

    public void SaveToJson()
    {
        
    }
}