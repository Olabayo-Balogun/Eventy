namespace Eventy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingMaterialsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        TransactionId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        DateOfReturn = c.DateTime(nullable: false),
                        QuantityRequested = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DateAdded = c.DateTime(nullable: false),
                        PricePerDay = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        Image = c.String(),
                        IsAvailable = c.Byte(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        CartItem_TransactionId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.CartItems", t => t.CartItem_TransactionId)
                .Index(t => t.CategoryId)
                .Index(t => t.CartItem_TransactionId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Materials", "CartItem_TransactionId", "dbo.CartItems");
            DropForeignKey("dbo.Materials", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.CartItems", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Materials", new[] { "CartItem_TransactionId" });
            DropIndex("dbo.Materials", new[] { "CategoryId" });
            DropIndex("dbo.CartItems", new[] { "CustomerId" });
            DropTable("dbo.Categories");
            DropTable("dbo.Materials");
            DropTable("dbo.CartItems");
        }
    }
}
