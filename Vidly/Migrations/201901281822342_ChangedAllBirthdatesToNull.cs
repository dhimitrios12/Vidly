namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedAllBirthdatesToNull : DbMigration
    {
        public override void Up()
        {
			Sql("update Customers set Birthdate = null");
        }
        
        public override void Down()
        {
        }
    }
}
