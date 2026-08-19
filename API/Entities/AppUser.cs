namespace API.Entities;

public class AppUser
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string DisplayName { get; set; }
    public required string Email { get; set; }
    public string? ImageUrl { get; set; }
    public required byte [] PasswordHash { get; set; }  //one way operation, not secure, so we need to add a salt to make it more secure
    public required byte [] PasswordSalt { get; set; } //we add it to more security, so we can randomize our password HASH

    //Nav property
    public Member Member { get; set; } = null!;  
}