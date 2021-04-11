namespace Eventy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedCustomerClassProperties : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipType_Id" });
            AlterColumn("dbo.Customers", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Customers", "EmailAddress", c => c.String(nullable: false, maxLength: 110));
            AlterColumn("dbo.Customers", "HomeAddress", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Customers", "MembershipType_Id", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MembershipType_Id");
            AddForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipType_Id" });
            AlterColumn("dbo.Customers", "MembershipType_Id", c => c.Byte());
            AlterColumn("dbo.Customers", "HomeAddress", c => c.String(maxLength: 250));
            AlterColumn("dbo.Customers", "EmailAddress", c => c.String(maxLength: 100));
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String(maxLength: 11));
            AlterColumn("dbo.Customers", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customers", "FirstName", c => c.String(maxLength: 50));
            CreateIndex("dbo.Customers", "MembershipType_Id");
            AddForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes", "Id");
        }
    }
}
