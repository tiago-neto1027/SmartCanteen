namespace SmartCanteen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fist : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        nif = c.String(),
                        balance = c.Single(),
                        email = c.String(),
                        StudentID = c.Int(),
                        username = c.String(),
                        password = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        description = c.String(nullable: false, maxLength: 128),
                        active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.description);
            
            CreateTable(
                "dbo.Extras",
                c => new
                    {
                        description = c.String(nullable: false, maxLength: 128),
                        price = c.Double(nullable: false),
                        active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.description);
            
            CreateTable(
                "dbo.Fines",
                c => new
                    {
                        numHours = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.numHours);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        total = c.Double(nullable: false),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.total);
            
            CreateTable(
                "dbo.InvoiceItems",
                c => new
                    {
                        description = c.String(nullable: false, maxLength: 128),
                        price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.description);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        date = c.DateTime(nullable: false),
                        quantity = c.Int(nullable: false),
                        studentPrice = c.Double(nullable: false),
                        teacherPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.date);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Menus");
            DropTable("dbo.InvoiceItems");
            DropTable("dbo.Invoices");
            DropTable("dbo.Fines");
            DropTable("dbo.Extras");
            DropTable("dbo.Dishes");
            DropTable("dbo.Users");
        }
    }
}
