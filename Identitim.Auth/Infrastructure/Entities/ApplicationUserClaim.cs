using Microsoft.AspNetCore.Identity;

namespace Identitim.Auth.Infrastructure.Entities;

public class ApplicationUserClaim : IdentityUserClaim<string>
{
    public virtual ApplicationUser User { get; set; }
}