namespace CDCatalog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class verbose1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Albums", "ArtistId", "dbo.Artists");
            DropForeignKey("dbo.Songs", "ArtistId", "dbo.Artists");
            DropIndex("dbo.Albums", new[] { "ArtistId" });
            DropIndex("dbo.Songs", new[] { "ArtistId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Songs", "ArtistId");
            CreateIndex("dbo.Albums", "ArtistId");
            AddForeignKey("dbo.Songs", "ArtistId", "dbo.Artists", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Albums", "ArtistId", "dbo.Artists", "ID", cascadeDelete: true);
        }
    }
}
