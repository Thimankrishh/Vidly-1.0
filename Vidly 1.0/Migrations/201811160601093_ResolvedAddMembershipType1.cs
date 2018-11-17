namespace Vidly_1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResolvedAddMembershipType1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("MembershipType", "Id");
            DropColumn("MembershipType", "SignUpFree");
            DropColumn("MembershipType", "DurationInMonths");
            DropColumn("MembershipType", "DiscountRate");
        }
        
        public override void Down()
        {
        }
    }
}
