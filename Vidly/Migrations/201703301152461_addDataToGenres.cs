namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDataToGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) values('Action')");
            Sql("INSERT INTO Genres (Name) values('Comedy')");
            Sql("INSERT INTO Genres (Name) values('Romance')");
            Sql("INSERT INTO Genres (Name) values('Thriller')");
            Sql("INSERT INTO Genres (Name) values('Family')");
            Sql("INSERT INTO Genres (Name) values('Horror')");
        }
        
        public override void Down()
        {
        }
    }
}
