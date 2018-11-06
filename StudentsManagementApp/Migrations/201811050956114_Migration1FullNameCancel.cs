namespace StudentsManagementApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1FullNameCancel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.People", "FullName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "FullName", c => c.String());
        }
    }
}
