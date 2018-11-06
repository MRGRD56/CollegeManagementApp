namespace StudentsManagementApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groups", "Name", c => c.String());
            AddColumn("dbo.Groups", "Course", c => c.Int(nullable: false));
            AddColumn("dbo.Groups", "Teacher_Id", c => c.Int());
            AddColumn("dbo.People", "FirstName", c => c.String());
            AddColumn("dbo.People", "LastName", c => c.String());
            AddColumn("dbo.People", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.Student", "Group_Id", c => c.Int());
            AddColumn("dbo.Teacher", "Subject", c => c.String());
            CreateIndex("dbo.Groups", "Teacher_Id");
            CreateIndex("dbo.Student", "Group_Id");
            AddForeignKey("dbo.Groups", "Teacher_Id", "dbo.Teacher", "Id");
            AddForeignKey("dbo.Student", "Group_Id", "dbo.Groups", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Student", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.Groups", "Teacher_Id", "dbo.Teacher");
            DropIndex("dbo.Student", new[] { "Group_Id" });
            DropIndex("dbo.Groups", new[] { "Teacher_Id" });
            DropColumn("dbo.Teacher", "Subject");
            DropColumn("dbo.Student", "Group_Id");
            DropColumn("dbo.People", "Age");
            DropColumn("dbo.People", "LastName");
            DropColumn("dbo.People", "FirstName");
            DropColumn("dbo.Groups", "Teacher_Id");
            DropColumn("dbo.Groups", "Course");
            DropColumn("dbo.Groups", "Name");
        }
    }
}
