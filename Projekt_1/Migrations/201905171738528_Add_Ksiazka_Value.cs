namespace Projekt_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Ksiazka_Value : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Ksiazkas ON");
            Sql("INSERT INTO Ksiazkas (Id, Tytul, UKD, Opis) VALUES (1,'Wiedümin - Ostatnie Øyczenie','21','Opis1')");
            Sql("INSERT INTO Ksiazkas (Id, Tytul, UKD, Opis) VALUES (2,'Wiedümin - Miecz przeznaczenia','21','Opis2')");
            Sql("INSERT INTO Ksiazkas (Id, Tytul, UKD, Opis) VALUES (3,'Wiedümin - Krew elfÛw','22','Opis3')");
            Sql("INSERT INTO Ksiazkas (Id, Tytul, UKD, Opis) VALUES (4,'Wiedümin - Czas pogardy','23','Opis4')");
            Sql("INSERT INTO Ksiazkas (Id, Tytul, UKD, Opis) VALUES (5,'Wiedümin - Chrzest ognia','24','Opis5')");
            Sql("INSERT INTO Ksiazkas (Id, Tytul, UKD, Opis) VALUES (6,'Wiedümin - Wieøa JaskÛ≥ki','25','Opis6')");
            Sql("INSERT INTO Ksiazkas (Id, Tytul, UKD, Opis) VALUES (7,'Wiedümin - Pani Jeziora','26','Opis7')");
            Sql("INSERT INTO Ksiazkas (Id, Tytul, UKD, Opis) VALUES (8,'Wiedümin - Sezon burz','27','Opis8')");
            Sql("SET IDENTITY_INSERT Ksiazkas OFF");
        }
        
        public override void Down()
        {
        }
    }
}
