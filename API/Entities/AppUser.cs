namespace API.Entities;

public class AppUser
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string DisplayName { get; set; }
    public required string Email { get; set; }
    public byte [] PasswordHash { get; set; }  //one way operation, not secure, so we need to add a salt to make it more secure
    public byte [] PasswordSalt { get; set; } //we add it to more securite, so we can randomize ur password HASH

}