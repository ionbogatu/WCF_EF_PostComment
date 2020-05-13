using System.Data.Entity;

namespace PostComment
{
    public class ModelReference : DbContext
    {
        public ModelReference()
            : base("name=ModelReference")
        {
        }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Post>()
                .HasMany(m => m.Comments)
                .WithRequired(m => m.Post);

            base.OnModelCreating(modelBuilder);
        }
    }
}
