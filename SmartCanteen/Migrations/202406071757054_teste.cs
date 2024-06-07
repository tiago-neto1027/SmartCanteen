namespace SmartCanteen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Dishes");
            DropPrimaryKey("dbo.Extras");
            DropPrimaryKey("dbo.Fines");
            DropPrimaryKey("dbo.Invoices");
            DropPrimaryKey("dbo.InvoiceItems");
            DropPrimaryKey("dbo.Menus");
            AddColumn("dbo.Dishes", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Dishes", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.Extras", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Extras", "Type", c => c.Int(nullable: false));
            AddColumn("dbo.Fines", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Invoices", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.InvoiceItems", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Menus", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Dishes", "Description", c => c.String());
            AlterColumn("dbo.Extras", "Description", c => c.String());
            AlterColumn("dbo.InvoiceItems", "Description", c => c.String());
            AddPrimaryKey("dbo.Dishes", "ID");
            AddPrimaryKey("dbo.Extras", "ID");
            AddPrimaryKey("dbo.Fines", "ID");
            AddPrimaryKey("dbo.Invoices", "ID");
            AddPrimaryKey("dbo.InvoiceItems", "ID");
            AddPrimaryKey("dbo.Menus", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Menus");
            DropPrimaryKey("dbo.InvoiceItems");
            DropPrimaryKey("dbo.Invoices");
            DropPrimaryKey("dbo.Fines");
            DropPrimaryKey("dbo.Extras");
            DropPrimaryKey("dbo.Dishes");
            AlterColumn("dbo.InvoiceItems", "Description", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Extras", "Description", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Dishes", "Description", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Menus", "ID");
            DropColumn("dbo.InvoiceItems", "ID");
            DropColumn("dbo.Invoices", "ID");
            DropColumn("dbo.Fines", "ID");
            DropColumn("dbo.Extras", "Type");
            DropColumn("dbo.Extras", "ID");
            DropColumn("dbo.Dishes", "Type");
            DropColumn("dbo.Dishes", "ID");
            AddPrimaryKey("dbo.Menus", "date");
            AddPrimaryKey("dbo.InvoiceItems", "description");
            AddPrimaryKey("dbo.Invoices", "total");
            AddPrimaryKey("dbo.Fines", "numHours");
            AddPrimaryKey("dbo.Extras", "description");
            AddPrimaryKey("dbo.Dishes", "description");
        }
    }
}
