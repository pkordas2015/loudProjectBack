namespace SoLoud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPlaceIdToPosts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Post", "PlaceId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Post", "PlaceId");
        }
    }
}
