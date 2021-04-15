namespace Eventy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "FirstName", c => c.String());
            AddColumn("dbo.Customers", "LastName", c => c.String());
            AddColumn("dbo.Customers", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "PhoneNumber", c => c.String());
            AddColumn("dbo.Customers", "EmailAddress", c => c.String());
            AddColumn("dbo.Customers", "HomeAddress", c => c.String());
            DropColumn("dbo.Customers", "Name");
        }

        public override void Down()
        {
            AddColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.Customers", "HomeAddress");
            DropColumn("dbo.Customers", "EmailAddress");
            DropColumn("dbo.Customers", "PhoneNumber");
            DropColumn("dbo.Customers", "Age");
            DropColumn("dbo.Customers", "LastName");
            DropColumn("dbo.Customers", "FirstName");
        }
    }
}