namespace SmartCanteen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Balance", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Users", "StudentID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "StudentID", c => c.Int());
            AlterColumn("dbo.Users", "Balance", c => c.Single());
        }
    }
}
