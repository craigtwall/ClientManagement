namespace ClientManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClientAgency", "Client_ID", "dbo.Client");
            DropForeignKey("dbo.ClientAgency", "Agency_ID", "dbo.Agency");
            DropIndex("dbo.ClientAgency", new[] { "Client_ID" });
            DropIndex("dbo.ClientAgency", new[] { "Agency_ID" });
            AddColumn("dbo.Client", "AgencyID", c => c.String());
            AddColumn("dbo.Client", "Agencies_ID", c => c.Int());
            CreateIndex("dbo.Client", "Agencies_ID");
            AddForeignKey("dbo.Client", "Agencies_ID", "dbo.Agency", "ID");
            DropTable("dbo.ClientAgency");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ClientAgency",
                c => new
                    {
                        Client_ID = c.Int(nullable: false),
                        Agency_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Client_ID, t.Agency_ID });
            
            DropForeignKey("dbo.Client", "Agencies_ID", "dbo.Agency");
            DropIndex("dbo.Client", new[] { "Agencies_ID" });
            DropColumn("dbo.Client", "Agencies_ID");
            DropColumn("dbo.Client", "AgencyID");
            CreateIndex("dbo.ClientAgency", "Agency_ID");
            CreateIndex("dbo.ClientAgency", "Client_ID");
            AddForeignKey("dbo.ClientAgency", "Agency_ID", "dbo.Agency", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ClientAgency", "Client_ID", "dbo.Client", "ID", cascadeDelete: true);
        }
    }
}
