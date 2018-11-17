namespace Vidly_1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResolvedAddMembershipType11 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Customers");
        }
        
        public override void Down()
        {
        }
    }
}
