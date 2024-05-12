namespace StudentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentFixed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "AverageGrade", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Students", "AverageGarade");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "AverageGarade", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Students", "AverageGrade");
        }
    }
}
