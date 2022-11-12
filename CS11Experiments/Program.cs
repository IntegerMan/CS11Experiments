Article thisArticle = new()
{
    Title = "Introducing the Required Keyword in C# 11",
    Author = "Matt Eland",
    Published = DateTime.Today
};

Console.WriteLine(thisArticle);

public class Article
{
    public string Title { get; set; }
    public string? Subtitle { get; set; }
    public string Author { get; set; }
    public DateTime Published { get; set; }

    public override string ToString()
    {
        if (string.IsNullOrWhiteSpace(Subtitle))
        {
            return $"{Title} by {Author} ({Published.ToShortDateString()})";
        }

        return $"{Title}: {Subtitle} by {Author} ({Published.ToShortDateString()})";
    }
}
