namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addReleseDateColumeToGenresTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genres", "ReleaseDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Genres", "ReleaseDate");
        }
    }
}
