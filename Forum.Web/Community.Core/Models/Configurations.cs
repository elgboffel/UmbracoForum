using System.Data.Entity.ModelConfiguration;


namespace Community.Core.EntityModels
{
    //public class UserRoleConfiguration : EntityTypeConfiguration<UserRole>
    //{
    //    public UserRoleConfiguration()
    //    {
    //        ToTable("UserRoles");
    //    }
    //}

    //public class UserConfiguration : EntityTypeConfiguration<User>
    //{
    //    public UserConfiguration()
    //    {
    //        ToTable("Users");
    //        Property(x => x.FirstName).IsRequired().HasMaxLength(50);
    //        Property(x => x.LastName).IsRequired().HasMaxLength(100);
    //        Property(x => x.Mail).IsRequired().HasMaxLength(100);

    //    }
    //}

    public class PostConfiguration : EntityTypeConfiguration<Post>
    {
        public PostConfiguration()
        {
            ToTable("CommunityPosts");
            HasKey(x => x.Id);
            Property(x => x.Title).IsRequired().HasMaxLength(255);
            Property(x => x.Content).IsRequired();
            Property(x => x.MemberId).IsRequired();
            HasOptional(x => x.Category);
        }
    }

    public class ReplyConfiguration : EntityTypeConfiguration<Reply>
    {
        public ReplyConfiguration()
        {
            ToTable("CommunityReplies");
            Property(x => x.Content).IsRequired();
        }
    }

    public class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("CommunityCategories");
            Property(x => x.Name).IsRequired().HasMaxLength(255);
        }
    }
}
