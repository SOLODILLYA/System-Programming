﻿namespace AppRunner1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PathsCreated2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ConnectionPaths", newName: "ConPaths");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ConPaths", newName: "ConnectionPaths");
        }
    }
}
