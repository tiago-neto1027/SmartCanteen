namespace SmartCanteen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MealTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "Time", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Menus", "Time");
        }
    }
}
