using Microsoft.EntityFrameworkCore;
using Reddit.Models;

namespace Reddit
{
    public class ApplcationDBContext: DbContext
    {
        public ApplcationDBContext(DbContextOptions<ApplcationDBContext> dbContextOptions): base(dbContextOptions)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Community>()
                .HasOne(c => c.Owner)               // Community has one Owner (User)
                .WithMany(u => u.CreatedCommunities)  // User can have many communities
                .HasForeignKey(c => c.OwnerId)    // Foreign key
                .OnDelete(DeleteBehavior.Restrict); // Do not allow cascade delete (optional)

            // Other configurations...
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Community> Communities {  get; set; }
    }
}
