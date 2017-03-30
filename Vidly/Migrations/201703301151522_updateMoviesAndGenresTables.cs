namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMoviesAndGenresTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
            AddColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Genres", "GenreType");
            DropColumn("dbo.Genres", "DateAdded");
            DropColumn("dbo.Genres", "ReleaseDate");
            DropColumn("dbo.Genres", "Stock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "Stock", c => c.Int(nullable: false));
            AddColumn("dbo.Genres", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Genres", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Genres", "GenreType", c => c.String());
            AlterColumn("dbo.Movies", "Name", c => c.String());
            DropColumn("dbo.Genres", "Name");
            DropColumn("dbo.Movies", "NumberInStock");
            DropColumn("dbo.Movies", "ReleaseDate");
            DropColumn("dbo.Movies", "DateAdded");
        }
    }
}
