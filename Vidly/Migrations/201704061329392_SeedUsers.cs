namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'592fef90-50e9-4498-a5fc-bdf90a831f98', N'admin@vidly.com', 0, N'ADElpA4HuvtbNZ/JQ8HX3qYTD1GK2CMuUwHNjPuUBQTkkzIt9TYUJ4+SQktoNbc8yQ==', N'fde962c5-c012-4ff9-b95a-634abf621ecb', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e9995c42-c2e6-4f1d-90db-1415db318d90', N'guest@vidly.com', 0, N'AOuYRB1wZIb5iUD8L1VSB+N/BcBsw89sKh1xWZONtKlp/57BQZJ0yAL+zrCaqluUeg==', N'3e42bed7-882e-4a6e-9024-0a682f7cda85', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'76a411bf-896a-41ce-b4b1-50f2bd21d3cb', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'592fef90-50e9-4498-a5fc-bdf90a831f98', N'76a411bf-896a-41ce-b4b1-50f2bd21d3cb')
");
        }
        
        public override void Down()
        {
        }
    }
}
