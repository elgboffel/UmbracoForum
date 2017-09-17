using System.Data.Entity;

namespace Community.Core.EntityModels
{

    public partial class CommunityContext : DbContext
    {

        public CommunityContext() : base("Server=.\\SQLEXPRESS;Database=ForumUmbracoDb;Integrated Security=true") { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Reply> Replies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new UserRoleConfiguration());
            //modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new PostConfiguration());
            modelBuilder.Configurations.Add(new ReplyConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
