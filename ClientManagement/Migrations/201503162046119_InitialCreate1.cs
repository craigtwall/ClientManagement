namespace ClientManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Client", "AgenciesID", c => c.String());
            DropColumn("dbo.Client", "AgencyID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Client", "AgencyID", c => c.String());
            DropColumn("dbo.Client", "AgenciesID");
        }
    }
}
