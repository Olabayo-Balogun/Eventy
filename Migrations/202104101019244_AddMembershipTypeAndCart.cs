namespace Eventy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddMembershipTypeAndCart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                {
                    Id = c.Byte(nullable: false),
                    SignUpFee = c.Short(nullable: false),
                    DurationInMonths = c.Byte(nullable: false),
                    DiscountRate = c.Byte(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            AddColumn("dbo.Customers", "DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "Image", c => c.String());
            AddColumn("dbo.Customers", "MembershipType_Id", c => c.Byte());
            CreateIndex("dbo.Customers", "MembershipType_Id");
            AddForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes", "Id");
            DropColumn("dbo.Customers", "Age");
        }

        public override void Down()
        {
            AddColumn("dbo.Customers", "Age", c => c.Int(nullable: false));
            DropForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipType_Id" });
            DropColumn("dbo.Customers", "MembershipType_Id");
            DropColumn("dbo.Customers", "Image");
            DropColumn("dbo.Customers", "DateOfBirth");
            DropTable("dbo.MembershipTypes");
        }
    }
}