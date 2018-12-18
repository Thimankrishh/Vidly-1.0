namespace Vidly_1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveGenresIdColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "GenreId");
        }
        
        public override void Down()
        {
        }
    }
}
