namespace Vidli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesMembershipName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthdDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.MembershipTypes", "MembershipName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "MembershipName", c => c.String());
            DropColumn("dbo.Customers", "BirthdDate");
        }
    }
}
