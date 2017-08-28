namespace VidlyGeoApp.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'15a20184-41e6-4cba-a103-100e988cc6e3', N'admin@vidleygeoapp.com', 0, N'AA34Y9S3kVkpD9YK5BCmOr20V9g/FN0N/RMBT3wTsNmj7fdz5q0hSDwVhbJVTUzIHA==', N'bb35bb7c-96cb-431a-8818-ffeb80de0f5c', NULL, 0, 0, NULL, 1, 0, N'admin@vidleygeoapp.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ea71ee2b-0a40-4dbe-a619-02899ff3254c', N'guest@vidleygeoapp.com', 0, N'AFdjZELBOzzn8eIHPQNYfxmOBzPBRyoNrRzTROqOWSmCjD5n+yWHmiYGjSj4+ApbYw==', N'9f27e92f-1047-479d-80d7-26443d810219', NULL, 0, 0, NULL, 1, 0, N'guest@vidleygeoapp.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'71419128-3639-4fda-a535-312ab91499d9', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'15a20184-41e6-4cba-a103-100e988cc6e3', N'71419128-3639-4fda-a535-312ab91499d9')
");
        }
        
        public override void Down()
        {
        }
    }
}
