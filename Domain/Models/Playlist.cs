namespace Domain.Models;

public class Playlist
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Cover { get; set; }
    public IList<Song> Songs { get; }

    public Playlist(int id, string name, string cover)
    {
        Id = id;
        Name = name;
        Cover = cover;
        Songs = new List<Song>();
    }
}