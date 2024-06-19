namespace SmartCanteen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DishRelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "DishID", c => c.Int(nullable: false));
            CreateIndex("dbo.Reservations", "DishID");
            AddForeignKey("dbo.Reservations", "DishID", "dbo.Dishes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "DishID", "dbo.Dishes");
            DropIndex("dbo.Reservations", new[] { "DishID" });
            DropColumn("dbo.Reservations", "DishID");
        }
    }
}
