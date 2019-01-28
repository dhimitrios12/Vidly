namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddABirthday : DbMigration
    {
        public override void Up()
        {
			Sql("update Customers set BirthDate = '2019-02-01' where Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
