namespace InternetApplicationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusRecords : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "StatusID", c => c.Int(nullable: false));
            CreateIndex("dbo.Projects", "StatusID");
            AddForeignKey("dbo.Projects", "StatusID", "dbo.Status", "StatusId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "StatusID", "dbo.Status");
            DropIndex("dbo.Projects", new[] { "StatusID" });
            DropColumn("dbo.Projects", "StatusID");
        }
    }
}
