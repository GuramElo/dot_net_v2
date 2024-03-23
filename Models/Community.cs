using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reddit.Models
{
    public class Community
    {
        [Key]
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public virtual User Owner { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<User> UserSubscribers { get; set; }
    }
}
