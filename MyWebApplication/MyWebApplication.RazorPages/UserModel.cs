namespace MyWebApplication.RazorPages;

public class UserModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }

    public UserModel()
    {
        Id = new Random().Next();
        Name = GenerateRandomName();
        Username = GenerateRandomUsername();
        Email = Username + "@mail.com";
    }

    private string GenerateRandomName()
    {
        string name = string.Empty;
        
        for (int i = 0; i < new Random().Next(10, 15); i++)
        {
            name += (char) (new Random().Next(65, 90));
        }
        
        return name;
    }

    public string GenerateRandomUsername()
    {
        string username = string.Empty;
        
        for (int i = 0; i < new Random().Next(10, 15); i++)
        {
            username += (char) (new Random().Next(65, 122));
        }
        
        return username;
    }
}