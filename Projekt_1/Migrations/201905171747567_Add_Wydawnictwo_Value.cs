namespace Projekt_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Wydawnictwo_Value : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Wydawnictwoes ON");
            Sql("INSERT INTO Wydawnictwoes (Id, NazwaWydawnictwa, Skrot, Kraj, Miejscowosc, kodPocztowy, Ulica, numerTelefonu, eMail, stronaWWW) " +
                "VALUES (2,'ZamKor', 'ZamKor', 'Polska', 'Kraków', '31-352', 'ul. Tetmajera 19' , 'Brak', 'brak', 'brak')");
            Sql("INSERT INTO Wydawnictwoes (Id, NazwaWydawnictwa, Skrot, Kraj, Miejscowosc, kodPocztowy, Ulica, numerTelefonu, eMail, stronaWWW) " +
                "VALUES (3,'Œwiat Ksi¹¿ki', 'ŒK', 'Polska', 'Warszawa', '02-103', 'ul. Stefana Kazimierza Hankiewicza 2' , '22 733 51 50', 'bok@swiatksiazki.pl', 'https://www.swiatksiazki.pl/')");
            Sql("SET IDENTITY_INSERT Wydawnictwoes OFF");
        }
        
        public override void Down()
        {
        }
    }
}
