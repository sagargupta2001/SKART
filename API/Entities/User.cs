using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class User : IdentityUser<int>
    {
        // one-to-one relationship between user and address.
        public UserAddress Address { get; set; }
    }
}
