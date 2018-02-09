namespace Vidli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNewGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Type) Values('SiFi') ");
        }
        
        public override void Down()
        {
        }
    }
}
