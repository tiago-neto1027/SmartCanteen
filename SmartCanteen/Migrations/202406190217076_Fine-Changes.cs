namespace SmartCanteen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FineChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fines", "Value", c => c.Double(nullable: false));
            AlterColumn("dbo.Fines", "NumHours", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Fines", "NumHours", c => c.Single(nullable: false));
            DropColumn("dbo.Fines", "Value");
        }
    }
}
