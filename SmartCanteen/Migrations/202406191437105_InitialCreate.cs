namespace SmartCanteen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Type = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        StudentPrice = c.Double(nullable: false),
                        TeacherPrice = c.Double(nullable: false),
                        Time = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Extras",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Type = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        MealTime = c.Int(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        MenuID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Menus", t => t.MenuID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.MenuID)
                .Index(t => t.UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NIF = c.String(),
                        Balance = c.Decimal(precision: 18, scale: 2),
                        Email = c.String(),
                        StudentID = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Fines",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NumHours = c.Int(nullable: false),
                        Value = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Total = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.InvoiceItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MenuDishes",
                c => new
                    {
                        Menu_ID = c.Int(nullable: false),
                        Dish_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Menu_ID, t.Dish_ID })
                .ForeignKey("dbo.Menus", t => t.Menu_ID, cascadeDelete: true)
                .ForeignKey("dbo.Dishes", t => t.Dish_ID, cascadeDelete: true)
                .Index(t => t.Menu_ID)
                .Index(t => t.Dish_ID);
            
            CreateTable(
                "dbo.MenuExtras",
                c => new
                    {
                        Menu_ID = c.Int(nullable: false),
                        Extra_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Menu_ID, t.Extra_ID })
                .ForeignKey("dbo.Menus", t => t.Menu_ID, cascadeDelete: true)
                .ForeignKey("dbo.Extras", t => t.Extra_ID, cascadeDelete: true)
                .Index(t => t.Menu_ID)
                .Index(t => t.Extra_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "UserID", "dbo.Users");
            DropForeignKey("dbo.Reservations", "MenuID", "dbo.Menus");
            DropForeignKey("dbo.MenuExtras", "Extra_ID", "dbo.Extras");
            DropForeignKey("dbo.MenuExtras", "Menu_ID", "dbo.Menus");
            DropForeignKey("dbo.MenuDishes", "Dish_ID", "dbo.Dishes");
            DropForeignKey("dbo.MenuDishes", "Menu_ID", "dbo.Menus");
            DropIndex("dbo.MenuExtras", new[] { "Extra_ID" });
            DropIndex("dbo.MenuExtras", new[] { "Menu_ID" });
            DropIndex("dbo.MenuDishes", new[] { "Dish_ID" });
            DropIndex("dbo.MenuDishes", new[] { "Menu_ID" });
            DropIndex("dbo.Reservations", new[] { "UserID" });
            DropIndex("dbo.Reservations", new[] { "MenuID" });
            DropTable("dbo.MenuExtras");
            DropTable("dbo.MenuDishes");
            DropTable("dbo.InvoiceItems");
            DropTable("dbo.Invoices");
            DropTable("dbo.Fines");
            DropTable("dbo.Users");
            DropTable("dbo.Reservations");
            DropTable("dbo.Extras");
            DropTable("dbo.Menus");
            DropTable("dbo.Dishes");
        }
    }
}
