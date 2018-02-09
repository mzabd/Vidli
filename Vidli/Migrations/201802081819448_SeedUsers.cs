namespace Vidli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1f19571e-7c48-4c58-a865-df9f6e05f460', N'geuest@vidli.com', 0, N'AAhN59pfAApJfQ+/1BbGda2ZFGiaStTQ9UywRX5Rq7xhB58FaKaQ6VMHZor4NoD2gA==', N'53ff851f-a98e-452d-8d97-8fb3aca1e693', NULL, 0, 0, NULL, 1, 0, N'geuest@vidli.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'205032de-ff71-4052-b687-87e072446170', N'admin@vidli.com', 0, N'ABoU0/sqAze4Yg45wsBDStwvuvlCx8dgLJiNSDggHGvCCAS4uZo5m1NmWx5yD09jWQ==', N'b32b139e-1825-4e19-bba2-dacbccc21626', NULL, 0, 0, NULL, 1, 0, N'admin@vidli.com')
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'75e60fc2-857f-4b0c-a0e8-1d1e33ce4cb4', N'CanManageMovies')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'205032de-ff71-4052-b687-87e072446170', N'75e60fc2-857f-4b0c-a0e8-1d1e33ce4cb4')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
