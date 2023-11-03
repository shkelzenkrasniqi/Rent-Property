using System.Reflection;

namespace Rent_Property.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? EmailVerified { get; set; }
        public string Image { get; set; }
        public string HashedPassword { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public List<Account> Accounts { get; set; }
        public List<Listing> Listings { get; set; }
       


    }
}
