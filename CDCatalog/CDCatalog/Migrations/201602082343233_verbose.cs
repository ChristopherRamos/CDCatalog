namespace CDCatalog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class verbose : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Songs", "Genre", c => c.String());
            DropColumn("dbo.Songs", "Tenre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Songs", "Tenre", c => c.String());
            DropColumn("dbo.Songs", "Genre");
        }
    }
}
