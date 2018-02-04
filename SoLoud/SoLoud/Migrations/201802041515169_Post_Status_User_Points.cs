namespace SoLoud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Post_Status_User_Points : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Post", "PostStatus", c => c.Int(nullable: false));
            AddColumn("dbo.Post", "RejectionComments", c => c.String());
            AddColumn("dbo.AspNetUsers", "TotalPoints", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Likes", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Comments", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Shares", c => c.Int(nullable: false));
            DropColumn("dbo.Post", "IsVerified");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Post", "IsVerified", c => c.Boolean(nullable: false));
            DropColumn("dbo.AspNetUsers", "Shares");
            DropColumn("dbo.AspNetUsers", "Comments");
            DropColumn("dbo.AspNetUsers", "Likes");
            DropColumn("dbo.AspNetUsers", "TotalPoints");
            DropColumn("dbo.Post", "RejectionComments");
            DropColumn("dbo.Post", "PostStatus");
        }
    }
}
