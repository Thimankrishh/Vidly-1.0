namespace Vidly_1._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, Name) VALUES(1,'Thriller')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(2,'Comedy')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(3,'Romance')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(4,'Action')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(5,'Family')");

            
        }
        
        public override void Down()
        {
        }
    }
}
