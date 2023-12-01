namespace Domain.Models;

public class Song
{
    public int Id { get; set; }
    public string Cover { get; set; }
    public string Title { get; set; }
    public string Lyrics { get; set; }
    public string Genre { get; set; }
    public string Reference { get; set; }
}