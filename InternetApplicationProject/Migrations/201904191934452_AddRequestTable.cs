namespace InternetApplicationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequestTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        RequestId = c.Int(nullable: true, identity: true),
                        UserId = c.Int(),
                        StatusID = c.Int(),
                        ProjectID = c.Int(),
                        RequestRoleID = c.Int(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.RequestId)
                .ForeignKey("dbo.Projects", t => t.ProjectID)
                .ForeignKey("dbo.RequestRoles", t => t.RequestRoleID)
                .ForeignKey("dbo.Status", t => t.StatusID)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.StatusID)
                .Index(t => t.ProjectID)
                .Index(t => t.RequestRoleID)
                .Index(t => t.User_Id);
            
            AddColumn("dbo.Comments", "Time", c => c.DateTime(nullable: false));
            AddColumn("dbo.Comments", "ProjectID", c => c.Int());
            AddColumn("dbo.Comments", "ProjectMangerID", c => c.Int());
            AddColumn("dbo.Comments", "ProjectManger_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Feedbacks", "TeamLeaderID", c => c.Int());
            AddColumn("dbo.Feedbacks", "JuniorDevID", c => c.Int());
            AddColumn("dbo.Feedbacks", "JuniorDev_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Feedbacks", "TeamLeader_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.ProjectRequests", "ProjectID", c => c.Int());
            AddColumn("dbo.Teams", "UserID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Comments", "ProjectID");
            CreateIndex("dbo.Comments", "ProjectManger_Id");
            CreateIndex("dbo.Feedbacks", "JuniorDev_Id");
            CreateIndex("dbo.Feedbacks", "TeamLeader_Id");
            CreateIndex("dbo.ProjectRequests", "ProjectID");
            CreateIndex("dbo.Teams", "UserID");
            AddForeignKey("dbo.Comments", "ProjectID", "dbo.Projects", "ProjectID");
            AddForeignKey("dbo.Comments", "ProjectManger_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Feedbacks", "JuniorDev_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Feedbacks", "TeamLeader_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.ProjectRequests", "ProjectID", "dbo.Projects", "ProjectID");
            AddForeignKey("dbo.Teams", "UserID", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "UserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.Requests", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Requests", "StatusID", "dbo.Status");
            DropForeignKey("dbo.Requests", "RequestRoleID", "dbo.RequestRoles");
            DropForeignKey("dbo.Requests", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.ProjectRequests", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.Feedbacks", "TeamLeader_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Feedbacks", "JuniorDev_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "ProjectManger_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "ProjectID", "dbo.Projects");
            DropIndex("dbo.Teams", new[] { "UserID" });
            DropIndex("dbo.Requests", new[] { "User_Id" });
            DropIndex("dbo.Requests", new[] { "RequestRoleID" });
            DropIndex("dbo.Requests", new[] { "ProjectID" });
            DropIndex("dbo.Requests", new[] { "StatusID" });
            DropIndex("dbo.ProjectRequests", new[] { "ProjectID" });
            DropIndex("dbo.Feedbacks", new[] { "TeamLeader_Id" });
            DropIndex("dbo.Feedbacks", new[] { "JuniorDev_Id" });
            DropIndex("dbo.Comments", new[] { "ProjectManger_Id" });
            DropIndex("dbo.Comments", new[] { "ProjectID" });
            DropColumn("dbo.Teams", "UserID");
            DropColumn("dbo.ProjectRequests", "ProjectID");
            DropColumn("dbo.Feedbacks", "TeamLeader_Id");
            DropColumn("dbo.Feedbacks", "JuniorDev_Id");
            DropColumn("dbo.Feedbacks", "JuniorDevID");
            DropColumn("dbo.Feedbacks", "TeamLeaderID");
            DropColumn("dbo.Comments", "ProjectManger_Id");
            DropColumn("dbo.Comments", "ProjectMangerID");
            DropColumn("dbo.Comments", "ProjectID");
            DropColumn("dbo.Comments", "Time");
            DropTable("dbo.Requests");
        }
    }
}
