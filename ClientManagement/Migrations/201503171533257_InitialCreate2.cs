namespace ClientManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Client", name: "Agencies_ID", newName: "Agency_ID");
            RenameIndex(table: "dbo.Client", name: "IX_Agencies_ID", newName: "IX_Agency_ID");
            AddColumn("dbo.Client", "AgencyID", c => c.String());
            DropColumn("dbo.Client", "AgenciesID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Client", "AgenciesID", c => c.String());
            DropColumn("dbo.Client", "AgencyID");
            RenameIndex(table: "dbo.Client", name: "IX_Agency_ID", newName: "IX_Agencies_ID");
            RenameColumn(table: "dbo.Client", name: "Agency_ID", newName: "Agencies_ID");
        }
    }
}
