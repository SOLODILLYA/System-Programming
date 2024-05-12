namespace StudentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AverageGarade = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Attandence = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
