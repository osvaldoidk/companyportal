namespace CompanyPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EngineeringAdmins", "LinkFunction", c => c.String());
            AddColumn("dbo.EngineeringAdmins", "LinkAddress", c => c.String());
            AddColumn("dbo.FinanceAdmins", "LinkFunction", c => c.String());
            AddColumn("dbo.FinanceAdmins", "LinkAddress", c => c.String());
            AddColumn("dbo.GlobalAdmins", "LinkFunction", c => c.String());
            AddColumn("dbo.GlobalAdmins", "LinkAddress", c => c.String());
            AddColumn("dbo.HrAdmins", "LinkFunction", c => c.String());
            AddColumn("dbo.HrAdmins", "LinkAddress", c => c.String());
            AddColumn("dbo.SalesAdmins", "LinkFunction", c => c.String());
            AddColumn("dbo.SalesAdmins", "LinkAddress", c => c.String());
            DropColumn("dbo.EngineeringAdmins", "PortalLink");
            DropColumn("dbo.FinanceAdmins", "PortalLink");
            DropColumn("dbo.GlobalAdmins", "PortalLink");
            DropColumn("dbo.HrAdmins", "PortalLink");
            DropColumn("dbo.SalesAdmins", "PortalLink");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SalesAdmins", "PortalLink", c => c.String());
            AddColumn("dbo.HrAdmins", "PortalLink", c => c.String());
            AddColumn("dbo.GlobalAdmins", "PortalLink", c => c.String());
            AddColumn("dbo.FinanceAdmins", "PortalLink", c => c.String());
            AddColumn("dbo.EngineeringAdmins", "PortalLink", c => c.String());
            DropColumn("dbo.SalesAdmins", "LinkAddress");
            DropColumn("dbo.SalesAdmins", "LinkFunction");
            DropColumn("dbo.HrAdmins", "LinkAddress");
            DropColumn("dbo.HrAdmins", "LinkFunction");
            DropColumn("dbo.GlobalAdmins", "LinkAddress");
            DropColumn("dbo.GlobalAdmins", "LinkFunction");
            DropColumn("dbo.FinanceAdmins", "LinkAddress");
            DropColumn("dbo.FinanceAdmins", "LinkFunction");
            DropColumn("dbo.EngineeringAdmins", "LinkAddress");
            DropColumn("dbo.EngineeringAdmins", "LinkFunction");
        }
    }
}
