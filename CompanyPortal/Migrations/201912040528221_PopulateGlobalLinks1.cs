namespace CompanyPortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGlobalLinks1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GlobalAdmins (LinkFunction, LinkAddress) VALUES ('Manage User Accounts', 'amazon.com')");
            Sql("INSERT INTO GlobalAdmins (LinkFunction, LinkAddress) VALUES ('Assign Roles', 'amazon.com')");
            Sql("INSERT INTO GlobalAdmins (LinkFunction, LinkAddress) VALUES ('Help Desk', 'amazon.com')");
        }
        
        public override void Down()
        {
        }
    }
}
