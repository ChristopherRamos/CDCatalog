namespace CDCatalog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cramos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Songs", "Tenre", c => c.String());
            CreateIndex("dbo.Albums", "ArtistId");
            CreateIndex("dbo.Songs", "ArtistId");
            AddForeignKey("dbo.Albums", "ArtistId", "dbo.Artists", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Songs", "ArtistId", "dbo.Artists", "ID", cascadeDelete: true);
            DropColumn("dbo.Songs", "albumId");
            DropColumn("dbo.Songs", "genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Songs", "genre", c => c.String());
            AddColumn("dbo.Songs", "albumId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Songs", "ArtistId", "dbo.Artists");
            DropForeignKey("dbo.Albums", "ArtistId", "dbo.Artists");
            DropIndex("dbo.Songs", new[] { "ArtistId" });
            DropIndex("dbo.Albums", new[] { "ArtistId" });
            DropColumn("dbo.Songs", "Tenre");
        }
    }
}
