namespace Projekt_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Required_Autorzy_Imie : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Autorzies", "Imie", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Autorzies", "Imie", c => c.String(maxLength: 50));
        }
    }
}
