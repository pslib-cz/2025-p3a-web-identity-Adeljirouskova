using Microsoft.AspNetCore.Identity;

namespace CoffeeRecordsIdentity.Models;

public class ApplicationUser : IdentityUser
{
    public required string Name { get; set; }
}
