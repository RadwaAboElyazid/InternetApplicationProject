namespace InternetApplicationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequestRoleTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RequestRoles",
                c => new
                    {
                        RequestRoleId = c.Int(nullable: true, identity: true),
                        RequestRoleName = c.String(),
                    })
                .PrimaryKey(t => t.RequestRoleId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RequestRoles");
        }
    }
}
