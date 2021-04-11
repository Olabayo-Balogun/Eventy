namespace Eventy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedCartItemClassProperties : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CartItems", "CustomerId", "dbo.Customers");
            DropIndex("dbo.CartItems", new[] { "CustomerId" });
            RenameColumn(table: "dbo.CartItems", name: "CustomerId", newName: "Customer_Id");
            AlterColumn("dbo.CartItems", "Customer_Id", c => c.Int());
            CreateIndex("dbo.CartItems", "Customer_Id");
            AddForeignKey("dbo.CartItems", "Customer_Id", "dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CartItems", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.CartItems", new[] { "Customer_Id" });
            AlterColumn("dbo.CartItems", "Customer_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.CartItems", name: "Customer_Id", newName: "CustomerId");
            CreateIndex("dbo.CartItems", "CustomerId");
            AddForeignKey("dbo.CartItems", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
