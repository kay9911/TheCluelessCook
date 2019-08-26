using Microsoft.AspNetCore.Identity;

namespace TheCluelessCook.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string CustomTag { get; set; }
    }
}
