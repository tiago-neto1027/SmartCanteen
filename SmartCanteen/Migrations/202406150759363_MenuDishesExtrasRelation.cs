namespace SmartCanteen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MenuDishesExtrasRelation : DbMigration
    {
        public override void Up()
        {
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
            DropForeignKey("dbo.MenuExtras", "Extra_ID", "dbo.Extras");
            DropForeignKey("dbo.MenuExtras", "Menu_ID", "dbo.Menus");
            DropForeignKey("dbo.MenuDishes", "Dish_ID", "dbo.Dishes");
            DropForeignKey("dbo.MenuDishes", "Menu_ID", "dbo.Menus");
            DropIndex("dbo.MenuExtras", new[] { "Extra_ID" });
            DropIndex("dbo.MenuExtras", new[] { "Menu_ID" });
            DropIndex("dbo.MenuDishes", new[] { "Dish_ID" });
            DropIndex("dbo.MenuDishes", new[] { "Menu_ID" });
            DropTable("dbo.MenuExtras");
            DropTable("dbo.MenuDishes");
        }
    }
}
