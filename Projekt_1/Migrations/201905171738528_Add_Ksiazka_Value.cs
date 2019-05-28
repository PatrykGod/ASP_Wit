namespace Projekt_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Ksiazka_Value : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Ksiazkas ON");
            Sql("INSERT INTO Ksiazkas (Id, Tytul, UKD, Opis) VALUES (1,'Wied�min - Ostatnie �yczenie','21','Opis1')");
            Sql("INSERT INTO Ksiazkas (Id, Tytul, UKD, Opis) VALUES (2,'Wied�min - Miecz przeznaczenia','21','Opis2')");
            Sql("INSERT INTO Ksiazkas (Id, Tytul, UKD, Opis) VALUES (3,'Wied�min - Krew elf�w','22','Opis3')");
            Sql("INSERT INTO Ksiazkas (Id, Tytul, UKD, Opis) VALUES (4,'Wied�min - Czas pogardy','23','Opis4')");
            Sql("INSERT INTO Ksiazkas (Id, Tytul, UKD, Opis) VALUES (5,'Wied�min - Chrzest ognia','24','Opis5')");
            Sql("INSERT INTO Ksiazkas (Id, Tytul, UKD, Opis) VALUES (6,'Wied�min - Wie�a Jask�ki','25','Opis6')");
            Sql("INSERT INTO Ksiazkas (Id, Tytul, UKD, Opis) VALUES (7,'Wied�min - Pani Jeziora','26','Opis7')");
            Sql("INSERT INTO Ksiazkas (Id, Tytul, UKD, Opis) VALUES (8,'Wied�min - Sezon burz','27','Opis8')");
            Sql("SET IDENTITY_INSERT Ksiazkas OFF");
        }
        
        public override void Down()
        {
        }
    }
}
