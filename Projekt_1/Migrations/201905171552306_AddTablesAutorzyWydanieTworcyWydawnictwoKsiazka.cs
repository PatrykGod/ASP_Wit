namespace Projekt_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablesAutorzyWydanieTworcyWydawnictwoKsiazka : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ksiazkas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tytul = c.String(maxLength: 255),
                        UKD = c.String(maxLength: 50),
                        Opis = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Tworcies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AutorzyId = c.Int(nullable: false),
                        KsiazkaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Autorzies", t => t.AutorzyId, cascadeDelete: true)
                .ForeignKey("dbo.Ksiazkas", t => t.KsiazkaId, cascadeDelete: true)
                .Index(t => t.AutorzyId)
                .Index(t => t.KsiazkaId);
            
            CreateTable(
                "dbo.Autorzies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Imie = c.String(maxLength: 50),
                        Nazwisko = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Wydanies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ISBN = c.String(nullable: false),
                        rokWydania = c.String(maxLength: 4),
                        numerWydania = c.String(maxLength: 20),
                        liczbaStron = c.String(maxLength: 20),
                        zdjecieNazwa = c.String(),
                        KsiazkaId = c.Int(nullable: false),
                        WydawnictwoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ksiazkas", t => t.KsiazkaId, cascadeDelete: true)
                .ForeignKey("dbo.Wydawnictwoes", t => t.WydawnictwoId, cascadeDelete: true)
                .Index(t => t.KsiazkaId)
                .Index(t => t.WydawnictwoId);
            
            CreateTable(
                "dbo.Wydawnictwoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NazwaWydawnictwa = c.String(maxLength: 255),
                        Skrot = c.String(maxLength: 15),
                        Kraj = c.String(maxLength: 50),
                        Miejscowosc = c.String(maxLength: 50),
                        kodPocztowy = c.String(maxLength: 50),
                        Ulica = c.String(maxLength: 50),
                        numerTelefonu = c.String(maxLength: 15),
                        eMail = c.String(maxLength: 100),
                        stronaWWW = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Wydanies", "WydawnictwoId", "dbo.Wydawnictwoes");
            DropForeignKey("dbo.Wydanies", "KsiazkaId", "dbo.Ksiazkas");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Tworcies", "KsiazkaId", "dbo.Ksiazkas");
            DropForeignKey("dbo.Tworcies", "AutorzyId", "dbo.Autorzies");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.Wydanies", new[] { "WydawnictwoId" });
            DropIndex("dbo.Wydanies", new[] { "KsiazkaId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Tworcies", new[] { "KsiazkaId" });
            DropIndex("dbo.Tworcies", new[] { "AutorzyId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.Wydawnictwoes");
            DropTable("dbo.Wydanies");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Autorzies");
            DropTable("dbo.Tworcies");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Ksiazkas");
        }
    }
}
