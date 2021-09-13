namespace Vidly_Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'466622fe-bf79-4057-ae2e-8bbc84da8248', N'guest@vidly.com', 0, N'APT9cSyGRrade/1nac6c5G3ORs8lRIbA0MFcZm+723cfdsVLNHBwgxnwSZbyAjVl1A==', N'83a3b1fc-cb04-461c-92ed-33b75c8389df', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c87fac32-49d6-4e18-840b-d223843422e4', N'admin@vidly.com', 0, N'AG6HBs6zEIjls3kvmMKF0pw76ky67H0/3UQ2MDjG7V5mFgXqq1YdO1HRfF+ixcllLA==', N'19eea2d5-266f-4f91-85df-9d7774a105e2', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9eb6e5ac-602c-4c41-8a74-60dc79658f22', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c87fac32-49d6-4e18-840b-d223843422e4', N'9eb6e5ac-602c-4c41-8a74-60dc79658f22')
");
        }
        
        public override void Down()
        {
        }
    }
}
