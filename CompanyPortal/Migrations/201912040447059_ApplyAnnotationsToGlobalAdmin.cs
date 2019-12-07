namespace CompanyPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToGlobalAdmin : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GlobalAdmins", "LinkFunction", c => c.String(nullable: false));
            AlterColumn("dbo.GlobalAdmins", "LinkAddress", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GlobalAdmins", "LinkAddress", c => c.String());
            AlterColumn("dbo.GlobalAdmins", "LinkFunction", c => c.String());
        }
    }
}
