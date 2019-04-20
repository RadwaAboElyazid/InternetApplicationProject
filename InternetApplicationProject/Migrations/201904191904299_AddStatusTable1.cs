namespace InternetApplicationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusTable1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Projects", "StatusID", "dbo.Status");
            DropIndex("dbo.Projects", new[] { "StatusID" });
            AddColumn("dbo.Projects", "CustomerID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Projects", "StatusID", c => c.Int());
            CreateIndex("dbo.Projects", "StatusID");
            CreateIndex("dbo.Projects", "CustomerID");
            AddForeignKey("dbo.Projects", "CustomerID", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Projects", "StatusID", "dbo.Status", "StatusId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "StatusID", "dbo.Status");
            DropForeignKey("dbo.Projects", "CustomerID", "dbo.AspNetUsers");
            DropIndex("dbo.Projects", new[] { "CustomerID" });
            DropIndex("dbo.Projects", new[] { "StatusID" });
            AlterColumn("dbo.Projects", "StatusID", c => c.Int(nullable: false));
            DropColumn("dbo.Projects", "CustomerID");
            CreateIndex("dbo.Projects", "StatusID");
            AddForeignKey("dbo.Projects", "StatusID", "dbo.Status", "StatusId", cascadeDelete: true);
        }
    }
}
