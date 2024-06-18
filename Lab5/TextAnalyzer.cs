using System.Text.RegularExpressions;

namespace Lab5;

public class TextAnalyzer
{

    public Dictionary<string, string> PreprocessText(Dictionary<string, string> text)
    {
        foreach (var pair in text)
        {
            var noPunctuation = RemovePunctuation(pair.Value);
            var lowerCase = ToLowerCase(noPunctuation);
            text[pair.Key] = lowerCase;
        }

        return text;
    }

    private string RemovePunctuation(string input)
    {
        return new string(input.ToCharArray().Where(c => !char.IsPunctuation(c)).ToArray());
    }

    private string ToLowerCase(string input)
    {
        return input.ToLower();
    }

    public List<Company> ExtractCompaniesInfo(Dictionary<string, string> text)
    {
        var result = new List<Company>();

        foreach (var pair in text)
        {
            var companyName = GetFirstWord(pair.Key);

            if (!result.Select(company => company.OfficialName).Contains(companyName))
            {
                result.Add(new Company(companyName, []));
            }
        }

        foreach (var company in result)
        {
            foreach (var pair in text)
            {
                Regex regex = new Regex(company.OfficialName);
                var matchCount = regex.Matches(pair.Value).Count;
                company.MentionCount += matchCount;
                if (matchCount > 0)
                {
                    company.MentionedTextFileNames.Add(pair.Key);
                }
            }
        }

        return result;
    }

    private string GetFirstWord(string input)
    {
        var chunks = input.Split("-");
        foreach (var chunk in chunks)
        {
            if (chunk.Length > 0)
            {
                return chunk;
            }
        }

        return string.Empty;
    }
}