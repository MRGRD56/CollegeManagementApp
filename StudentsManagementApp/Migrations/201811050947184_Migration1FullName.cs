namespace StudentsManagementApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1FullName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "FullName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "FullName");
        }
    }
}
