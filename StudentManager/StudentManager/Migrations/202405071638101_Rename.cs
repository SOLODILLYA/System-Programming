namespace StudentManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rename : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendances", "IsPresent", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attendances", "IsPresent");
        }
    }
}
