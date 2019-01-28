namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinishAdingMemberTypeNames : DbMigration
    {
        public override void Up()
        {
			Sql("update MembershipTypes set MembershipName = 'Monthly' where Id = 2");
			Sql("update MembershipTypes set MembershipName = 'Quaterly' where Id = 3");
			Sql("update MembershipTypes set MembershipName = 'Yearly' where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
