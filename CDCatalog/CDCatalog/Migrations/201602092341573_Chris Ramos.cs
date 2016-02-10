namespace CDCatalog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChrisRamos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "Artist", c => c.String());
            AddColumn("dbo.Songs", "Artist", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Songs", "Artist");
            DropColumn("dbo.Albums", "Artist");
        }
    }
}
