namespace ConsoleAppEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Group", name: "GrupoId", newName: "GroupId");
            RenameIndex(table: "dbo.Group", name: "IX_GrupoId", newName: "IX_GroupId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Group", name: "IX_GroupId", newName: "IX_GrupoId");
            RenameColumn(table: "dbo.Group", name: "GroupId", newName: "GrupoId");
        }
    }
}
