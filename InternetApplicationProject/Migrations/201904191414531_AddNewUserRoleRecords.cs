namespace InternetApplicationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewUserRoleRecords : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO UserRoles VALUES('Admin');");
            Sql("INSERT INTO UserRoles VALUES('ProjectManager');");
            Sql("INSERT INTO UserRoles VALUES('TeamLeader');");
            Sql("INSERT INTO UserRoles VALUES('JuniorDeveloper');");
            Sql("INSERT INTO UserRoles VALUES('Customer');");
        }
        
        public override void Down()
        {
        }
    }
}
