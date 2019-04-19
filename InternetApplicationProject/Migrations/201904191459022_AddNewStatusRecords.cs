namespace InternetApplicationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewStatusRecords : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Status VALUES('Pending');");
            Sql("INSERT INTO Status VALUES('Accept');");
            Sql("INSERT INTO Status VALUES('Reject');");
        }
        
        public override void Down()
        {
        }
    }
}
