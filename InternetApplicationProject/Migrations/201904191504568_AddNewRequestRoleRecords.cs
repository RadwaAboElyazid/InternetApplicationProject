namespace InternetApplicationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewRequestRoleRecords : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO RequestRoles VALUES('Pending');");
            Sql("INSERT INTO RequestRoles VALUES('Hiring');");
            Sql("INSERT INTO RequestRoles VALUES('Leaving');");
        }
        
        public override void Down()
        {
        }
    }
}
