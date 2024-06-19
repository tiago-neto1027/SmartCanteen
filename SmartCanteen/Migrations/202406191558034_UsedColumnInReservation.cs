namespace SmartCanteen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsedColumnInReservation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "Used", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "Used");
        }
    }
}
