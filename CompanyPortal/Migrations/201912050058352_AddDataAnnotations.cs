namespace CompanyPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EngineeringAdmins", "LinkFunction", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.EngineeringAdmins", "LinkAddress", c => c.String(nullable: false));
            AlterColumn("dbo.FinanceAdmins", "LinkFunction", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.FinanceAdmins", "LinkAddress", c => c.String(nullable: false));
            AlterColumn("dbo.GlobalAdmins", "LinkFunction", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.HrAdmins", "LinkFunction", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.HrAdmins", "LinkAddress", c => c.String(nullable: false));
            AlterColumn("dbo.SalesAdmins", "LinkFunction", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.SalesAdmins", "LinkAddress", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SalesAdmins", "LinkAddress", c => c.String());
            AlterColumn("dbo.SalesAdmins", "LinkFunction", c => c.String());
            AlterColumn("dbo.HrAdmins", "LinkAddress", c => c.String());
            AlterColumn("dbo.HrAdmins", "LinkFunction", c => c.String());
            AlterColumn("dbo.GlobalAdmins", "LinkFunction", c => c.String(nullable: false));
            AlterColumn("dbo.FinanceAdmins", "LinkAddress", c => c.String());
            AlterColumn("dbo.FinanceAdmins", "LinkFunction", c => c.String());
            AlterColumn("dbo.EngineeringAdmins", "LinkAddress", c => c.String());
            AlterColumn("dbo.EngineeringAdmins", "LinkFunction", c => c.String());
        }
    }
}
