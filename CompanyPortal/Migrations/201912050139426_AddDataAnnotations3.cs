namespace CompanyPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotations3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SalesAdmins", "LinkAddress", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SalesAdmins", "LinkAddress", c => c.String());
        }
    }
}
