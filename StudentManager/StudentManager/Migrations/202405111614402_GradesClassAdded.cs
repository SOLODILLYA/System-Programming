namespace StudentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GradesClassAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GradeValue = c.Int(nullable: false),
                        Student_Id = c.Int(nullable: false),
                        Subject_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.Subject_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Subject_Id);
            
            DropColumn("dbo.Students", "GroupId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "GroupId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Grades", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.Grades", "Student_Id", "dbo.Students");
            DropIndex("dbo.Grades", new[] { "Subject_Id" });
            DropIndex("dbo.Grades", new[] { "Student_Id" });
            DropTable("dbo.Grades");
        }
    }
}
