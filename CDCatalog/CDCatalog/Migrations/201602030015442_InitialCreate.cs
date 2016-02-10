namespace CDCatalog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        artistId = c.Int(nullable: false),
                        title = c.String(),
                        year = c.Int(nullable: false),
                        rating = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        artistId = c.Int(nullable: false),
                        albumId = c.Int(nullable: false),
                        title = c.String(),
                        trackNumber = c.Int(nullable: false),
                        genre = c.String(),
                        trackLength = c.Int(nullable: false),
                        rating = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Songs");
            DropTable("dbo.Artists");
            DropTable("dbo.Albums");
        }
    }
}
