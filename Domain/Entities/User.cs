namespace Domain.Entities;

public class User : BaseEntity
{
    public string Email { get; set; }
    public string Password { get; set; }

    public User(
        Guid id,
        string email,
        string password)
    {
        SetId(id);
        Email = email;
        Password = password;
    }

    public void Update(
        string email,
        string password)
    {
        Email = email;
        Password = password;
    }

    public User()
    {
    }
}