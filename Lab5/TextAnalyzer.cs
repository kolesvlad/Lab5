namespace Lab5;

public class TextAnalyzer
{

    public Dictionary<string, string> PreprocessText(Dictionary<string, string> text)
    {
        
        //Console.WriteLine(ToLowerCase(RemovePunctuation(text["amilton-tops-belgian-gp-qualifying-for-fourth-consecutive-pole"])));
        
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
}