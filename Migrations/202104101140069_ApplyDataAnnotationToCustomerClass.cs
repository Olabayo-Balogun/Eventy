namespace Eventy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class ApplyDataAnnotationToCustomerClass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "EmailAddress", c => c.String(maxLength: 100));
        }

        public override void Down()
        {
            AlterColumn("dbo.Customers", "EmailAddress", c => c.String(maxLength: 150));
        }
    }
}