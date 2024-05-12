namespace StudentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AttandenceAndSubjectsTablesCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Student_Id = c.Int(nullable: false),
                        Subject_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.Subject_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Subject_Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "GroupId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.Attendances", "Student_Id", "dbo.Students");
            DropIndex("dbo.Attendances", new[] { "Subject_Id" });
            DropIndex("dbo.Attendances", new[] { "Student_Id" });
            DropColumn("dbo.Students", "GroupId");
            DropTable("dbo.Subjects");
            DropTable("dbo.Attendances");
        }
    }
}
