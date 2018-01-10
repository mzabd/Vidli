namespace Vidli.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Genres (Type) Values('Action') ");
            Sql("INSERT INTO Genres (Type) Values('Comedy') ");
            Sql("INSERT INTO Genres (Type) Values('Family') ");
            Sql("INSERT INTO Genres (Type) Values('Romance') ");
            Sql("INSERT INTO Genres (Type) Values('Thriller') ");
            Sql("INSERT INTO Genres (Type) Values('War') ");
            Sql("INSERT INTO Genres (Type) Values('Horror') ");
            Sql("INSERT INTO Genres (Type) Values('Animation') ");
            Sql("INSERT INTO Genres (Type) Values('Western') ");
            Sql("INSERT INTO Genres (Type) Values('Fantacy') ");
        }
        
        public override void Down()
        {
        }
    }
}
