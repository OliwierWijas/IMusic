namespace Domain.Models;

public class User
{
    public string Name { get; set; }
    public string ProfilePicture { get; set; }
    public IList<Playlist> Playlists { get; }

    public User(string name, string profilePicture)
    {
        Name = name;
        ProfilePicture = profilePicture;
        Playlists = new List<Playlist>();
    }
}