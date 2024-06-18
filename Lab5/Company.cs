using System.Text.Json;

namespace Lab5;

public class Company
{
    public string OfficialName { get; set; }
    
    public List<string> Synonyms { get; set; }
    
    public int MentionCount { get; set; }

    public List<string> MentionedTextFileNames { get; set; }

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

    public override string ToString()
    {
        return $"{nameof(OfficialName)}: {OfficialName}, {nameof(MentionCount)}: {MentionCount}";
    }
}