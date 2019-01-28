namespace Vidly.Migrations
{
	using System;
	using System.Data.Entity.Migrations;
	
	public partial class deleteMoviesTable : DbMigration
	{
		public override void Up()
		{
			Sql("drop table Movies");
		}
		
		public override void Down()
		{
		}
	}
}
