namespace StudentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameStudentAt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Attendance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Students", "Attandence");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Attandence", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Students", "Attendance");
        }
    }
}
