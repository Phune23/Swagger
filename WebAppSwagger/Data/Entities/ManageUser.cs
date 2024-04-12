using Microsoft.AspNetCore.Identity;

namespace WebAppSwagger.Data.Entities
{
    public class ManageUser : IdentityUser
    {
        public string? DisPlayName { get; set; }
        public DateTime BrithDay { get; set; }
    }
}
