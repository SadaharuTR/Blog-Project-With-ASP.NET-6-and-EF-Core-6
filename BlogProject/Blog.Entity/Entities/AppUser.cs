using Blog.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace Blog.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>, IEntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid ImageId { get; set; } = Guid.Parse("AD7476C8-DAFA-4379-A3C3-376F6212ABC5");
        public Image Image { get; set; }
        public ICollection<Article> Articles { get; set; }

    }
}
