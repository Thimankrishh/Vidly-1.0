namespace Vidly_1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResolvedbGenres : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "Genres_Id", newName: "GenresId");
            RenameIndex(table: "dbo.Movies", name: "IX_Genres_Id", newName: "IX_GenresId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Movies", name: "IX_GenresId", newName: "IX_Genres_Id");
            RenameColumn(table: "dbo.Movies", name: "GenresId", newName: "Genres_Id");
        }
    }
}
