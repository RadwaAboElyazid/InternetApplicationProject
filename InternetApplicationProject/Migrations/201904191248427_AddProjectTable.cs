namespace InternetApplicationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProjectTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Int(nullable: true, identity: true),
                        ProjectName = c.String(),
                        ProjectDescription = c.String(),
                        ProjectPrice = c.Single(nullable: true),
                        ProjectComment = c.String(),
                    })
                .PrimaryKey(t => t.ProjectID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Projects");
        }
    }
}
