namespace InternetApplicationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProjectRequest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectRequests", "ProjectMangerID", c => c.Int());
            AddColumn("dbo.ProjectRequests", "StatusID", c => c.Int());
            AddColumn("dbo.ProjectRequests", "ProjectManger_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.ProjectRequests", "StatusID");
            CreateIndex("dbo.ProjectRequests", "ProjectManger_Id");
            AddForeignKey("dbo.ProjectRequests", "ProjectManger_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.ProjectRequests", "StatusID", "dbo.Status", "StatusId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectRequests", "StatusID", "dbo.Status");
            DropForeignKey("dbo.ProjectRequests", "ProjectManger_Id", "dbo.AspNetUsers");
            DropIndex("dbo.ProjectRequests", new[] { "ProjectManger_Id" });
            DropIndex("dbo.ProjectRequests", new[] { "StatusID" });
            DropColumn("dbo.ProjectRequests", "ProjectManger_Id");
            DropColumn("dbo.ProjectRequests", "StatusID");
            DropColumn("dbo.ProjectRequests", "ProjectMangerID");
        }
    }
}
