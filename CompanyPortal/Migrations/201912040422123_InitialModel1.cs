namespace CompanyPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EngineeringAdmins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PortalLink = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FinanceAdmins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PortalLink = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HrAdmins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PortalLink = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SalesAdmins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PortalLink = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SalesAdmins");
            DropTable("dbo.HrAdmins");
            DropTable("dbo.FinanceAdmins");
            DropTable("dbo.EngineeringAdmins");
        }
    }
}
