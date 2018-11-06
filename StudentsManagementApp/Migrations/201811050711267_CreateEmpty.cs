namespace StudentsManagementApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEmpty : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Teacher",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teacher", "Id", "dbo.People");
            DropForeignKey("dbo.Student", "Id", "dbo.People");
            DropIndex("dbo.Teacher", new[] { "Id" });
            DropIndex("dbo.Student", new[] { "Id" });
            DropTable("dbo.Teacher");
            DropTable("dbo.Student");
            DropTable("dbo.People");
            DropTable("dbo.Groups");
        }
    }
}
