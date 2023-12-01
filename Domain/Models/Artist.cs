namespace Domain.Models;

public class Artist
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ProfilePicture { get; set; }
    public IList<Album> Albums { get; }
    public IList<Song> Songs { get; }
    public bool IsVerified { get; set; }

    public Artist(int id, string name, string profilePicture, bool isVerified)
    {
        Id = id;
        Name = name;
        ProfilePicture = profilePicture;
        Albums = new List<Album>();
        Songs = new List<Song>();
        IsVerified = isVerified;
    }
}