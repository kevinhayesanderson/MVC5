namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingMovies : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock) 
                              VALUES ('Avatar',18,'2008-12-09','2008-11-11',140)");
            Sql(@"INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock) 
                              VALUES ('Wall-E',3,'2008-12-09','2010-07-21',150)");
            Sql(@"INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock) 
                              VALUES ('Venom',21,'2008-12-09','2018-11-09',10)");
            Sql(@"INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock) 
                              VALUES ('Avengers',21,'2008-12-09','2017-06-15',70)");
            Sql(@"INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock) 
                              VALUES ('GodFather',8,'2008-12-09','1994-03-28',56)");
            Sql(@"INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock) 
                              VALUES ('I-Robot',18,'2008-12-09','2005-04-16',78)");
            Sql(@"INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock) 
                              VALUES ('Matrix',18,'2008-12-09','1999-05-09',44)");
            Sql(@"INSERT INTO Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock) 
                              VALUES ('Harry Potter',10,'2008-12-09','2006-12-12',210)");
        }
        
        public override void Down()
        {
        }
    }
}
