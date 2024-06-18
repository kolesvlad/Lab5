namespace Lab5;

public class ReportGenerator
{

    public void CreateReport(List<Company> companies, FileManager fileManager)
    {

        foreach (var company in companies)
        {
            var json = company.ObtainJson();
            fileManager.WriteReportText(company.OfficialName, json);
        }
    }
}