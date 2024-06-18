namespace Lab5;

public class Company
{
    public string OfficialName { get; set; }
    
    public List<string> Synonyms { get; set; }
    
    public int MentionCount { get; set; }

    public List<string> MentionedTextFileNames = new();

    public Company(string officialName, List<string> synonyms)
    {
        OfficialName = officialName;
        Synonyms = synonyms;
    }

    public void SaveToJson()
    {
        
    }

    public override string ToString()
    {
        return $"{nameof(OfficialName)}: {OfficialName}, {nameof(MentionCount)}: {MentionCount}";
    }
}