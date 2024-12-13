/* 
public class Report
{
    public string Title { get; set; }
    public string Content { get; set; }

    // Generates the report content
    public void GenerateReport()
    {
        Console.WriteLine("Generating Report...");
    }

    // Saves the report to a file
    public void SaveToFile(string filename)
    {
        Console.WriteLine($"Saving report to {filename}");
    }

    // Sends the report via email
    public void SendEmail(string emailAddress)
    {
        Console.WriteLine($"Sending report to {emailAddress}");
    }
}

*/

//SRP-single responsibility principle 

// Represents the report data
public class Report
{
    public string? Title { get; set; }
    public required string Content { get; set; }
}


// Handles report generation
public class ReportGenerator
{
    public Report GenerateReport()
    {
        Console.WriteLine("Generating Report...");
        return new Report { Title = "Monthly Report", Content = "This is the content." };
    }
}

public class ReportSaver{
    public void SaveToFile(Report report, string filename){
           Console.WriteLine($"Saving report  {report.Title} to {filename}");
    } 
}

public class ReportSender{
    public void SendToEmail(Report report, string email){
           Console.WriteLine($"Sending report  {report.Title} to {email}");
    } 
}