namespace CDCatalog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newchanges : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Albums", "Artist");
            DropColumn("dbo.Songs", "Artist");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Songs", "Artist", c => c.String());
            AddColumn("dbo.Albums", "Artist", c => c.String());
        }
    }
}
