namespace CDCatalog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChrisR : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Songs", "AlbumId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Songs", "AlbumId");
        }
    }
}
