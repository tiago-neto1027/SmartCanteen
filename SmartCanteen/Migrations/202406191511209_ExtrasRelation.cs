namespace SmartCanteen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtrasRelation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReservationExtras",
                c => new
                    {
                        Reservation_ID = c.Int(nullable: false),
                        Extra_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reservation_ID, t.Extra_ID })
                .ForeignKey("dbo.Reservations", t => t.Reservation_ID, cascadeDelete: true)
                .ForeignKey("dbo.Extras", t => t.Extra_ID, cascadeDelete: true)
                .Index(t => t.Reservation_ID)
                .Index(t => t.Extra_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReservationExtras", "Extra_ID", "dbo.Extras");
            DropForeignKey("dbo.ReservationExtras", "Reservation_ID", "dbo.Reservations");
            DropIndex("dbo.ReservationExtras", new[] { "Extra_ID" });
            DropIndex("dbo.ReservationExtras", new[] { "Reservation_ID" });
            DropTable("dbo.ReservationExtras");
        }
    }
}
