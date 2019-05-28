namespace Projekt_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Tworca_Value : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Autorzies ON");
            Sql("INSERT INTO Autorzies (Id, Imie, Nazwisko) VALUES (1, 'Andrzej', 'Sapkowski')");
            Sql("INSERT INTO Autorzies (Id, Imie, Nazwisko) VALUES (2, 'Stephen', 'King')");
            Sql("INSERT INTO Autorzies (Id, Imie, Nazwisko) VALUES (3, 'Dmitrij', 'G³uchowski')");
            Sql("INSERT INTO Autorzies (Id, Imie, Nazwisko) VALUES (4, 'J.R.R.', 'Tolkien')");
            Sql("INSERT INTO Autorzies (Id, Imie, Nazwisko) VALUES (5, 'Robert', 'Wegner')");
            Sql("INSERT INTO Autorzies (Id, Imie, Nazwisko) VALUES (6, 'Susanna', 'Clarke')");
            Sql("INSERT INTO Autorzies (Id, Imie, Nazwisko) VALUES (7, 'Peter', 'V. Brett')");
            Sql("INSERT INTO Autorzies (Id, Imie, Nazwisko) VALUES (8, 'Robert', 'E. Howard')");
            Sql("INSERT INTO Autorzies (Id, Imie, Nazwisko) VALUES (9, 'Robert', 'Holdstock')");
            Sql("INSERT INTO Autorzies (Id, Imie, Nazwisko) VALUES (10, 'Scott', 'Lynch')");
            Sql("SET IDENTITY_INSERT Autorzies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
