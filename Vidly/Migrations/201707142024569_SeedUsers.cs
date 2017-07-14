namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'15d4f837-a0ba-4e22-9974-390e95d8266d', N'admin@vidly.com', 0, N'ABrpoyF1zY6ZZAy3u3tfBV4kWLK6bmCpQvf7bl5+r5AjZeSBKwSyVjS4PVTGzDza9Q==', N'd791ec5d-d199-4519-985a-1741b8a8f063', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a1cbc420-6756-4aca-9083-05248f52f09f', N'guest@vidly.com', 0, N'AAF+wuNeWgLdAAGJdr7kRABGwKDERn8KwvQSKuoVfTJ+S/xvV+RRthTj8+DXi4134A==', N'1f9571cf-142f-479b-b859-fb16d3da9b2d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f8fd7063-1371-4083-af1a-1805bde7a938', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'15d4f837-a0ba-4e22-9974-390e95d8266d', N'f8fd7063-1371-4083-af1a-1805bde7a938')
 
");
        }
        
        public override void Down()
        {
        }
    }
}
