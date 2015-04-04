namespace ClientManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Client", "Agency_ID", "dbo.Agency");
            DropIndex("dbo.Client", new[] { "Agency_ID" });
            DropColumn("dbo.Client", "AgencyID");
            RenameColumn(table: "dbo.Client", name: "Agency_ID", newName: "AgencyID");
            AlterColumn("dbo.Client", "AgencyID", c => c.Int(nullable: false));
            AlterColumn("dbo.Client", "AgencyID", c => c.Int(nullable: false));
            CreateIndex("dbo.Client", "AgencyID");
            AddForeignKey("dbo.Client", "AgencyID", "dbo.Agency", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Client", "AgencyID", "dbo.Agency");
            DropIndex("dbo.Client", new[] { "AgencyID" });
            AlterColumn("dbo.Client", "AgencyID", c => c.Int());
            AlterColumn("dbo.Client", "AgencyID", c => c.String());
            RenameColumn(table: "dbo.Client", name: "AgencyID", newName: "Agency_ID");
            AddColumn("dbo.Client", "AgencyID", c => c.String());
            CreateIndex("dbo.Client", "Agency_ID");
            AddForeignKey("dbo.Client", "Agency_ID", "dbo.Agency", "ID");
        }
    }
}
