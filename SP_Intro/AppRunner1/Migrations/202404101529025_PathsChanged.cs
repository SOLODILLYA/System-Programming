namespace AppRunner1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PathsChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ConPaths", "PathString", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ConPaths", "PathString");
        }
    }
}
