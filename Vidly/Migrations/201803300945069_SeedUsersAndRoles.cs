namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsersAndRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'17fcac4a-0a4e-4ea1-862c-82d6383f4c5e', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5d2c2b7b-9921-466c-a04e-0019fce8b6b0', N'admin@vidly.com', 0, N'AE2HWSm38jpWxYdlM7pJAjbx7B5F7Ns4oPgZ9Bnw8ejhEk9RuIk5NxVOH2/CpdmhFg==', N'c7b90112-85ae-43a7-a8e1-60f6f1a26a76', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b624d607-39e5-412e-acd7-38a8fb12d24a', N'guest@Vidly.com', 0, N'AH9InljVk35WyZCKd3PdY+ba3VQm8MOuHt6HQVyuir/x92PivW+kDW77Lu4P2jGJvw==', N'a9f53b0c-2123-4796-bd2e-d4c478327851', NULL, 0, 0, NULL, 1, 0, N'guest@Vidly.com')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5d2c2b7b-9921-466c-a04e-0019fce8b6b0', N'17fcac4a-0a4e-4ea1-862c-82d6383f4c5e')


");
        }
        
        public override void Down()
        {
        }
    }
}
