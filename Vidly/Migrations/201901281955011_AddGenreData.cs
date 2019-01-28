namespace Vidly.Migrations
{
	using System;
	using System.Data.Entity.Migrations;
	
	public partial class AddGenreData : DbMigration
	{
		public override void Up()
		{
			Sql("insert into Genres(GenreType) values('Comedy')");
			Sql("insert into Genres(GenreType) values('Fantazy')");
			Sql("insert into Genres(GenreType) values('Action')");
			Sql("insert into Genres(GenreType) values('Romace')");
			Sql("insert into Genres(GenreType) values('Sci-fi')");
		}
		
		public override void Down()
		{
		}
	}
}
