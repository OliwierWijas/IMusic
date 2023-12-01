namespace Domain.DTOs;

public class UserCreationDTO
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ProfilePicture { get; set; }

    public UserCreationDTO(string name, string email, string password, string profilePicture)
    {
        Name = name;
        Email = email;
        Password = password;
        ProfilePicture = profilePicture;
    }
}